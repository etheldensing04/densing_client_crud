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

namespace densing_client_crud.Entities
{
    public partial class UpdateClient : Form
    {
        private readonly DatabaseOperation operation = new DatabaseOperation();
        private readonly int _id;
        public UpdateClient()
        {
            InitializeComponent();
        }
        public UpdateClient(int id) : this()
        {
            this._id = id;
        }
        private void UpdateClient_Load(object sender, EventArgs e)
        {
            var selectedClient = operation._con.Clients.Where(q => q.Id == _id).FirstOrDefault();

            fname_val.Text = selectedClient.Firstname;
            lname_val.Text = selectedClient.Lastname;
            rname_val.Text = selectedClient.Residency;
            date_val.Value = (DateTime)selectedClient.Birthday;
        }
        public string[] GetAddText { get; set; } = new string[3];
        public DateTime dateValue { get; set; }
        private void addbutton_Click(object sender, EventArgs e)
        {
            string fname = fname_val.Text.Trim();
            string lname = lname_val.Text.Trim();
            string residency = rname_val.Text.Trim();
            DateTime date = date_val.Value;

            if (!string.IsNullOrWhiteSpace(fname) &&
                !string.IsNullOrWhiteSpace(lname) &&
                !string.IsNullOrWhiteSpace(residency))
            {
                GetAddText[0] = fname;
                GetAddText[1] = lname;
                GetAddText[2] = residency;
                dateValue = date;

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields with valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
