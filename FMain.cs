using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab5
{
    public partial class FORMMAIN : Form
    {
        private BindingList<DOCDATACLASS> dataSource;

        public FORMMAIN()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DOCDATACLASS data = new DOCDATACLASS();

            FDoc fd = new FDoc(data);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dataSource.Add(data);
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (gvDOCS.CurrentRow != null)
            {
                DOCDATACLASS data = (DOCDATACLASS)gvDOCS.CurrentRow.DataBoundItem;

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
                    DOCDATACLASS data = (DOCDATACLASS)gvDOCS.CurrentRow.DataBoundItem;
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
            // Since the columns are defined in the Designer, we don't need to add them here.
            // So, remove or comment out the code that adds columns programmatically.

            // Ensure that AutoGenerateColumns is set to false
            gvDOCS.AutoGenerateColumns = false;

            // Initialize your data source
            dataSource = new BindingList<DOCDATACLASS>();

            // Add sample data if needed
            dataSource.Add(new DOCDATACLASS("123456", "Іван", "Рево", "01-01-1990", "Україна", true, "01-01-2015", "01-01-2025", "1234567890"));

            // Bind the data source to the BindingSource
            bindSRCDOC.DataSource = dataSource;

            // Bind the BindingSource to the DataGridView
            gvDOCS.DataSource = bindSRCDOC;

            // Adjust column widths if necessary
            gvDOCS.AutoResizeColumns();
        }


        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to prompt the user for a file path
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a StreamWriter to write data to the selected file
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    try
                    {
                        // Iterate over each DOCDATACLASS item in the binding source
                        foreach (DOCDATACLASS doc in bindSRCDOC.List)
                        {
                            // Write the properties of DOCDATACLASS separated by tabs
                            sw.WriteLine(
                                doc.ID + "\t" +
                                doc.Name + "\t" +
                                doc.Surname + "\t" +
                                doc.Date_Of_Birth + "\t" +
                                doc.Nationality + "\t" +
                                doc.Date_Of_Issue + "\t" +
                                doc.Date_Of_expire + "\t" +
                                doc.Individual_tax_number
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show an error message if something goes wrong
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
                        foreach (DOCDATACLASS doc in bindSRCDOC.List)
                        {
                            bw.Write(doc.ID ?? "");
                            bw.Write(doc.Name ?? "");
                            bw.Write(doc.Surname ?? "");
                            bw.Write(doc.Date_Of_Birth ?? "");
                            bw.Write(doc.Nationality ?? "");
                            bw.Write(doc.sex);
                            bw.Write(doc.Date_Of_Issue ?? "");
                            bw.Write(doc.Date_Of_expire ?? "");
                            bw.Write(doc.Individual_tax_number ?? "");
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
                // Clear existing data
                dataSource.Clear();

                using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                {
                    try
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            string[] split = s.Split('\t');

                            if (split.Length >= 9)
                            {
                                DOCDATACLASS doc = new DOCDATACLASS
                                {
                                    ID = split[0],
                                    Name = split[1],
                                    Surname = split[2],
                                    Date_Of_Birth = split[3],
                                    Nationality = split[4],
                                    sex = split[5] == "Чоловік",
                                    Date_Of_Issue = split[6],
                                    Date_Of_expire = split[7],
                                    Individual_tax_number = split[8]
                                };

                                dataSource.Add(doc);
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
                // Clear existing data
                dataSource.Clear();

                using (BinaryReader br = new BinaryReader(openFileDialog.OpenFile()))
                {
                    try
                    {
                        while (br.BaseStream.Position < br.BaseStream.Length)
                        {
                            DOCDATACLASS doc = new DOCDATACLASS();

                            // Read data in the same order as it was written
                            doc.ID = br.ReadString();
                            doc.Name = br.ReadString();
                            doc.Surname = br.ReadString();
                            doc.Date_Of_Birth = br.ReadString();
                            doc.Nationality = br.ReadString();
                            doc.sex = br.ReadBoolean();
                            doc.Date_Of_Issue = br.ReadString();
                            doc.Date_Of_expire = br.ReadString();
                            doc.Individual_tax_number = br.ReadString();

                            // Add the doc to the data source
                            dataSource.Add(doc);
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


