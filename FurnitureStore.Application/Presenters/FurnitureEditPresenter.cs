using FurnitureStore.Application.Views;
using FurnitureStore.Application.Presenters.Common;

namespace FurnitureStore.Application.Presenters;

public class FurnitureEditPresenter(IFurnitureEditView view) : BasePresenter<IFurnitureEditView>(view)
{
    protected override void OnDispose()
    {
        //throw new NotImplementedException();
    }
}