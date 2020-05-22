using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class DailyPlanning : Form
    {
        public DailyPlanning()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-69MM1NJ\\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        


        private void DailyPlanning_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Tasks where  DateOfTask='" + (DateTime.Today).ToString("yyyy-MM-dd") + "' and UserName = '" + Home.FK + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ViewTasks.Rows.Add(dr[0], dr[2], dr[1], Convert.ToDateTime(dr[3]).ToShortDateString(), dr[4], dr[5], dr[7], dr[8], dr[6], dr[9]);
                    
                        }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void exportgridtopdf(DataGridView dgv, String filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgv.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //ADD datroow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    { MessageBox.Show("loading"); }
                    else
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledilogue = new SaveFileDialog();
            savefiledilogue.FileName = filename;
            savefiledilogue.DefaultExt = ".pdf";
            if (savefiledilogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledilogue.FileName, FileMode.Create))
                {
                    Document pdfdocument = new Document(PageSize.A4, 10, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdocument, stream);
                    pdfdocument.Open();
                    pdfdocument.Add(pdftable);
                    pdfdocument.Close();
                    stream.Close();

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportgridtopdf(ViewTasks, "planing");
        }
    }
}
