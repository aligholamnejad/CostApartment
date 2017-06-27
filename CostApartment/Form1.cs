using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CostApartment.CurrentCost;
using CostApartment.Term;

namespace CostApartment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ApartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApartmentUnit.ApartmentUnitList apartment=new ApartmentUnit.ApartmentUnitList();
            apartment.ShowDialog();
        }

        private void TermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Term.TermList term=new TermList();
            term.ShowDialog();
        }

        private void CostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentCost.CurrentCountList currentCount=new CurrentCountList();
            currentCount.ShowDialog();
        }
    }
}
