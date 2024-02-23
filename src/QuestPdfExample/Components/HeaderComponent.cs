
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPdfExample.Constants;
using QuestPdfExample.Styles;

namespace QuestPdfExample.Components
{
    public class HeaderComponent(string title) : IComponent
    {
        public void Compose(IContainer container)
        {
            container.Column(c => {
                c.Item().AlignLeft().Text(title).Style(DocumentStyles.Header);
            });
        }
    }
}
