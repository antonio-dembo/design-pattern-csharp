using System;

namespace DesignPattern.Builder
{
    static class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "world");
            Console.WriteLine(builder);
;        }
    }
}
