using System.ComponentModel;
using FurnitureStore.Application.Views;
using FurnitureStore.Application.Views.Common;
using FurnitureStore.Controls.Gdi;

namespace FurnitureStore.Forms;

public partial class SalesChartGraphForm : Form, ISalesChartGraphView
{
    private readonly SalesCountsGraphControl _graph;

    public SalesChartGraphForm()
    {
        _graph = new SalesCountsGraphControl()
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