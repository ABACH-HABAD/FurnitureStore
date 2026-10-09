namespace FurnitureStore.Application.Abstractions;

public interface IMessageService
{
    public void SendMessage(string message);
}