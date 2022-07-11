namespace DesignPattern.Builder
{
    public class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();
        private string rootName;

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement { name = rootName };
        }
    }
}
