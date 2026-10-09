using FurnitureStore.Application.Abstractions;
using FurnitureStore.Application.Presenters.Common;
using FurnitureStore.Application.Views;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureStore.Application.Presenters;

public class MainPresenter : BasePresenter<IMainView>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMessageService _messageService;

    public MainPresenter(IServiceProvider serviceProvider, IMainView mainView, IMessageService messageService) : base(mainView)
    {
        _serviceProvider = serviceProvider;
        _messageService = messageService;
        _view.ShowSalesChartClicked += OnShowSalesChartClick;
    }

    public async void OnShowSalesChartClick(object? sender, EventArgs e)
    {
        PriceGraphPresenter presenter = _serviceProvider.GetRequiredService<PriceGraphPresenter>();
        presenter.Run();
    }

    protected override void OnDispose()
    {
        _view.ShowSalesChartClicked -= OnShowSalesChartClick;
    }
}