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
using System.Reflection.Emit;


namespace AppForLessons
{
    public partial class Form2 : Form
    {
        private HorizontalAlignment SelectionAlignment;

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            /* Document doc = new Document();
             PdfWriter.GetInstance(doc, new FileStream("E://createPDF.pdf",FileMode.Create));
             doc.Open();
             Paragraph h1 = new Paragraph("Naslov: " + textBoxTitle.Text);
             doc.Add(h1);
             Paragraph p1 = new Paragraph("Text: " + textBoxInput.Text);
             doc.Add(p1);
             Paragraph d1 = new Paragraph("Date: " + Dtp_date.Text);
             doc.Add(d1);
             doc.Close();
             MessageBox.Show("Pdf is create!");*/

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("E://createPDF.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph(
                textBoxName.Text + System.Environment.NewLine + 
                textBoxAddress.Text + System.Environment.NewLine + 
                textBoxPostNum.Text + System.Environment.NewLine +
                textBoxPhoneNum.Text + System.Environment.NewLine +
                textBoxEmail.Text
            );
            doc.Add(p1);

            Paragraph p2 = new Paragraph(
                 textBoxRecName.Text + System.Environment.NewLine +
                 textBoxRecAddress.Text + System.Environment.NewLine +
                 textBoxRecPostNum.Text + System.Environment.NewLine
            );
            p2.Alignment = Element.ALIGN_RIGHT;
            doc.Add(p2);

            Paragraph p3 = new Paragraph(
               textBoxTitle.Text
            );
            p3.Alignment = Element.ALIGN_CENTER;
            doc.Add(p3);

            doc.Close();
            MessageBox.Show("Pdf is create!");




        }

    }
}
