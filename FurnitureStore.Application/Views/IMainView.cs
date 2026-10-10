using System.ComponentModel;
using FurnitureStore.Application.Views.Common;
using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Views;

public interface IMainView : IView
{
    public event EventHandler ShowSalesChartClicked;
    public event EventHandler ShowOneMoreShitClicked;

    public IFurnitureListView FurnitureList { get; }
}