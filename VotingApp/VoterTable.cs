using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class VoterTable : Form
    {
        private readonly Database _database ;
        public VoterTable(Database database)
        {
            InitializeComponent();
            _database = database;
        }

        private void VoterTable_Load(object sender, EventArgs e)
        {
            foreach (var items in  _database.VoterTable)
            {
                dataGridView1.Rows.Add(items.FirstName + " " + items.LastName, items.Id, items.PollingUnit.Unit_No, items.DateOfBirth, items.Gender.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void View_List_Label_Click(object sender, EventArgs e)
        {

        }
        private void Back_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
