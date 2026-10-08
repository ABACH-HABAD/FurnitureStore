using FurnitureStore.Application.Views.Common;

namespace FurnitureStore.Application.Presenters.Common;

public class BasePresenter<T>(T view) where T : IView
{
    protected readonly T _view = view;
}