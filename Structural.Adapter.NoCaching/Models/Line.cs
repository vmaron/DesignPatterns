namespace Structural.Adapter.NoCaching.Models
{
    public class Line
    {
        public Point End;
        public Point Start;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}