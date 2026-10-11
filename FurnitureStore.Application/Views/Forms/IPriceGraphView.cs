using FurnitureStore.Application.Views.Forms.Common;
using FurnitureStore.Application.Views.GdiControls.Common;

namespace FurnitureStore.Application.Views.Forms;

public interface IPriceGraphView : IView
{
    public GraphView GraphView { get; set; }
}