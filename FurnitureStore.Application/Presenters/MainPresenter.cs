using FurnitureStore.Application.Abstractions;
using FurnitureStore.Application.Abstractions.Data;
using FurnitureStore.Application.Presenters.Common;
using FurnitureStore.Application.Services.Common;
using FurnitureStore.Application.Views;
using FurnitureStore.Domain.Models;
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
        _view.ShowOneMoreShitClicked += OnShowSalesChartClick2;

        _view.FurnitureList.CreateButtonClick += OnCreateNewFurnitureClicked;
    }

    public override async void Run()
    {
        base.Run();

        List<FurnitureModel> furnitures = [];

        using (IServiceScope scope = _serviceProvider.CreateScope())
        {
            IFurnitureService furnitureService = scope.ServiceProvider.GetRequiredService<IFurnitureService>();
            Result<List<FurnitureModel>> result = await furnitureService.GetAllAsync();
            if (result.IsSuccess) furnitures = result.Data ?? [];
            else _messageService.SendMessage(result?.Message ?? "ОШИБКА!");
        }

        furnitures.ForEach(_view.FurnitureList.AddToList);
    }

    public async void OnShowSalesChartClick(object? sender, EventArgs e)
    {
        PriceGraphPresenter presenter = _serviceProvider.GetRequiredService<PriceGraphPresenter>();
        presenter.Run();


        List<PriceHistoryModel> ph =
            [
                new PriceHistoryModel() {ChangedPrice = 700, Date = new DateTime(2001, 10, 3)},
                new PriceHistoryModel() {ChangedPrice = 630, Date = new DateTime(2002, 2, 21)},
                new PriceHistoryModel() {ChangedPrice = 894, Date = new DateTime(2003, 5, 23)},
                new PriceHistoryModel() {ChangedPrice = 676, Date = new DateTime(2002, 10, 1)},
                new PriceHistoryModel() {ChangedPrice = 1154, Date = new DateTime(2003, 10, 1)},
                new PriceHistoryModel() {ChangedPrice = 766, Date = new DateTime(2002, 4, 1)},
            ];

        presenter.SetData(ph);
    }

    public async void OnShowSalesChartClick2(object? sender, EventArgs e)
    {
        SalesChartGraphRresenter presenter = _serviceProvider.GetRequiredService<SalesChartGraphRresenter>();
        presenter.Run();

        List<(string name, int count)> values =
            [
                ("диван", 10),
                ("шкаф", 15),
                ("стол", 8),
                ("кровать", 12),
            ];

        presenter.SetData(values);
    }

    public void OnCreateNewFurnitureClicked(object? sender, EventArgs e)
    {
        FurnitureEditPresenter presenter = _serviceProvider.GetRequiredService<FurnitureEditPresenter>();
        presenter.Run();
    }

    protected override void OnDispose()
    {
        _view.ShowSalesChartClicked -= OnShowSalesChartClick;
        _view.ShowOneMoreShitClicked -= OnShowSalesChartClick2;

        _view.FurnitureList.ClearList();
        _view.FurnitureList.CreateButtonClick -= OnCreateNewFurnitureClicked;
    }
}