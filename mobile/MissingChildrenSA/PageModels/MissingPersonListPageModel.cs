﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using MissingChildrenSA.Models;

namespace MissingChildrenSA.PageModels;

public partial class MissingPersonListPageModel : ObservableObject
{
    private readonly ApiClient _apiClient;
    private readonly ILogger<MissingPersonListPageModel> _logger;
    private readonly ModalErrorHandler _errorHandler;

    private static int _currentPage = 1;
    private const int PageSize = 10;
    private static int _totalCount = 0;

    [ObservableProperty]
    private List<MissingPersonModel> _missingPersons = [];

    [ObservableProperty]
    bool _isPreviousButtonVisible = _currentPage > 1;

    [ObservableProperty]
    bool _isNextButtonVisible = _totalCount > _currentPage * PageSize;

    public MissingPersonListPageModel(
        ApiClient apiClient,
        ILogger<MissingPersonListPageModel> logger,
        ModalErrorHandler errorHandler)
    {
        _apiClient = apiClient;
        _logger = logger;
        _errorHandler = errorHandler;
    }

    [RelayCommand]
    private async Task Appearing()
    {
        await LoadMissingPersonsAsync();
    }

    [RelayCommand]
    private async Task LoadNextPageAsync()
    {
        _currentPage++;
        await LoadMissingPersonsAsync();
    }

    [RelayCommand]
    private async Task LoadPreviousPageAsync()
    {
        if (_currentPage > 1)
        {
            _currentPage--;
            await LoadMissingPersonsAsync();
        }
    }

    [RelayCommand]
    async Task NavigateToMissingPerson(MissingPersonModel missingPerson)
    {
        try
        {
            string serializedModel = System.Text.Json.JsonSerializer.Serialize(missingPerson, JsonContext.Default.MissingPersonModel);

            await Shell.Current.GoToAsync($"missingperson?model={Uri.EscapeDataString(serializedModel)}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error serializing missing person data");

            _errorHandler.HandleError(ex);
        }
    }

    [RelayCommand]
    static async Task ReportMissingPerson()
    {
        await Shell.Current.GoToAsync($"reportmissingperson");
    }

    private async Task LoadMissingPersonsAsync()
    {
        var response = await _apiClient.FetchApprovedMissingPersonsAsync(_currentPage, PageSize);

        _totalCount = response.TotalCount;

        SetButtonsVisibility();

        MissingPersons = [.. response.MissingPersons.Select(m => new MissingPersonModel(m))];
    }

    private void SetButtonsVisibility()
    {
        IsPreviousButtonVisible = _currentPage > 1;
        IsNextButtonVisible = _totalCount > _currentPage * PageSize;
    }
}