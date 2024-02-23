using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPdfExample.Styles;

namespace QuestPdfExample.Components
{
    public class TableComponent : IComponent
    {
        public void Compose(IContainer container)
        {
            container.Column(column => {
                column.Item().Border(1).Table(table => {
                    table.ColumnsDefinition(columns => {
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });
                    table.Cell().Row(1).Column(1).Border(1).PaddingLeft(6).Text("Column 1").Style(DocumentStyles.TableField);
                    table.Cell().Row(1).Column(2).Border(1).PaddingLeft(6).Text("Column 2").Style(DocumentStyles.TableField);
                    table.Cell().Row(1).Column(3).Border(1).PaddingLeft(6).Text("Column 3").Style(DocumentStyles.TableField);
                    table.Cell().Row(1).Column(4).Border(1).PaddingLeft(6).Text("Column 4").Style(DocumentStyles.TableField);

                    for(uint i = 0; i < 10; i++)
                    {
                        table.Cell().Row(i + 2).Column(1).Border(1).PaddingLeft(6).Text($"Row {i + 1} Column 1").Style(DocumentStyles.TableValue);
                        table.Cell().Row(i + 2).Column(2).Border(1).PaddingLeft(6).Text($"Row {i + 1} Column 2").Style(DocumentStyles.TableValue);
                        table.Cell().Row(i + 2).Column(3).Border(1).PaddingLeft(6).Text($"Row {i + 1} Column 3").Style(DocumentStyles.TableValue);
                        table.Cell().Row(i + 2).Column(4).Border(1).PaddingLeft(6).Text($"Row {i + 1} Column 4").Style(DocumentStyles.TableValue);
                    }

                });
            });
        }
    }
}
