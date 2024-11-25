// See https://aka.ms/new-console-template for more information
using RtfPipe;
using System.Text;

Console.WriteLine("Hello, World!");

var filePath = "files\\unicode.rtf";

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

using (var stream = new StreamReader(filePath))
{
  var settings = new RtfHtmlSettings();
  settings.WithFullDocument();
  var actual = Rtf.ToHtml(stream, settings);
  
  Console.WriteLine(actual);
}
