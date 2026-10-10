using System.ComponentModel;
using FurnitureStore.Domain.Models;
using FurnitureStore.Application.Views;

namespace FurnitureStore.Controls.UserControls;

public partial class ListOfProductsUserControl : UserControl, IFurnitureListView
{
    public event EventHandler CreateButtonClick
    {
        add => CreateButton.Click += value;
        remove => CreateButton.Click -= value;
    }

    private readonly BindingList<FurnitureModel> _furnituresList = [];

    public ListOfProductsUserControl()
    {
        _furnituresList.ListChanged += OnListChanged;
        InitializeComponent();
    }

    public void AddToList(FurnitureModel model) => _furnituresList.Add(model);
    public void RemoveFromList(FurnitureModel model) => _furnituresList.Remove(model);
    public void ClearList() => _furnituresList.Clear();

    private void OnListChanged(object? sender, ListChangedEventArgs e)
    {
        switch (e.ListChangedType)
        {
            case ListChangedType.ItemAdded:
                ProductUserControl createdControl = new();
                createdControl.BindToFurniture(_furnituresList[e.NewIndex]);
                FlowPanel.Controls.Add(createdControl);
                break;
            case ListChangedType.ItemDeleted:
                Control deletedControl = FlowPanel.Controls[e.NewIndex];
                FlowPanel.Controls.Remove(deletedControl);
                deletedControl.Dispose();
                break;
            case ListChangedType.Reset:
                foreach (Control clearedControl in FlowPanel.Controls)
                {
                    clearedControl.Dispose();
                }
                FlowPanel.Controls.Clear();
                break;
            default:
                break;
        }
    }
}