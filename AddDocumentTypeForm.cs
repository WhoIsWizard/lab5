using System;
using System.Windows.Forms;

namespace lab5
{
    public enum DocumentType
    {
        Regular,
        Employee
    }

    public partial class AddDocumentTypeForm : Form
    {
        public DocumentType SelectedDocumentType { get; private set; }

        public AddDocumentTypeForm()
        {
            InitializeComponent();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            SelectedDocumentType = DocumentType.Regular;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SelectedDocumentType = DocumentType.Employee;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddDocumentTypeForm_Load(object sender, EventArgs e)
        {
            // Можна додати початкові налаштування, якщо необхідно
        }
    }
}
