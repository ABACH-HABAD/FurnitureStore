using FurnitureStore.Application.Abstractions;
using FurnitureStore.Application.Views;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureStore;

public partial class MainForm : Form, IMainView
{
    public event EventHandler? ShowSalesChartClicked;

    public MainForm()
    {
        InitializeComponent();
    }

    private void ShowSalesButtonClick(object sender, EventArgs e)
    {
        ShowSalesChartClicked?.Invoke(sender, e);
    }
}