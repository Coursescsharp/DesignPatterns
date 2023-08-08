using DesignPatterns.Builder;
using DesignPatterns.Models;
using System.Text;

// Builder pattern
/*
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
*/

// Factories pattern

// Factory Method
var point = Point.NewCartesianPoint(1.0, Math.PI / 2);
Console.WriteLine(point);