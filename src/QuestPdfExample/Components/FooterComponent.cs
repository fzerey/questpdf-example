
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPdfExample.Styles;

namespace QuestPdfExample.Components
{
    public class FooterComponent(string text) : IComponent
    {
        public void Compose(IContainer container)
        {
            container.Column(column => {
                column.Item().AlignLeft().Text(text).Style(DocumentStyles.Footer);
                column.Item().AlignRight().Text(x => {
                    x.CurrentPageNumber();
                });
            });

        }
    }
}
