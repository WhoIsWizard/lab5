using lab5;
using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class FDoc : Form
    {
        public IDocument thePass_doc;

        public FDoc(IDocument p)
        {
            thePass_doc = p;
            InitializeComponent();
        }

        private void FDoc_Load(object sender, EventArgs e)
        {
            if (thePass_doc != null)
            {
                tbID.Text = thePass_doc.ID;
                tbName.Text = thePass_doc.Name;
                tbSurname.Text = thePass_doc.Surname;
                tbDateOfBirth.Text = thePass_doc.Date_Of_Birth;
                tbNationality.Text = thePass_doc.Nationality;
                tbDateofIssue.Text = thePass_doc.Date_Of_Issue;
                tbDateofExpire.Text = thePass_doc.Date_Of_expire;
                tbIndividualTaxNum.Text = thePass_doc.Individual_tax_number;
                cbMale.Checked = thePass_doc.sex;
                cbFemale.Checked = !thePass_doc.sex;

                // Перевірка, чи документ є EmployeeDocument
                if (thePass_doc is EmployeeDocument empDoc)
                {
                    tbEmployeeID.Text = empDoc.EmployeeID;
                    tbDepartment.Text = empDoc.Department;
                    // Відкрити групу додаткових полів
                    groupBoxEmployee.Visible = true;
                }
                else
                {
                    // Приховати групу додаткових полів
                    groupBoxEmployee.Visible = false;
                }
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

            // Перевірка, чи документ є EmployeeDocument
            if (thePass_doc is EmployeeDocument empDoc)
            {
                empDoc.EmployeeID = tbEmployeeID.Text.Trim();
                empDoc.Department = tbDepartment.Text.Trim();
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
