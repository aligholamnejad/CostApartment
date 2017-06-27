using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostApartment.ApartmentUnit
{
    public partial class ApartmentUnitList : Form
    {

        public ApartmentUnitList()
        {
            InitializeComponent();
        }
        Model.CostApartmentEntities db = new Model.CostApartmentEntities();


        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new AddApartmentUnit().ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = db.ApartmentUnits.Select(i => new { i.Id, i.Owner, i.NameUnit, i.Count, i.Meter }).ToList();
        }

        private void ApartmentUnitList_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (new AddApartmentUnit() { currencyRowId = id }.ShowDialog() == DialogResult.OK)
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
                var apartmentUnit = db.ApartmentUnits.First(x => x.Id == id);
                if (
                    MessageBox.Show("آیا از حذف " + dataGridView1.CurrentRow.Cells[1].Value + " مطمئن هستید ؟", "هشدار",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ApartmentUnits.Remove(apartmentUnit);
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
