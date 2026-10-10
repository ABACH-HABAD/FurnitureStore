using System.ComponentModel;
using FurnitureStore.Application.Views;
using FurnitureStore.Application.Views.Common;

namespace FurnitureStore.Controls.Gdi.Common;

public abstract class BaseGraphControl : Control, IDisposable, IGraphView
{
    protected const double ErrorCorrection = 1e-9;

    protected static readonly Color _gridColor = Color.FromArgb(210, 210, 235);
    protected static readonly Color _axesColor = Color.FromArgb(40, 40, 40);
    protected static readonly Color _graphColor = Color.FromArgb(200, 150, 75);
    protected static readonly Color _figureColor = Color.FromArgb(75, 100, 175);

    protected readonly Pen _gridPen = new(_gridColor, 3f);
    protected readonly Pen _axesPen = new(_axesColor, 4f);
    protected readonly Pen _dataGraphPen = new(_graphColor, 4f);
    protected readonly Brush _textBrush = new SolidBrush(_axesColor);
    protected readonly Brush _figureBrush = new SolidBrush(_figureColor);

    protected int _notchLength = 6;
    protected int _indentationFromText = 8;

    protected GraphView _graphView;

    protected float _plotLeft = 60;
    protected float _plotTop = 10;
    protected float _plotRight = 20;
    protected float _plotBottom = 40;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GraphView GraphView
    {
        get => _graphView;
        set
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(value.MinX, value.MaxX);
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(value.MinY, value.MaxY);

            _graphView = value;
            Invalidate();
        }
    }

    [DefaultValue(60)]
    public float PlotLeft
    {
        get => _plotLeft;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
            _plotLeft = value;
        }
    }

    [DefaultValue(10)]
    public float PlotTop
    {
        get => _plotTop;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
            _plotTop = value;
        }
    }

    [DefaultValue(20)]
    public float PlotRight
    {
        get => _plotRight;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
            _plotRight = value;
        }
    }

    [DefaultValue(40)]
    public float PlotBottom
    {
        get => _plotBottom;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
            _plotBottom = value;
        }
    }

    protected float PlotWidth => Width - PlotLeft - PlotRight;
    protected float PlotHeight => Height - PlotTop - PlotBottom;

    public BaseGraphControl()
    {
        SetStyle
            (
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw,
                true
            );

        _graphView = new GraphView()
        {
            MaxX = 100,
            MaxY = 100,
            MinX = -100,
            MinY = -100,
            TargetHorizontalLines = 8,
            TargetVerticalLines = 10,
        };

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        graphics.Clear(Color.White);

        DrawGrid(graphics);
        DrawAxes(graphics);
        DrawDataGraph(graphics);
    }

    protected float PixelX(double x) => PlotLeft + (float)((x - GraphView.MinX) / (GraphView.MaxX - GraphView.MinX) * PlotWidth);
    protected float PixelY(double y) => (PlotTop + PlotHeight) - (float)((y - GraphView.MinY) / (GraphView.MaxY - GraphView.MinY) * PlotHeight);

    protected PointF DataToScreen(double x, double y) => new(PixelX(x), PixelY(y));
    protected PointF DataToScreen(PointF point) => DataToScreen(point.X, point.Y);

    protected static double SelectStep(double min, double max, int count) => Math.Ceiling(max - min) / count;
    protected static double StartPoint(double minValue, double stepSize) => Math.Ceiling(minValue / stepSize) * stepSize;

    protected abstract void DrawGrid(Graphics graphics);
    protected abstract void DrawAxes(Graphics graphics);
    protected abstract void DrawDataGraph(Graphics graphics);

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _gridPen.Dispose();
            _axesPen.Dispose();
            _dataGraphPen.Dispose();
            _textBrush.Dispose();
            _figureBrush.Dispose();
        }
        base.Dispose(disposing);
    }
}