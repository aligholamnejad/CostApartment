using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostApartment.Term
{
    public partial class TermList : Form
    {
        public TermList()
        {
            InitializeComponent();
        }
        Model.CostApartmentEntities db = new Model.CostApartmentEntities();

        private void TermList_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = db.Terms.Select(i => new { i.Id, i.NameTerm}).ToList();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new AddTerm().ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (new AddTerm() { currencyRowId = id }.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("هیچ رکوردی یافت نشد");
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var apartmentUnit = db.Terms.First(x => x.Id == id);
                if (
                    MessageBox.Show("آیا از حذف " + dataGridView1.CurrentRow.Cells[1].Value + " مطمئن هستید ؟", "هشدار",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Terms.Remove(apartmentUnit);
                    db.SaveChanges();
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("هیچ رکوردی یافت نشد");
            }
        }
    }
}
