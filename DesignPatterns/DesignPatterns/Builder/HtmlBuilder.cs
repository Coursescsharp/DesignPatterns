namespace DesignPatterns.Builder;

public class HtmlBuilder
{
    private readonly string _rootName;
    HtmlElement root = new HtmlElement();

    public HtmlBuilder(string rootName)
    {
        root.Name = rootName;
        this._rootName = rootName;
    }

    public void AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        root.Elements.Add(e);
    }
}
