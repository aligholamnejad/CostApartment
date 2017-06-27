using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostApartment.CurrentCost
{
    public partial class AddCurrentCost : Form
    {
        public AddCurrentCost()
        {
            InitializeComponent();
        }
        public int currentCostId = 0;
        Model.CostApartmentEntities db = new Model.CostApartmentEntities();

        private void AddCurrentCost_Load(object sender, EventArgs e)
        {
            cmb_Term.DataSource = db.Terms.Select(i => new { i.Id, i.NameTerm }).ToList();
            cmb_Term.DisplayMember = "Name";
            cmb_Term.ValueMember = "Id";


            //if (portfolioDateilId != 0)
            //{
            //    var portfoiDetail = db.Terms.First(x => x.Id == portfolioDateilId);
            //    //txtNumber.Text = portfoiDetail.Number.ToString();
            //    //// cmbCurrency.Text = portfoiDetail.CurrencyId.ToString();
            //    //cmbCurrency.SelectedValue = portfoiDetail.CurrencyId;
            //    //cmbPortfoi.SelectedValue = portfoiDetail.PortfoliosId;
            //    //txtFrom.DateTimeValue = portfoiDetail.Date.Date;
            //    //BtnAdd.Text = "ویرایش";
            //}
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (currentCostId == 0)
            {
                db.CurrentCosts.Add(new Model.CurrentCost()
                {
                    TermId = (int)cmb_Term.SelectedValue,
                    ElectricityCost = decimal.Parse(txt_electricityCost.Text),
                    GasCost = decimal.Parse(txt_gasCost.Text),
                    WaterCost = decimal.Parse(txt_waterCost.Text),
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var currentCost = db.CurrentCosts.First(x => x.Id == currentCostId);
                cmb_Term.SelectedValue = currentCost.TermId;
                txt_electricityCost.Text = currentCost.ElectricityCost.ToString();
                txt_waterCost.Text = currentCost.WaterCost.ToString();
                txt_gasCost.Text = currentCost.GasCost.ToString();
                db.SaveChanges();
                MessageBox.Show("با موفقیت ویرایش شد.", ",ویرایش");
                DialogResult = DialogResult.OK;
            }

        }
    }
}
