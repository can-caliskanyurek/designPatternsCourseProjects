using PrototypeCodingExercise.Interfaces;

namespace PrototypeCodingExercise.Classes
{
    public class Line : IPrototype<Line>
    {
        public Point Start, End;

        public Line() { }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Line DeepCopy()
        {
            return new Line(Start.DeepCopy(), End.DeepCopy());
        }

        public override string ToString()
        {
            return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}";
        }
    }
}
