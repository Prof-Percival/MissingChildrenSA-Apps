using MissingChildrenSA.Helpers.Images;

namespace MissingChildrenSA.Forms.MissingPersons;

public partial class MissingPersonTileControl : UserControl
{
    public Models.MissingPersons.MissingPersonModel MissingPerson { get; private set; }

    public event EventHandler TileClicked;

    public MissingPersonTileControl()
    {
        InitializeComponent();
    }

    public async void SetData(Models.MissingPersons.MissingPersonModel person)
    {
        MissingPerson = person;

        LblName.Text = $"{person.FirstName} {person.LastName}";
        LblMissingDate.Text = $"Missing: {person.DateWentMissing}";
        LblReported.Text = $"Reported: {person.Created}";

        await PicPerson.LoadImageFromUrl(person.ImageUrl);
    }

    private void Tile_Click(object sender, EventArgs e) => TileClicked?.Invoke(this, EventArgs.Empty);
}