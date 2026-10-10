using FurnitureStore.Application.Presenters.Common;
using FurnitureStore.Application.Views;
using FurnitureStore.Application.Views.Common;
using FurnitureStore.Domain.Models;
using System.Drawing;

namespace FurnitureStore.Application.Presenters;

public class SalesChartGraphRresenter(ISalesChartGraphView view) : BasePresenter<ISalesChartGraphView>(view), IDataSetable, IDataSetable<List<(string name, int count)>>
{
    public void SetData(object data)
    {
        if (data is List<SaleModel> salemodels) SetData(salemodels);
        else throw new ArgumentException("data is not a List<SaleModel>", nameof(data));

    }

    private static double SelectStep(double min, double max, int count) => Math.Ceiling(max - min) / count;

    public void SetData(List<(string name, int count)> data)
    {
        List<PointF> points = [];

        float max = data.Max(d => d.count) * 1.1f;


        GraphView graphView = new()
        {
            TargetHorizontalLines = 8,
            TargetVerticalLines = data.Count,
            HorizontalAxisFormat = [],
            VerticalAxisFormat = [],
            MaxY = max,
            MinY = 0,
            MinX = -1,
            MaxX = data.Count + 1,
            DataPoints = points,
        };

        for (int i = 0; i < data.Count; i++)
        {
            graphView.VerticalAxisFormat.Add(data[i].name);
            points.Add(new PointF(i * ((data.Count + 2f) / data.Count), data[i].count));
        }

        for (int i = 0; i < graphView.TargetHorizontalLines + 1; i++)
        {
            graphView.HorizontalAxisFormat.Add($"{(SelectStep(graphView.MinY, graphView.MaxY, graphView.TargetHorizontalLines) * i + graphView.MinY):F0}");
        }


        _view.GraphView = graphView;
    }

    protected override void OnDispose()
    {

    }
}