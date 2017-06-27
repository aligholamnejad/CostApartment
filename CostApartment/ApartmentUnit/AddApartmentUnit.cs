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
    public partial class AddApartmentUnit : Form
    {
        public AddApartmentUnit()
        {
            InitializeComponent();
        }
        Model.CostApartmentEntities db = new Model.CostApartmentEntities();
        public int currencyRowId = 0;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (currencyRowId == 0)
            {
                db.ApartmentUnits.Add(new Model.ApartmentUnit()
                {
                    Owner = txt_name.Text,
                    NameUnit = txt_unit.Text,
                    Count = int.Parse(txt_Count.Text),
                    Meter = int.Parse(txt_Meter.Text),
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var unitApartment  = db.ApartmentUnits.First(x => x.Id == currencyRowId);
                unitApartment.Owner = txt_name.Text;
                unitApartment.NameUnit = txt_unit.Text;
                unitApartment.Count = int.Parse(txt_Count.Text);
                unitApartment.Meter = int.Parse(txt_Meter.Text);
                db.SaveChanges();
                MessageBox.Show("با موفقیت ویرایش شد.");
                DialogResult = DialogResult.OK;
            }

        }

        private void AddApartmentUnit_Load(object sender, EventArgs e)
        {
            if (currencyRowId != 0)
            {
                var unitApartment = db.ApartmentUnits.First(x => x.Id == currencyRowId);
                txt_name.Text= unitApartment.Owner;
                txt_unit.Text=unitApartment.NameUnit;
                txt_Count.Text= unitApartment.Count.ToString() ;
                txt_Meter.Text=unitApartment.Meter.ToString();
                btn_Save.Text = "ویرایش";
                this.Text = "ویرایش واحد";
            }
        }

        private void txt_Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }

        private void txt_Meter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
