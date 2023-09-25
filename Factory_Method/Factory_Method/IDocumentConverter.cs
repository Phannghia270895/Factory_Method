using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public interface IDocumentConverter
    {
        string Convert(string content);
        string TargetExtension { get; }
    }

    //Concrete Implementations for the Products
    public class DocxConverter : IDocumentConverter
    {
        public string Convert(string content)
        {
            Console.WriteLine("Converting content to DOCX format...");
            // Logic for DOCX conversion, simplified for this example
            return content + " [Converted to DOCX]";
        }

        public string TargetExtension => ".docx";
    }

    public class PdfConverter : IDocumentConverter
    {
        public string Convert(string content)
        {
            Console.WriteLine("Converting content to PDF format...");
            // Logic for PDF conversion, simplified for this example
            return content + " [Converted to PDF]";
        }

        public string TargetExtension => ".pdf";
    }

    public class TxtConverter : IDocumentConverter
    {
        public string Convert(string content)
        {
            Console.WriteLine("Converting content to TXT format...");
            // Logic for TXT conversion, simplified for this example
            return content + " [Converted to TXT]";
        }

        public string TargetExtension => ".txt";
    }

    //Factory Class to Produce the Products
    public static class DocumentConverterFactory
    {
        public static IDocumentConverter CreateDocumentConverter(string format)
        {
            switch (format.ToLower())
            {
                case "docx":
                    return new DocxConverter();
                case "pdf":
                    return new PdfConverter();
                case "txt":
                    return new TxtConverter();
                default:
                    throw new ArgumentException("Unsupported document format");
            }
        }
    }
}
