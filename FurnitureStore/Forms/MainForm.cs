using FurnitureStore.Application.Abstractions;
using FurnitureStore.Application.Views.Forms;
using FurnitureStore.Application.Views.UserControls;
using FurnitureStore.Controls.UserControls;
using FurnitureStore.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace FurnitureStore;

public partial class MainForm : Form, IMainView
{
    public IFurnitureListView FurnitureListView { get; private init; }
    public IMainMenuView MainMenuView { get; private init; }

    public event EventHandler? ShowingSalesChartClicked;
    public event EventHandler? Exiting;

    public event EventHandler? ShowingFurnitureList;
    public event EventHandler? ShowingMainMenu;

    public MainForm(IMainMenuView mainMenuView, IFurnitureListView furnitureListView)
    {
        MainMenuView = mainMenuView;
        FurnitureListView = furnitureListView;

        InitializeComponent();

        Control control = (Control)FurnitureListView;
        control.Dock = DockStyle.Fill;
        ControlPanel.Controls.Add(control);

        control = (Control)MainMenuView;
        control.Dock = DockStyle.Fill;
        ControlPanel.Controls.Add(control);
        control.BringToFront();

        ExitToolStripMenuItem.Click += (s, e) => Exiting?.Invoke(s, e);
        OpenMainMenuToolStripMenuItem.Click += (s, e) => ShowingMainMenu?.Invoke(s, e);
        OpenProductListToolStripMenuItem.Click += (s, e) => ShowingFurnitureList?.Invoke(s, e);
        OpenSaleGraphToolStripMenuItem.Click += (s, e) => ShowingSalesChartClicked?.Invoke(s, e);
    }

    private static void ShowControl(Control oldControl, Control newControl)
    {
        oldControl.Visible = false;
        newControl.Visible = true;
        newControl.BringToFront();
    }

    public void ShowFurnitureList() => ShowControl((Control)MainMenuView, (Control)FurnitureListView);
    public void ShowMainMenu() => ShowControl((Control)FurnitureListView, (Control)MainMenuView);
}