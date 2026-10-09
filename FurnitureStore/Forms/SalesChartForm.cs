using FurnitureStore.Application.Views;

namespace FurnitureStore.Forms
{
    public partial class SalesChartForm : Form, ISalesChartView
    {
        public SalesChartForm()
        {
            InitializeComponent();
        }

        public void ShowMessage(string text)
        {
            throw new NotImplementedException();
        }
    }
}
