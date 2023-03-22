using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace AppForLessons
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("E://createPDF.pdf",FileMode.Create));
            doc.Open();
            Paragraph h1 = new Paragraph("Naslov: " + textBoxTitle.Text);
            doc.Add(h1);
            Paragraph p1 = new Paragraph("Text: " + textBoxInput.Text);
            doc.Add(p1);
            Paragraph d1 = new Paragraph("Date: " + Dtp_date.Text);
            doc.Add(d1);
            doc.Close();
            MessageBox.Show("Pdf is create!");

        }
    }
}
