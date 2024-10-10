using lab5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class FDoc : Form
    {
        
        public DOCDATACLASS thePass_doc;

        public FDoc(DOCDATACLASS p)
        {
            thePass_doc = p;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (thePass_doc != null)
            {
                tbID.Text = thePass_doc.ID;
                tbName.Text = thePass_doc.Name;
                tbSurname.Text = thePass_doc.Surname;
                tbDateOfBirth.Text = thePass_doc.ToString();
                tbNationality.Text = thePass_doc.Nationality;
                tbDateofIssue.Text = thePass_doc.ToString();
                tbDateofExpire.Text = thePass_doc.ToString();
                
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            thePass_doc.ID = tbID.Text.Trim();
            thePass_doc.Name = tbName.Text.Trim(); 
            thePass_doc.Surname = tbSurname.Text.Trim();
            thePass_doc.Date_Of_Birth = tbDateOfBirth.Text.Trim();
            thePass_doc.Nationality = tbNationality.Text.Trim();
            thePass_doc.Date_Of_Issue = tbDateofIssue.Text.Trim();
            thePass_doc.Date_Of_expire = tbDateofExpire.Text.Trim();
            thePass_doc.Individual_tax_number = tbIndividualTaxNum.Text.Trim();
            thePass_doc.sex = cbMale.Checked;
            thePass_doc.sex = cbFemale.Checked;
            
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
