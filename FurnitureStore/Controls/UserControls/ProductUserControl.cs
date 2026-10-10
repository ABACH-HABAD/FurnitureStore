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
        NameTextBlock.Text = furniture.Name;
        PriceTextBlock.Text = furniture.Price.ToString();
        DesctiptionTextBlock.Text = furniture.Description;
    }
}
