using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataGrid.CellRenderers.Remove("Text");
            dataGrid.CellRenderers.Add("Text", new CustomRenderer());
        }
        public class CustomRenderer : DataGridCellRenderer<View, View>
        {
            protected override void OnSetCellStyle(DataColumnBase dataColumn)
            {
                base.OnSetCellStyle(dataColumn);

                if (dataColumn != null)
                {
                    var gridStyle = this.DataGrid?.DefaultStyle;
                    DataGridCell gridCell = dataColumn.ColumnElement;
                    var mappingName = dataColumn.DataGridColumn.MappingName;

                    if ((mappingName == "Name"))
                    {
                        var label = gridCell.Children[0] as Label;
                        if (label != null && gridCell != null)
                        {
                            label.TextColor = Colors.White;
                            gridCell.BackgroundColor = Colors.Orange;
                        }
                    }

                    gridStyle = null;
                    mappingName = null;
                    gridCell = null;
                }
            }

        }
    }
}
