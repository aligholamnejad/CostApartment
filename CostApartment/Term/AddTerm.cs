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
    public partial class AddTerm : Form
    {
        public AddTerm()
        {
            InitializeComponent();
        }
        Model.CostApartmentEntities db = new Model.CostApartmentEntities();
        public int currencyRowId = 0;

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (currencyRowId == 0)
            {
                db.Terms.Add(new Model.Term()
                {
                    NameTerm = txt_Name.Text,
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var term = db.Terms.First(x => x.Id == currencyRowId);
                term.NameTerm = txt_Name.Text;
                db.SaveChanges();
                MessageBox.Show("با موفقیت ویرایش شد.");
                DialogResult = DialogResult.OK;
            }
        }

        private void AddTerm_Load(object sender, EventArgs e)
        {
            if (currencyRowId != 0)
            {
                var term = db.Terms.First(x => x.Id == currencyRowId);
                txt_Name.Text = term.NameTerm;
                btn_save.Text = "ویرایش";
                this.Text = "ویرایش دوره";
            }
        }
    }
}
