namespace DesignPatternsCSharp.VisitorPattern
{
    // CONCRETE VISITOR 1 - EXPORT TO PDF
    public class PdfExporter : IDocumentVisitor
    {
        public void Visit(TextElement text)
        {
            Console.WriteLine($"Exporting text to PDF: {text.Text}");
        }

        public void Visit(ImageElement image)
        {
            Console.WriteLine($"Exporting image to PDF: {image.ImagePath}");
        }
    }
}
