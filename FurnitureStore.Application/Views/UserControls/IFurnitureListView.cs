using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Views.UserControls;

public interface IFurnitureListView
{
    public event EventHandler CreateButtonClick;

    public void AddToList(FurnitureModel model);
    public void RemoveFromList(FurnitureModel model);
    public void ClearList();
}