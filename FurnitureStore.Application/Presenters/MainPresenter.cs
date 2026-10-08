using FurnitureStore.Application.Presenters.Common;
using FurnitureStore.Application.Views;

namespace FurnitureStore.Application.Presenters;

public class MainPresenter(IMainView mainView) : BasePresenter<IMainView>(mainView)
{

}