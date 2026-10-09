using FurnitureStore.Application.Abstractions;

namespace FurnitureStore.Services;

public class MessageService : IMessageService
{
    public void SendMessage(string message)
    {
        MessageBox.Show(message);
    }
}