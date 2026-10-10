using FurnitureStore.Controls.Gdi.Common;

namespace FurnitureStore.Controls.Gdi;

public class SalesCountsGraphControl : BaseGraphControl, IDisposable
{
    public SalesCountsGraphControl() : base()
    {

    }

    protected override void DrawGrid(Graphics graphics)
    {
        double stepY = SelectStep(GraphView.MinY, GraphView.MaxY, GraphView.TargetHorizontalLines);

        for (double i = GraphView.MinY; i < GraphView.MaxY + ErrorCorrection; i += stepY)
        {
            float py = PixelY(i);
            graphics.DrawLine(_gridPen, new PointF(PlotLeft, py), new PointF(PlotLeft + PlotWidth, py));
        }
    }

    protected override void DrawAxes(Graphics graphics)
    {
        float left = PlotLeft;
        float bottom = PlotTop + PlotHeight;

        graphics.DrawRectangle(_axesPen, new RectangleF(PlotLeft, PlotTop, PlotWidth, PlotHeight));

        double stepX = SelectStep(GraphView.MinX, GraphView.MaxX, GraphView.TargetVerticalLines);
        double stepY = SelectStep(GraphView.MinY, GraphView.MaxY, GraphView.TargetHorizontalLines);

        int i = 0;
        for (double x = StartPoint(GraphView.MinX, stepX); x < GraphView.MaxX + ErrorCorrection; x += stepX)
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
        float bottom = PlotTop + PlotHeight;
        float width = PlotWidth / GraphView.TargetVerticalLines / 2f;

        for (int i = 0; i < GraphView.DataPoints.Count; i++)
        {
            PointF point = DataToScreen(GraphView.DataPoints[i].X, GraphView.DataPoints[i].Y);


            graphics.FillRectangle(_figureBrush, new RectangleF(point.X - width / 2f, point.Y + 2f, width, bottom - point.Y - 4f));
        }
    }
}
