namespace DesignPatternsCSharp.VisitorPattern
{
    public class VisitorPatternConsumer
    {
        public void ConsumeVisitorPattern()
        {
            var elements = new List<IDocumentElement>
            {
                new TextElement(),
                new ImageElement()
            };

            var pdfExporter = new PdfExporter();
            foreach (var e in elements)
                e.Accept(pdfExporter);

            var counter = new WordCounter();
            foreach (var e in elements)
                e.Accept(counter);

            Console.WriteLine($"Total Words: {counter.WordCount}");
        }
    }
}
