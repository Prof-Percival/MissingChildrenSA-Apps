using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MissingChildrenSA.Models;
using System.ComponentModel.DataAnnotations;

namespace MissingChildrenSA.PageModels
{
    public partial class ReportMissingPersonPageModel : ObservableObject
    {
        private readonly ApiClient _apiClient;
        private readonly EnumLoader _enumLoader;
        private readonly ModalErrorHandler _errorHandler;

        [ObservableProperty]
        private bool _isExistingMissingPerson;

        [ObservableProperty]
        private MissingPerson _missingPerson = new();

        [ObservableProperty]
        private List<string> _genders = [];

        [ObservableProperty]
        private List<string> _provinces = [];

        [ObservableProperty]
        private List<string> _races = [];

        [ObservableProperty]
        private string _imageUrl;

        [ObservableProperty]
        private Dictionary<string, List<string>> _validationErrors = [];

        [ObservableProperty]
        private Dictionary<string, bool> _hasError = [];

        public ReportMissingPersonPageModel(
            ModalErrorHandler errorHandler,
            ApiClient apiClient,
            EnumLoader enumLoader)
        {
            _errorHandler = errorHandler;
            _apiClient = apiClient;
            _enumLoader = enumLoader;

            PopulateDropdownValues();
        }

        private void PopulateDropdownValues()
        {
            Genders = [.. _enumLoader.Genders.Select(g => g.Description)];
            Provinces = _enumLoader.Provinces.ConvertAll(p => p.Description);
            Races = _enumLoader.Races.ConvertAll(r => r.Description);
        }

        [RelayCommand]
        private async Task SelectImage()
        {
            try
            {
                // Pick the image using MediaPicker
                var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Select an image",
                });

                if (result == null)
                    return;

                await using var stream = await result.OpenReadAsync();

                var fileName = result.FileName;

                var contentType = ImageExtensionHelper.GetContentType(fileName);

                var fileParameter = new FileParameter(stream, fileName, contentType);

                var imageMetadata = await _apiClient.UploadImageAsync(fileParameter);

                if (string.IsNullOrWhiteSpace(imageMetadata?.FileUrl))
                {
                    await AppShell.DisplayToastAsync("Image upload failed. Please try again.");

                    return;
                }

                // Set the image URL so the preview updates
                ImageUrl = imageMetadata.FileUrl;

                MissingPerson.ImageUrl = ImageUrl;
            }
            catch (Exception ex)
            {
                _errorHandler.HandleError(ex);
            }
        }

        [RelayCommand]
        private async Task Save()
        {
            ValidationErrors.Clear();
            HasError.Clear();

            var context = new ValidationContext(MissingPerson);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(MissingPerson, context, results, true))
            {
                foreach (var validationResult in results)
                {
                    foreach (var key in validationResult.MemberNames)
                    {
                        if (!ValidationErrors.ContainsKey(key))
                            ValidationErrors[key] = [];

                        ValidationErrors[key].Add(validationResult.ErrorMessage);
                        HasError[key] = true;
                    }
                }

                if (ValidationErrors.Count == 1 &&
                    ValidationErrors.TryGetValue(nameof(ImageUrl), out _))
                {
                    _errorHandler.DisplayMessage("Please upload an image.");
                }
                else
                {
                    _errorHandler.DisplayMessage("Please correct the errors");
                }

                OnPropertyChanged(nameof(ValidationErrors));
                OnPropertyChanged(nameof(HasError));

                return;
            }

            var request = new CreateMissingPersonRequest
            {
                FirstName = MissingPerson.FirstName,
                LastName = MissingPerson.LastName,
                DateOfBirth = MissingPerson.DateOfBirth.Value,
                Gender = (Gender)_enumLoader.Genders.Single(g => g.Description == MissingPerson.Gender).Id,
                Race = (Race)_enumLoader.Races.Single(r => r.Description == MissingPerson.Race).Id,
                Province = (Province)_enumLoader.Provinces.Single(p => p.Description == MissingPerson.Province).Id,
                DateWentMissing = MissingPerson.DateWentMissing,
                HairColour = MissingPerson.HairColour,
                HairLengthOrStyle = MissingPerson.HairLengthOrStyle,
                EyeColour = MissingPerson.EyeColour,
                Height = MissingPerson.Height.Value,
                Weight = MissingPerson.Weight.Value,
                MarksTattoos = MissingPerson.MarksTattoos ?? string.Empty,
                LastSeenWearing = MissingPerson.LastSeenWearing,
                LocationLastSeen = MissingPerson.LocationLastSeen,
                ImageUrl = MissingPerson.ImageUrl,
                PoliceStation = MissingPerson.PoliceStation,
                CaseNumber = MissingPerson.CaseNumber,
                InvestigatingOfficer = MissingPerson.InvestigatingOfficer,
                InvestigatingOfficerContactNumber = MissingPerson.InvestigatingOfficerContactNumber,
                FamilyContactName = MissingPerson.FamilyContactName,
                FamilyContactNumber = MissingPerson.FamilyContactNumber,
            };

            try
            {
                await _apiClient.ReportMissingPersonAsync(request);
            }
            catch (ApiException ex)
            {
                _errorHandler.HandleError(ex);

                return;
            }

            await Shell.Current.GoToAsync("..?refresh=true");

            await AppShell.DisplayToastAsync("Missing Person Reported Successsfully!");
        }
    }
}