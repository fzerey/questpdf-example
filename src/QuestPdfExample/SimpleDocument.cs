using System.Security.Cryptography.X509Certificates;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPdfExample.Components;
using QuestPdfExample.Constants;
namespace QuestPdfExample
{
    public class SimpleDocument(byte[] image) : IDocument
    {
        public void Compose(IDocumentContainer container)
        {
            Document.Create(container => {
                container
                    .Page(page => {
                        page.Size(PageSizes.A4);
                        page.MarginTop(50);
                        page.MarginLeft(36);
                        page.MarginRight(36);
                        page.MarginBottom(20);

                        page.Header().PaddingTop(20).PaddingLeft(20).Component(new HeaderComponent(DocumentConstants.TITLE));
                        page.Content().Column(column => 
                        {
                            column.Item().PaddingTop(20).PaddingLeft(20).Component(new TextComponent(DocumentConstants.LOREM_IPSUM_PARAGRAPH));
                            column.Item().PaddingTop(20).PaddingLeft(20).Component(new TableComponent());
                            column.Item().PaddingTop(20).PaddingLeft(20).Component(new ImageComponent(image, 256, 256));
                        });
                        page.Footer().Component(new FooterComponent(DocumentConstants.FOOTER_TEXT));
                    });
            }).ShowInPreviewer();
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
  
    }
}
