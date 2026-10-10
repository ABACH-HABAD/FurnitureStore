using FurnitureStore.Application.Views.Common;

namespace FurnitureStore.Application.Views;

public interface ISalesChartGraphView : IView
{
    public GraphView GraphView { get; set; }
}