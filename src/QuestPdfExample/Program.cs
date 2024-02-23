
using QuestPDF.Fluent;
using QuestPdfExample;
var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot/Assets", "image.jpg");
Console.WriteLine(path);
var image = File.ReadAllBytes(path);
var document = new SimpleDocument(image);
document.GeneratePdf("output.pdf");