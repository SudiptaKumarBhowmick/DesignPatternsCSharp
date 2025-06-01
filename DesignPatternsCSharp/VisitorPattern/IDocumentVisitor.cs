namespace DesignPatternsCSharp.VisitorPattern
{
    // VISITOR INTERFACE
    public interface IDocumentVisitor
    {
        void Visit(TextElement text);
        void Visit(ImageElement image);
    }
}
