namespace DesignPatternsCSharp.VisitorPattern
{
    public class WordCounter : IDocumentVisitor
    {
        public int WordCount = 0;

        public void Visit(TextElement text)
        {
            WordCount += text.Text.Split(' ').Length;
        }

        public void Visit(ImageElement image) { /* Do nothing */ }
    }
}
