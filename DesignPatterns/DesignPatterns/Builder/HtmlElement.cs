using System.Text;

namespace DesignPatterns.Builder;

public class HtmlElement
{
    private const int indentSize = 2;
    public string? Name { get; set; }
    public string? Text { get; set; }
    public IList<HtmlElement>? Elements { get; set; }

    public HtmlElement()
    {
        Elements = new List<HtmlElement>();
    }

    public HtmlElement(string name, string text) : this()
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
    }

    private string ToStringImpl(int indent)
    {
        var sb = new StringBuilder();

        // A single space will be repeated a certain number of times        
        var i = new string(' ', indentSize * indent);

        sb.AppendLine($"{i}<{Name}>");

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', indentSize * (indent + 1)));
            sb.AppendLine(Text);
        }

        foreach (var item in Elements)
        {
            sb.Append(item.ToStringImpl(indent + 1));
        }

        sb.AppendLine($"{i}</{Name}>");

        return sb.ToString();
    }
    public override string ToString()
    {
        return ToStringImpl(0);
    }
}
