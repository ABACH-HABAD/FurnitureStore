namespace FurnitureStore.Application.Views.UserControls;

public interface IMainMenuView
{
    public event EventHandler ShowProductListClick;
    public event EventHandler GenerateSalesReportClick;
    public event EventHandler ExitClick;
}