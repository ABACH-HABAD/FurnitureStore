using System.ComponentModel;

namespace FurnitureStore.Controls.Gdi;

internal class PriceHistoryGraphControl : Control
{
    private const int TargetVerticalLines = 10;
    private const int TargetHorizontalLines = 8;
    private const double ErrorCorrection = 1e-9;

    private static readonly Color GridColor = Color.FromArgb(210, 210, 235);

    private double _minX = 0;
    private double _maxX = 100;
    private double _minY = -50;
    private double _maxY = 200;

    private float _plotLeft = 10;
    private float _plotTop = 10;
    private float _plotRight = 20;
    private float _plotBottom = 20;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double MinX
    {
        get => _minX;
        set
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(value, _maxX);
            _minX = value;
            Invalidate();
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double MaxX
    {
        get => _maxX;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(value, _minX);
            _maxX = value;
            Invalidate();
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double MinY
    {
        get => _minY;
        set
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(value, _maxY);
            _minY = value;
            Invalidate();
        }
    }
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public double MaxY
    {
        get => _maxY;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(value, _minY);
            _maxY = value;
            Invalidate();
        }
    }

    [DefaultValue(10)]
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

    [DefaultValue(20)]
    public float PlotBottom
    {
        get => _plotBottom;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
            _plotBottom = value;
        }
    }

    private float PlotWidth => Width - PlotLeft - PlotRight;
    private float PlotHeight => Height - PlotTop - PlotBottom;

    private float PlotRightEdge => PlotLeft + PlotWidth;
    private float PlotBottomEdge => PlotTop + PlotHeight;

    public PriceHistoryGraphControl()
    {
        SetStyle
            (
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw,
                true
            );
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        graphics.Clear(Color.White);

        PaintRowsAndCoumns(graphics);
    }

    private float PixelX(double x) => PlotLeft + (float)((x - MinX) / (MaxX - MinX) * PlotWidth);
    private float PixelY(double y) => PlotBottom + (float)((y - MinY) / (MaxY - MinY) * PlotHeight);

    private PointF DataToScreen(double x, double y) => new(PixelX(x), PixelY(y));

    private static double SelectStep(double min, double max, int count) => Math.Ceiling(max - min) / count;

    private static double StartPoint(double minValue, double stepSize) => (minValue / stepSize) * stepSize;
    private void PaintRowsAndCoumns(Graphics graphics)
    {
        using Pen gridPen = new(GridColor, 3f);

        //координаты границ рисования
        float left = PlotLeft;
        float top = PlotTop;
        float right = Width - left;
        float bottom = Height - top;

        double stepX = SelectStep(MinX, MaxX, TargetVerticalLines);
        double stepY = SelectStep(MinY, MaxY, TargetHorizontalLines);

        for (double x = StartPoint(MinX, stepX); x <= MaxX + ErrorCorrection; x += stepX)
        {
            float px = PixelX(x);
            graphics.DrawLine(gridPen, new PointF(px, top), new PointF(px, bottom));
        }

        for (double y = StartPoint(MinY, stepY); y <= MaxY + ErrorCorrection; y += stepY)
        {
            float py = PixelY(y);
            graphics.DrawLine(gridPen, new PointF(left, py), new PointF(right, py));
        }
    }
}