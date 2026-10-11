using FurnitureStore.Controls.Gdi.Common;

namespace FurnitureStore.Controls.Gdi;

public class PriceHistoryGraphControl : BaseGraphControl, IDisposable
{
    public PriceHistoryGraphControl() : base()
    {

    }

    protected override void DrawGrid(Graphics graphics)
    {
        //координаты границ рисования
        float left = PlotLeft;
        float top = PlotTop;
        float right = PlotLeft + PlotWidth;
        float bottom = PlotTop + PlotHeight;

        double stepX = SelectStep(GraphView.MinX, GraphView.MaxX, GraphView.TargetVerticalLines);
        double stepY = SelectStep(GraphView.MinY, GraphView.MaxY, GraphView.TargetHorizontalLines);

        for (double x = GraphView.MinX; x < GraphView.MaxX + ErrorCorrection; x += stepX)
        {
            float px = PixelX(x);
            graphics.DrawLine(_gridPen, new PointF(px, top), new PointF(px, bottom));
        }

        for (double y = GraphView.MinY; y < GraphView.MaxY + ErrorCorrection; y += stepY)
        {
            float py = PixelY(y);
            graphics.DrawLine(_gridPen, new PointF(left, py), new PointF(right, py));
        }
    }

    protected override void DrawAxes(Graphics graphics)
    {
        //координаты границ рисования
        float left = PlotLeft;
        float top = PlotTop;
        //float right = PlotLeft + PlotWidth;
        float bottom = PlotTop + PlotHeight;

        graphics.DrawRectangle(_axesPen, new RectangleF(left, top, PlotWidth, PlotHeight));

        double stepX = SelectStep(GraphView.MinX, GraphView.MaxX, GraphView.TargetVerticalLines);
        double stepY = SelectStep(GraphView.MinY, GraphView.MaxY, GraphView.TargetHorizontalLines);

        int i = 0;
        for (double x = GraphView.MinX; x < GraphView.MaxX + ErrorCorrection; x += stepX)
        {
            float px = PixelX(x);
            graphics.DrawLine(_axesPen, new PointF(px, bottom), new PointF(px, bottom + _notchLength));

            string text = GraphView.VerticalAxisFormat.Count > i ? GraphView.VerticalAxisFormat[i] : "err";
            SizeF size = graphics.MeasureString(text, Font);
            graphics.DrawString(text, Font, _textBrush, px - size.Width / 2, bottom + _indentationFromText);

            i++;
        }

        i = 0;
        for (double y = GraphView.MinY; y < GraphView.MaxY + ErrorCorrection; y += stepY)
        {
            float py = PixelY(y);
            graphics.DrawLine(_axesPen, new PointF(left, py), new PointF(left - _notchLength, py));

            string text = GraphView.HorizontalAxisFormat.Count > i ? GraphView.HorizontalAxisFormat[i] : "err";
            SizeF size = graphics.MeasureString(text, Font);
            graphics.DrawString(text, Font, _textBrush, left - size.Width - _indentationFromText, py - size.Height / 2);

            i++;
        }
    }

    protected override void DrawDataGraph(Graphics graphics)
    {
        if (GraphView.DataPoints.Count < 2) return;

        PointF[] points = new PointF[GraphView.DataPoints.Count];
        for (int i = 0; i < GraphView.DataPoints.Count; i++)
        {
            points[i] = DataToScreen(GraphView.DataPoints[i]);
        }
        graphics.DrawLines(_dataGraphPen, points);
    }
}