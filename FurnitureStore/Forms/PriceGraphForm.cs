using FurnitureStore.Application.Views.Forms;
using FurnitureStore.Application.Views.GdiControls.Common;
using FurnitureStore.Controls.Gdi;
using System.ComponentModel;

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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GraphView GraphView
    {
        get => _graph.GraphView;
        set => _graph.GraphView = value;
    }
}
