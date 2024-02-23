using System;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPdfExample.Styles;

namespace QuestPdfExample.Components
{
    public class TextComponent(string text) : IComponent
    {

        public void Compose(IContainer container)
        {
            container.Column(column => {
                column.Item().Text(text).Style(DocumentStyles.Normal);
            });
            
        }
    }
}
