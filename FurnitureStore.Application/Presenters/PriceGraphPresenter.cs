using System.Drawing;
using FurnitureStore.Domain.Models;
using FurnitureStore.Application.Views;
using FurnitureStore.Application.Views.Common;
using FurnitureStore.Application.Presenters.Common;

namespace FurnitureStore.Application.Presenters;

public class PriceGraphPresenter(IPriceGraphView view) : BasePresenter<IPriceGraphView>(view), IDataSetable, IDataSetable<List<PriceHistoryModel>>
{
    private static readonly double[] _timeSteps =
    [
        1d / (24 * 60),
            5d / (24 * 60),
            30d / (24 * 60),
            1d / 24,
            6d / 24,
            12d / 24,
            1d,
            7d,
            30d,
            90d,
            365d
    ];

    private static double SelectStep(double min, double max, int count) => Math.Ceiling(max - min) / count;

    private static double SelectTimeStep(double min, double max, int count)
    {
        double raw = SelectStep(min, max, count);
        foreach (double step in _timeSteps)
        {
            if (raw <= step) return step;
        }

        return _timeSteps[^1];
    }

    private static string DateFormat(double oaDate, double dateStep)
    {
        DateTime dateTime = DateTime.FromOADate(oaDate);

        if (dateStep >= 365) return dateTime.ToString("yyyy");
        if (dateStep >= 30) return dateTime.ToString("MMM yyyy");
        if (dateStep >= 1) return dateTime.ToString("dd.MM");
        if (dateStep >= 1d / 24) return dateTime.ToString("dd.MM HH:mm");
        return dateTime.ToString("HH:mm");
    }

    public void SetData(object data)
    {
        if (data is List<PriceHistoryModel> priceHistories) SetData(priceHistories);
        else throw new ArgumentException("Data is no a List<PriceHistoryModel>", nameof(data));
    }

    public void SetData(List<PriceHistoryModel> priceHistories)
    {
        double minY = priceHistories.Min(ph => ph.ChangedPrice);
        double maxY = priceHistories.Max(ph => ph.ChangedPrice);

        double minX = priceHistories[0].Date.ToOADate();
        double maxX = priceHistories[^1].Date.ToOADate();

        double marginY = 0;
        double marginX = 0;

        GraphView graphView = new()
        {
            MinX = minX - marginX,
            MaxX = maxX + marginX,
            MinY = minY - marginY,
            MaxY = maxY + marginY,
            TargetVerticalLines = 10,
            TargetHorizontalLines = 8,
            VerticalAxisFormat = [],
            HorizontalAxisFormat = []
        };

        foreach (PriceHistoryModel priceHistory in priceHistories)
        {
            double x = priceHistory.Date.ToOADate();
            double y = priceHistory.ChangedPrice;

            if (graphView.DataPoints.Count > 0) graphView.DataPoints.Add(new PointF((float)x, graphView.DataPoints[^1].Y));

            graphView.DataPoints.Add(new PointF((float)x, (float)y));
        }

        for (int i = 0; i < graphView.TargetVerticalLines + 1; i++)
        {
            graphView.VerticalAxisFormat.Add(DateFormat(((maxX - minX) / graphView.TargetVerticalLines) * i + minX, SelectTimeStep(minX, maxX, graphView.TargetVerticalLines)));
        }

        for (int i = 0; i < graphView.TargetHorizontalLines + 1; i++)
        {
            graphView.HorizontalAxisFormat.Add($"{(SelectStep(minY, maxY, graphView.TargetHorizontalLines) * i + minY):F2}₽");
        }

        _view.GraphView = graphView;
    }

    protected override void OnDispose()
    {

    }
}