using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab5
{
    public partial class FORMMAIN : Form
    {
        private BindingList<IDocument> dataSource;

        public FORMMAIN()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            // Відкрити діалог вибору типу документу
            using (AddDocumentTypeForm addTypeForm = new AddDocumentTypeForm())
            {
                if (addTypeForm.ShowDialog() == DialogResult.OK)
                {
                    IDocument data;
                    if (addTypeForm.SelectedDocumentType == DocumentType.Regular)
                    {
                        data = new DOCDATACLASS();
                    }
                    else // EmployeeDocument
                    {
                        data = new EmployeeDocument();
                    }

                    FDoc fd = new FDoc(data);
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        dataSource.Add(data);
                    }
                }
            }
        }
        private void gvDOCS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Форматування стовпця "Стать"
            if (gvDOCS.Columns[e.ColumnIndex].Name == "sexDataGridViewTextBoxColumn" && e.Value != null)
            {
                bool sex = (bool)e.Value;
                e.Value = sex ? "Чоловік" : "Жінка";
                e.FormattingApplied = true;
            }

            // Форматування стовпця "Тип документу"
            if (gvDOCS.Columns[e.ColumnIndex].Name == "documentTypeDataGridViewTextBoxColumn" && e.RowIndex >= 0)
            {
                IDocument doc = (IDocument)gvDOCS.Rows[e.RowIndex].DataBoundItem;
                e.Value = doc is EmployeeDocument ? "Працівник" : "Звичайний";
                e.FormattingApplied = true;
            }

            // Заповнення стовпця "ID працівника"
            if (gvDOCS.Columns[e.ColumnIndex].Name == "employeeIDDataGridViewTextBoxColumn" && e.RowIndex >= 0)
            {
                IDocument doc = (IDocument)gvDOCS.Rows[e.RowIndex].DataBoundItem;
                if (doc is EmployeeDocument empDoc)
                {
                    e.Value = empDoc.EmployeeID;
                }
                else
                {
                    e.Value = string.Empty; // Або інше значення за замовчуванням
                }
                e.FormattingApplied = true;
            }

            // Заповнення стовпця "Відділ"
            if (gvDOCS.Columns[e.ColumnIndex].Name == "departmentDataGridViewTextBoxColumn" && e.RowIndex >= 0)
            {
                IDocument doc = (IDocument)gvDOCS.Rows[e.RowIndex].DataBoundItem;
                if (doc is EmployeeDocument empDoc)
                {
                    e.Value = empDoc.Department;
                }
                else
                {
                    e.Value = string.Empty; // Або інше значення за замовчуванням
                }
                e.FormattingApplied = true;
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (gvDOCS.CurrentRow != null)
            {
                IDocument data = (IDocument)gvDOCS.CurrentRow.DataBoundItem;

                FDoc fd = new FDoc(data);
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    gvDOCS.Refresh();
                }
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (gvDOCS.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    IDocument data = (IDocument)gvDOCS.CurrentRow.DataBoundItem;
                    dataSource.Remove(data);
                }
            }
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataSource.Clear();
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FORMMAIN_Load(object sender, EventArgs e)
        {
            gvDOCS.AutoGenerateColumns = false;

            dataSource = new BindingList<IDocument>();

            // Додавання прикладів даних
            dataSource.Add(new DOCDATACLASS("123456", "Іван", "Рево", "01-01-1990", "Україна", true, "01-01-2015", "01-01-2025", "1234567890"));
            dataSource.Add(new EmployeeDocument("654321", "Олена", "Коваль", "05-05-1985", "Україна", false, "01-01-2016", "01-01-2026", "0987654321", "E123", "HR"));

            bindSRCDOC.DataSource = dataSource;

            gvDOCS.DataSource = bindSRCDOC;

            gvDOCS.AutoResizeColumns();
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            // Створення діалогу збереження файлу
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Запис даних у текстовий файл
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    try
                    {
                        foreach (IDocument doc in bindSRCDOC.List)
                        {
                            // Додаємо інформацію про тип документу для коректного завантаження
                            string docType = doc is EmployeeDocument ? "Employee" : "Regular";

                            sw.WriteLine(docType + "|" +
                                doc.ID + "|" +
                                doc.Name + "|" +
                                doc.Surname + "|" +
                                doc.Date_Of_Birth + "|" +
                                doc.Nationality + "|" +
                                doc.sex + "|" +
                                doc.Date_Of_Issue + "|" +
                                doc.Date_Of_expire + "|" +
                                doc.Individual_tax_number +
                                (doc is EmployeeDocument empDoc ? "|" + empDoc.EmployeeID + "|" + empDoc.Department : ""));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка: \n{ex.Message}",
                                        "Помилка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файли даних (*.docs)|*.docs|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter bw = new BinaryWriter(saveFileDialog.OpenFile()))
                {
                    try
                    {
                        foreach (IDocument doc in bindSRCDOC.List)
                        {
                            // Запис типу документу
                            bw.Write(doc is EmployeeDocument ? "Employee" : "Regular");

                            // Запис загальних властивостей
                            bw.Write(doc.ID ?? "");
                            bw.Write(doc.Name ?? "");
                            bw.Write(doc.Surname ?? "");
                            bw.Write(doc.Date_Of_Birth ?? "");
                            bw.Write(doc.Nationality ?? "");
                            bw.Write(doc.sex);
                            bw.Write(doc.Date_Of_Issue ?? "");
                            bw.Write(doc.Date_Of_expire ?? "");
                            bw.Write(doc.Individual_tax_number ?? "");

                            // Запис додаткових властивостей, якщо документ є EmployeeDocument
                            if (doc is EmployeeDocument empDoc)
                            {
                                bw.Write(empDoc.EmployeeID ?? "");
                                bw.Write(empDoc.Department ?? "");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка: \n{ex.Message}",
                                        "Помилка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Очистити існуючі дані
                dataSource.Clear();

                using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                {
                    try
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            string[] split = s.Split('|');

                            if (split.Length >= 10)
                            {
                                string docType = split[0];
                                if (docType == "Regular" && split.Length >= 10)
                                {
                                    DOCDATACLASS doc = new DOCDATACLASS
                                    {
                                        ID = split[1],
                                        Name = split[2],
                                        Surname = split[3],
                                        Date_Of_Birth = split[4],
                                        Nationality = split[5],
                                        sex = split[6] == "True",
                                        Date_Of_Issue = split[7],
                                        Date_Of_expire = split[8],
                                        Individual_tax_number = split[9]
                                    };
                                    dataSource.Add(doc);
                                }
                                else if (docType == "Employee" && split.Length >= 12)
                                {
                                    EmployeeDocument empDoc = new EmployeeDocument
                                    {
                                        ID = split[1],
                                        Name = split[2],
                                        Surname = split[3],
                                        Date_Of_Birth = split[4],
                                        Nationality = split[5],
                                        sex = split[6] == "True",
                                        Date_Of_Issue = split[7],
                                        Date_Of_expire = split[8],
                                        Individual_tax_number = split[9],
                                        EmployeeID = split[10],
                                        Department = split[11]
                                    };
                                    dataSource.Add(empDoc);
                                }
                                else
                                {
                                    MessageBox.Show("Неправильний формат даних у файлі.",
                                                    "Помилка",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неправильний формат даних у файлі.",
                                                "Помилка",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка: \n{ex.Message}",
                                        "Помилка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.docs)|*.docs|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Очистити існуючі дані
                dataSource.Clear();

                using (BinaryReader br = new BinaryReader(openFileDialog.OpenFile()))
                {
                    try
                    {
                        while (br.BaseStream.Position < br.BaseStream.Length)
                        {
                            string docType = br.ReadString();

                            if (docType == "Regular")
                            {
                                DOCDATACLASS doc = new DOCDATACLASS
                                {
                                    ID = br.ReadString(),
                                    Name = br.ReadString(),
                                    Surname = br.ReadString(),
                                    Date_Of_Birth = br.ReadString(),
                                    Nationality = br.ReadString(),
                                    sex = br.ReadBoolean(),
                                    Date_Of_Issue = br.ReadString(),
                                    Date_Of_expire = br.ReadString(),
                                    Individual_tax_number = br.ReadString()
                                };
                                dataSource.Add(doc);
                            }
                            else if (docType == "Employee")
                            {
                                EmployeeDocument empDoc = new EmployeeDocument
                                {
                                    ID = br.ReadString(),
                                    Name = br.ReadString(),
                                    Surname = br.ReadString(),
                                    Date_Of_Birth = br.ReadString(),
                                    Nationality = br.ReadString(),
                                    sex = br.ReadBoolean(),
                                    Date_Of_Issue = br.ReadString(),
                                    Date_Of_expire = br.ReadString(),
                                    Individual_tax_number = br.ReadString(),
                                    EmployeeID = br.ReadString(),
                                    Department = br.ReadString()
                                };
                                dataSource.Add(empDoc);
                            }
                            else
                            {
                                MessageBox.Show("Невідомий тип документу у файлі.",
                                                "Помилка",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталася помилка: \n{ex.Message}",
                                        "Помилка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }

        }

        
    }
}
