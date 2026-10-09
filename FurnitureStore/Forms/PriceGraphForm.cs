using FurnitureStore.Application.Views;
using FurnitureStore.Controls.Gdi;

namespace FurnitureStore.Forms;

public partial class PriceGraphForm : Form, IPriceGraphView
{
    private readonly PriceHistoryGraphControl _graph;

    public PriceGraphForm()
    {
        _graph = new()
        {
            Dock = DockStyle.Fill,
        };

        Controls.Add(_graph);

        InitializeComponent();
    }
}
