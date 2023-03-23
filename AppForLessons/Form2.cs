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
using Org.BouncyCastle.Security.Certificates;

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

            var titleFont = FontFactory.GetFont("Arial", 18, BaseColor.BLACK);
            var titleFont2 = FontFactory.GetFont("Arial", 10, BaseColor.DARK_GRAY);


            Document doc = new Document(PageSize.A4, 55f, 55f, 25f, 25f);
            PdfWriter.GetInstance(doc,new FileStream("C:\\Users\\JosipH\\Documents\\Scanned Documents\\documentPDF.pdf", FileMode.Create));
            doc.Open();

            // TextOne
            Paragraph p1 = new Paragraph(
                textBoxName.Text + System.Environment.NewLine + 
                textBoxAddress.Text + System.Environment.NewLine + 
                textBoxPostNum.Text + System.Environment.NewLine +
                textBoxPhoneNum.Text + System.Environment.NewLine +
                textBoxEmail.Text, titleFont2
            );
            doc.Add(p1);

            // TextTwo
            Paragraph p2 = new Paragraph(
                 textBoxRecName.Text + System.Environment.NewLine +
                 textBoxRecAddress.Text + System.Environment.NewLine +
                 textBoxRecPostNum.Text + System.Environment.NewLine, titleFont2
            );
            p2.Alignment = Element.ALIGN_RIGHT;
            doc.Add(p2);


            // Title
            Paragraph title = new Paragraph( 
               textBoxTitle.Text, titleFont
            );
            title.Alignment = Element.ALIGN_CENTER;
            title.SetLeading(2.5f,2.5f);
            doc.Add(title);

            Paragraph p4 = new Paragraph(
                "Poštovani" + System.Environment.NewLine +
                "" + System.Environment.NewLine, titleFont2);
            p4.SetLeading(2.5f, 2.5f);
            doc.Add(p4);
            
            //Text 
            Paragraph text = new Paragraph(
                textBoxText.Text + System.Environment.NewLine +
                "" + System.Environment.NewLine ,titleFont2
            );
            doc.Add(text);

            Paragraph p5 = new Paragraph(
                "S Poštovanjem" + System.Environment.NewLine +
                textBoxName.Text + System.Environment.NewLine +
                "" + System.Environment.NewLine +
                textBoxCity.Text + " " + Dtp_date.Text 
                ,titleFont2
            );
            text.SetLeading(2.5f, 2.5f);
            doc.Add(p5);

            doc.Close();
            MessageBox.Show("The file has been created and saved!");
        }

       

       
    }
}
