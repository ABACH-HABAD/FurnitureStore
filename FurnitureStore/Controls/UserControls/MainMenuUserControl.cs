using FurnitureStore.Application.Views;

namespace FurnitureStore.Controls.UserControls
{
    public partial class MainMenuUserControl : UserControl, IMainMenuView
    {
        public MainMenuUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler? ShowProductListClick;
        public event EventHandler? GenerateSalesReportClick;
        public event EventHandler? ExitClick;

        private void ShowProductListButton_Click(object sender, EventArgs e)
        {
            ShowProductListClick?.Invoke(sender, e);
        }

        private void GenerateSalesReportButton_Click(object sender, EventArgs e)
        {
            GenerateSalesReportClick?.Invoke(sender, e);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitClick?.Invoke(sender, e);
        }
    }
}
