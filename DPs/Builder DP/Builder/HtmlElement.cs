using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Builder
{
    internal class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2;
        public HtmlElement()
        {
            
        }
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }
        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indent * indentSize);
            sb.AppendLine($"{i}<{Name}>");
            if(!string.IsNullOrEmpty(Text))
            {
                sb.Append(new string(' ', (indent + 1) * indentSize));
                sb.AppendLine($"{i}{Text}");
            }
            foreach(HtmlElement e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }
            sb.AppendLine($"{i}</{Name}>");

            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
