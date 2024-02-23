
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace QuestPdfExample.Components
{
    public class ImageComponent(byte[] image, uint width, uint height) : IComponent
    {
        public void Compose(IContainer container)
        {
            container.Width(width).Height(height).Image(image);
        }
    }
}
