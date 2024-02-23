using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
namespace QuestPdfExample.Styles
{
    public static class DocumentStyles
    {
        public static TextStyle Normal => new TextStyle().FontSize(12).FontColor("#000000");
        public static TextStyle Header => new TextStyle().FontSize(18).Bold().FontColor("#000000");
        public static TextStyle Footer => new TextStyle().FontSize(12).FontColor("#000000");
        public static TextStyle TableField => new TextStyle().FontSize(10).Bold().FontColor("#000000");

        public static TextStyle TableValue => new TextStyle().FontSize(10).FontColor("#000000");
    }
}