namespace DesignPatternsCSharp.VisitorPattern
{
    // ELEMENT INTERFACE
    public interface IDocumentElement
    {
        void Accept(IDocumentVisitor visitor);
    }
}
