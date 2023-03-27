using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForLessons
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.Red;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_clockIn_Click(object sender, EventArgs e)
        {
            this.ClockInBox.Text = Clock.Text.ToString();
        }

        private void btn_clockOut_Click(object sender, EventArgs e)
        {
            this.ClockOutBox.Text = Clock.Text.ToString();
        }

        private void choSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[choSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        DataTableCollection tableCollection;

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog(){Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"} )
            {
                if ( openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFileBox.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable =(_)=>new ExcelDataTableConfiguration() { UseHeaderRow = true },
                            });
                            tableCollection = result.Tables;
                            choSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                choSheet.Items.Add(table.TableName);
                        }
                    }
                }
            };
        }
    }
}
