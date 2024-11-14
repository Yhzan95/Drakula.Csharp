using System;
using System.Windows.Forms;

namespace Drakula_Csharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DrakulaTheme.ApplyDrakula(this); // Apply Drakula
            DrakulaTheme.ApplyDrakulaDataGridView(dataGridView1); // Apply Drakula datagrid (if used)
            exDataGridView(); // Datagrid Exemple
        }

        // Datagrid Exemple
        private void exDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Role";
            dataGridView1.Rows.Add("1", "John Doe", "Developer");
            dataGridView1.Rows.Add("2", "Jane Smith", "Designer");
            dataGridView1.Rows.Add("3", "Alice Johnson", "Manager");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
