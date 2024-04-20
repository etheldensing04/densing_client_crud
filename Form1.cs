using complete_csharp_crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace densing_client_crud
{
    public partial class Form1 : Form
    {
        private DatabaseOperation operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            operation.addClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operation = new DatabaseOperation(clientBindingSource);
            clientBindingSource.DataSource = operation._con.Clients.ToList();
        }
        private int getSelectedId;
        private void updatebutton_Click(object sender, EventArgs e)
        {
            operation.updateClients(getSelectedId);
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Imohang e delete ang client ID? {getSelectedId}", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                operation.deleteClients(getSelectedId);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            getSelectedId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation.searchClient(searchbar.Text.Trim());
        }
    }
}

