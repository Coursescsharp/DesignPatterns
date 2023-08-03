using DesignPatterns.Builder;
using System.Text;

var hello = "Hello";
var sb = new StringBuilder();

sb.Append("<p>");
sb.Append(hello);
sb.Append("</p>");

Console.WriteLine(sb);

sb.Clear();
sb.Append("<ul>");

var words = new[] { "hello", "world" };

foreach (var word in words)
{
    sb.AppendFormat("<li>{0}</li>", word);
}

sb.Append("</ul>");

Console.WriteLine(sb);

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "hello").AddChild("li", "world");

Console.WriteLine(builder.ToString());