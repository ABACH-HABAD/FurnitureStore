using System.Drawing;

namespace FurnitureStore.Application.Views.Common;

public sealed class GraphView
{
    private const int DefaultTargetVerticalLines = 10;
    private const int DefaultTargetHorizontalLines = 8;

    public int TargetVerticalLines { get; init; } = DefaultTargetVerticalLines;
    public int TargetHorizontalLines { get; init; } = DefaultTargetHorizontalLines;

    public double MinX { get; init; }
    public double MaxX { get; init; }
    public double MinY { get; init; }
    public double MaxY { get; init; }

    public List<PointF> DataPoints { get; init; } = [];
    public List<string> HorizontalAxisFormat { get; init; } = new List<string>(DefaultTargetVerticalLines);
    public List<string> VerticalAxisFormat { get; init; } = new List<string>(DefaultTargetHorizontalLines);
}