using FurnitureStore.Application.Abstractions;
using FurnitureStore.Application.Abstractions.Data;
using FurnitureStore.Application.Presenters.Common;
using FurnitureStore.Application.Services.Common;
using FurnitureStore.Application.Views.Forms;
using FurnitureStore.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FurnitureStore.Application.Presenters;

public class MainPresenter : BasePresenter<IMainView>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IMessageService _messageService;

    public MainPresenter(IServiceProvider serviceProvider, IMainView mainView, IMessageService messageService) : base(mainView)
    {
        _serviceProvider = serviceProvider;
        _messageService = messageService;

        _view.Exiting += OnExit;
        _view.ShowingMainMenu += OnShowingMainMenu;
        _view.ShowingFurnitureList += OnShowingFurnitureList;
        _view.ShowingSalesChartClicked += OnShowingSalesChartClick;

        _view.MainMenuView.ExitClick += OnExit;
        _view.MainMenuView.ShowProductListClick += OnShowingFurnitureList;
        _view.MainMenuView.GenerateSalesReportClick += OnShowingSalesChartClick;

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

        furnitures.ForEach(_view.FurnitureListView.AddToList);
    }

    public void OnShowingFurnitureList(object? sender, EventArgs e)
    {
        _view.ShowFurnitureList();
    }

    public void OnShowingMainMenu(object? sender, EventArgs e)
    {
        _view.ShowMainMenu();
    }

    public async void OnShowingSalesChartClick(object? sender, EventArgs e)
    {
        using IServiceScope scope = _serviceProvider.CreateScope();

        SalesChartGraphRresenter presenter = scope.ServiceProvider.GetRequiredService<SalesChartGraphRresenter>();

        ISaleService saleService = scope.ServiceProvider.GetRequiredService<ISaleService>();
        var result = await saleService.GetSalesCountByFurnitureModelsAsync();

        presenter.Run();

        if (result.IsSuccess)
        {
            presenter.SetData(result.Data ?? []);
        }
    }

    public async void OnShowSalesChartClick2(object? sender, EventArgs e)
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


    public void OnCreateNewFurnitureClicked(object? sender, EventArgs e)
    {
        FurnitureEditPresenter presenter = _serviceProvider.GetRequiredService<FurnitureEditPresenter>();
        presenter.Run();
    }

    public void OnExit(object? sender, EventArgs e)
    {
        Dispose(true);
        _view.Close();
    }

    protected override void OnDispose()
    {
        _view.Exiting -= OnExit;
        _view.ShowingMainMenu -= OnShowingMainMenu;
        _view.ShowingFurnitureList -= OnShowingFurnitureList;
        _view.ShowingSalesChartClicked -= OnShowingSalesChartClick;

        _view.MainMenuView.ExitClick -= OnExit;
        _view.MainMenuView.ShowProductListClick -= OnShowingFurnitureList;

        _view.FurnitureListView.ClearList();
        _view.FurnitureListView.CreateButtonClick -= OnCreateNewFurnitureClicked;
        _view.MainMenuView.GenerateSalesReportClick -= OnShowingSalesChartClick;
    }
}