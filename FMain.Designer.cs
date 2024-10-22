namespace lab5
{
    partial class FORMMAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Method required for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStrip toolStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMMAIN));
            this.btnADD = new System.Windows.Forms.ToolStripButton();
            this.btnEDIT = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDEL = new System.Windows.Forms.ToolStripButton();
            this.btnCLEAR = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEXIT = new System.Windows.Forms.ToolStripButton();
            this.gvDOCS = new System.Windows.Forms.DataGridView();
            this.bindSRCDOC = new System.Windows.Forms.BindingSource(this.components);
            this.documentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfExpireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualTaxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDOCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSRCDOC)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.btnADD,
                this.btnEDIT,
                this.separator1,
                this.btnDEL,
                this.btnCLEAR,
                this.separator2,
                this.btnSaveAsText,
                this.btnSaveAsBinary,
                this.btnOpenFromText,
                this.btnOpenFromBinary,
                this.separator3,
                this.btnEXIT});
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1000, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnADD
            // 
            this.btnADD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(23, 22);
            this.btnADD.Text = "Додати";
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEDIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEDIT.Image")));
            this.btnEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(23, 22);
            this.btnEDIT.Text = "Редагувати";
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDEL
            // 
            this.btnDEL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDEL.Image = ((System.Drawing.Image)(resources.GetObject("btnDEL.Image")));
            this.btnDEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(23, 22);
            this.btnDEL.Text = "Видалити";
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCLEAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCLEAR.Image")));
            this.btnCLEAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(23, 22);
            this.btnCLEAR.Text = "Очистити дані";
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsText.Image")));
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAsText.Text = "Зберегти у текстовому форматі";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsBinary.Image")));
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAsBinary.Text = "Зберегти у бінарному форматі";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromText.Image")));
            this.btnOpenFromText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFromText.Text = "Відкрити з текстового файлу";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromBinary.Image")));
            this.btnOpenFromBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(23, 22);
            this.btnOpenFromBinary.Text = "Відкрити з бінарного файлу";
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEXIT
            // 
            this.btnEXIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEXIT.Image = ((System.Drawing.Image)(resources.GetObject("btnEXIT.Image")));
            this.btnEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(23, 22);
            this.btnEXIT.Text = "Вийти з програми";
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // gvDOCS
            // 
            this.gvDOCS.AllowUserToAddRows = false;
            this.gvDOCS.AllowUserToDeleteRows = false;
            this.gvDOCS.AutoGenerateColumns = false;
            this.gvDOCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDOCS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.documentTypeDataGridViewTextBoxColumn,
                this.iDDataGridViewTextBoxColumn,
                this.nameDataGridViewTextBoxColumn,
                this.surnameDataGridViewTextBoxColumn,
                this.dateOfBirthDataGridViewTextBoxColumn,
                this.nationalityDataGridViewTextBoxColumn,
                this.sexDataGridViewTextBoxColumn,
                this.dateOfIssueDataGridViewTextBoxColumn,
                this.dateOfExpireDataGridViewTextBoxColumn,
                this.individualTaxNumberDataGridViewTextBoxColumn,
                this.employeeIDDataGridViewTextBoxColumn,
                this.departmentDataGridViewTextBoxColumn
            });
            this.gvDOCS.DataSource = this.bindSRCDOC;
            this.gvDOCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDOCS.Location = new System.Drawing.Point(0, 25);
            this.gvDOCS.Name = "gvDOCS";
            this.gvDOCS.ReadOnly = true;
            this.gvDOCS.Size = new System.Drawing.Size(1000, 425);
            this.gvDOCS.TabIndex = 1;
            this.gvDOCS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvDOCS_CellFormatting);
            // 
            // bindSRCDOC
            // 
            //this.bindSRCDOC.DataSource = typeof(lab5.IDocument);
            // 
            // documentTypeDataGridViewTextBoxColumn
            // 
            this.documentTypeDataGridViewTextBoxColumn.HeaderText = "Тип документу";
            this.documentTypeDataGridViewTextBoxColumn.Name = "documentTypeDataGridViewTextBoxColumn";
            this.documentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Національність";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfIssueDataGridViewTextBoxColumn
            // 
            this.dateOfIssueDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Issue";
            this.dateOfIssueDataGridViewTextBoxColumn.HeaderText = "Дата видачі";
            this.dateOfIssueDataGridViewTextBoxColumn.Name = "dateOfIssueDataGridViewTextBoxColumn";
            this.dateOfIssueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfExpireDataGridViewTextBoxColumn
            // 
            this.dateOfExpireDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_expire";
            this.dateOfExpireDataGridViewTextBoxColumn.HeaderText = "Дата закінчення";
            this.dateOfExpireDataGridViewTextBoxColumn.Name = "dateOfExpireDataGridViewTextBoxColumn";
            this.dateOfExpireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualTaxNumberDataGridViewTextBoxColumn
            // 
            this.individualTaxNumberDataGridViewTextBoxColumn.DataPropertyName = "Individual_tax_number";
            this.individualTaxNumberDataGridViewTextBoxColumn.HeaderText = "ІПН";
            this.individualTaxNumberDataGridViewTextBoxColumn.Name = "individualTaxNumberDataGridViewTextBoxColumn";
            this.individualTaxNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "ID працівника";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Відділ";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FORMMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.gvDOCS);
            this.Controls.Add(toolStrip1);
            this.Name = "FORMMAIN";
            this.Text = "Лабораторна робота №5";
            this.Load += new System.EventHandler(this.FORMMAIN_Load);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDOCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSRCDOC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnADD;
        private System.Windows.Forms.ToolStripButton btnEDIT;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton btnDEL;
        private System.Windows.Forms.ToolStripButton btnCLEAR;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripButton btnSaveAsText;
        private System.Windows.Forms.ToolStripButton btnSaveAsBinary;
        private System.Windows.Forms.ToolStripButton btnOpenFromText;
        private System.Windows.Forms.ToolStripButton btnOpenFromBinary;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripButton btnEXIT;
        private System.Windows.Forms.DataGridView gvDOCS;
        private System.Windows.Forms.BindingSource bindSRCDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfExpireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualTaxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}
