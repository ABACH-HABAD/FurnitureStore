using FurnitureStore.Application.Views;
using FurnitureStore.Application.Presenters.Common;
using FurnitureStore.Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using FurnitureStore.Application.Abstractions.Data;
using FurnitureStore.Application.Services.Common;
using FurnitureStore.Domain.Models;

namespace FurnitureStore.Application.Presenters;

public class FurnitureEditPresenter : BasePresenter<IFurnitureEditView>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMessageService _messageService;

    public FurnitureEditPresenter(IServiceProvider serviceProvider, IMessageService messageService, IFurnitureEditView view) : base(view)
    {
        _serviceProvider = serviceProvider;
        _messageService = messageService;

        _view.AcceptClicked += OnAcceptClick;
        _view.DenyClicked += OnDenyClick;
    }

    private async void OnAcceptClick(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_view.FurnitureName))
        {
            _messageService.SendMessage("Имя не может быть пустым");
            return;
        }

        if (string.IsNullOrWhiteSpace(_view.FurnitureDescription))
        {
            _messageService.SendMessage("Описание не может быть пустым");
            return;
        }

        if (double.TryParse(_view.FurniturePrice, out double price) && price > 0)
        {
            _messageService.SendMessage("Некорректная цена");
            return;
        }

        using IServiceScope scope = _serviceProvider.CreateScope();
        IFurnitureService furnitureService = scope.ServiceProvider.GetRequiredService<IFurnitureService>();

        FurnitureModel furnitureModel = new()
        {
            Name = _view.FurnitureName,
            Description = _view.FurnitureDescription,
            Price = price
        };

        Result result = await furnitureService.AddAsync(furnitureModel);
        if (!result.IsSuccess) _messageService.SendMessage(result.Message ?? "ОШИБКА!");
        else _view.CanClose = true;
    }

    private void OnDenyClick(object? sender, EventArgs e)
    {
        _view.CanClose = true;
    }

    protected override void OnDispose()
    {
        _view.AcceptClicked -= OnAcceptClick;
        _view.DenyClicked -= OnDenyClick;
    }
}