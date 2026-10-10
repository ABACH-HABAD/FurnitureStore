using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Presenters.Common;

public interface IDataSetable
{
    public void SetData(object data);
}

public interface IDataSetable<T>
{
    public void SetData(T data);
}