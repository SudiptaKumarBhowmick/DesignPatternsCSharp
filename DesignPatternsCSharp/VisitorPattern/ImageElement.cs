namespace DesignPatternsCSharp.VisitorPattern
{
    // CONCRETE ELEMENTS
    public class ImageElement : IDocumentElement
    {
        public string ImagePath = "/images/photo.png";
        public void Accept(IDocumentVisitor visitor) => visitor.Visit(this);
    }
}
