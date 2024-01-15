using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Builder
{
    internal class HtmlBuilder
    {
        HtmlElement Root = new HtmlElement();
        public HtmlBuilder(string RootName)
        {
            Root.Name = RootName;
        }
        public HtmlBuilder AddChild(HtmlElement child)
        {
            Root.Elements.Add(child);
            return this;
        }
        public override string ToString()
        {
            return Root.ToString();
        }
        public void Clear()
        {
            string name = Root.Name;
            Root = new HtmlElement();
            Root.Name = name;
        }
    }
}
