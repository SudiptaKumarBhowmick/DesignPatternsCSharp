namespace DesignPatternsCSharp.VisitorPattern
{
    public class TextElement : IDocumentElement
    {
        public string Text = "Hello Visitor Pattern!";
        public void Accept(IDocumentVisitor visitor) => visitor.Visit(this);
    }
}
