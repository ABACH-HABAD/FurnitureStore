using FurnitureStore.Application.Presenters.Common;
using FurnitureStore.Application.Views;

namespace FurnitureStore.Application.Presenters;

public class PriceGraphPresenter(IPriceGraphView view) : BasePresenter<IPriceGraphView>(view)
{
    protected override void OnDispose()
    {

    }
}