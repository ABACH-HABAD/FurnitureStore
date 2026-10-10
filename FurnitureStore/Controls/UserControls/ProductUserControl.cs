using FurnitureStore.Domain.Models;

namespace FurnitureStore.Controls.UserControls;

public partial class ProductUserControl : UserControl
{
    public event EventHandler EditButtonClick
    {
        add => EditButton.Click += value;
        remove => EditButton.Click -= value;
    }
    
    public event EventHandler DeleteButtonClick
    {
        add => DeleteButton.Click += value;
        remove => DeleteButton.Click -= value;
    }

    public ProductUserControl()
    {
        InitializeComponent();
    }

    public void BindToFurniture(FurnitureModel furniture)
    {
        NameTextBlock.DataBindings.Add("Text", furniture, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
        PriceTextBlock.DataBindings.Add("Text", furniture, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
        DesctiptionTextBlock.DataBindings.Add("Text", furniture, "Desctiption", true, DataSourceUpdateMode.OnPropertyChanged);
    }
}
