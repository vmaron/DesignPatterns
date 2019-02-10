using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite.GeometricShapes.Impl
{
    public class GraphicObject
    {
        private readonly Lazy<List<GraphicObject>> _children = new Lazy<List<GraphicObject>>();
        public string Color;
        public virtual string Name { get; set; } = "Group";
        public List<GraphicObject> Children => _children.Value;

        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
                .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color} ")
                .AppendLine($"{Name}");

            foreach (var child in Children)
                child.Print(sb, depth + 1);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }
    }
}