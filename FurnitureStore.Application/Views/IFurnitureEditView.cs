using FurnitureStore.Application.Views.Common;

namespace FurnitureStore.Application.Views;

public interface IFurnitureEditView : IView
{
    public event EventHandler AcceptClicked;
    public event EventHandler DenyClicked;

    public bool CanClose { get; set; }

    public string FurnitureName { get; set; }
    public string FurniturePrice { get; set; }
    public string FurnitureDescription { get; set; }
}