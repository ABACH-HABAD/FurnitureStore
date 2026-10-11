using System.ComponentModel;
using FurnitureStore.Application.Views.Forms.Common;
using FurnitureStore.Application.Views.UserControls;
using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Views.Forms;

public interface IMainView : IView
{
    public event EventHandler ShowingSalesChartClicked;
    public event EventHandler Exiting;

    public event EventHandler ShowingFurnitureList;
    public event EventHandler ShowingMainMenu;

    public IMainMenuView MainMenuView { get; }
    public IFurnitureListView FurnitureListView { get; }

    public void ShowFurnitureList();
    public void ShowMainMenu();
}