using FurnitureStore.Application.Views.Common;

namespace FurnitureStore.Application.Presenters.Common;

public abstract class BasePresenter<T>(T view) : IPresenter, IDisposable where T : IView
{
    private bool _disposed;

    protected readonly T _view = view;
    public T View => _view;

    public void Run()
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