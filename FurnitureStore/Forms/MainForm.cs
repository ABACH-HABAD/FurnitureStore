using FurnitureStore.Application.Abstractions;
using FurnitureStore.Application.Views;
using FurnitureStore.Controls.UserControls;
using FurnitureStore.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace FurnitureStore;

public partial class MainForm : Form, IMainView
{
    public IFurnitureListView FurnitureList => ListOfProducts;

    public event EventHandler? ShowSalesChartClicked;
    public event EventHandler? ShowOneMoreShitClicked;

    public MainForm()
    {
        InitializeComponent();
    }

    private void ShowSalesButtonClick(object sender, EventArgs e)
    {
        ShowSalesChartClicked?.Invoke(sender, e);
    }

    private void ShowBtwShitBotton_Click(object sender, EventArgs e)
    {
        ShowOneMoreShitClicked?.Invoke(sender, e);
    }


}