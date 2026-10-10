using FurnitureStore.Application.Views.Common;

namespace FurnitureStore.Application.Presenters.Common;

public abstract class BasePresenter<TView>(TView view) : IPresenter, IDisposable where TView : IView
{
    private bool _disposed;

    protected readonly TView _view = view;
    public TView View => _view;

    public virtual void Run()
    {
        _view.Show();
    }

    public virtual void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            OnDispose();
        }

        _disposed = true;
    }

    protected abstract void OnDispose();
}