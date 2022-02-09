using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Word = Microsoft.Office.Interop.Word;

namespace Sklad
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();

            string Text = "SELECT detail.name, material.material , detail.count , detail.measurement , warehouse.name , shelf.number ," +
                "shelf.location, detail.id_cell " +
                "FROM `detail` " +
                "JOIN `material` " +
                "ON  detail.id_material = material.id " +
                "JOIN `warehouse` " +
                "ON  detail.id_warehouse = warehouse.id " +
                "JOIN `shelf` " +
                "ON detail.id_shelf = shelf.id";

            System.Collections.Generic.List<string> details = SQLClass.Select(Text);

            List<string[]> data = new List<string[]>();
            for (int i = 0; i < details.Count - 7; i += 8)
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = details[i].ToString();
                data[data.Count - 1][1] = details[i + 1].ToString();
                data[data.Count - 1][2] = details[i + 2].ToString();
                data[data.Count - 1][3] = details[i + 3].ToString();
                data[data.Count - 1][4] = details[i + 4].ToString();
                data[data.Count - 1][5] = details[i + 5].ToString();
                data[data.Count - 1][6] = details[i + 6].ToString();
                data[data.Count - 1][7] = details[i + 7].ToString();

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void CreateTable(string dest)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest));
            Document doc = new Document(pdfDoc);

            int dgvrowcount = dataGridView1.Rows.Count;

            int dgvcolumncount = dataGridView1.Columns.Count;


            float[] pointColumnWidths = { 150F, 150F, 50F, 50F, 150F, 15F, 15F, 15F };
            Table table = new Table(pointColumnWidths);
            string Text;
            if (textBox1.Text == "" || textBox1.Text == "Введите название детали")
            {
                Text = "SELECT detail.name, material.material , detail.count , detail.measurement , warehouse.name , shelf.number ," +
                  "shelf.location, detail.id_cell " +
                  "FROM `detail` " +
                  "JOIN `material` " +
                  "ON  detail.id_material = material.id " +
                  "JOIN `warehouse` " +
                  "ON  detail.id_warehouse = warehouse.id " +
                  "JOIN `shelf` " +
                  "ON detail.id_shelf = shelf.id";
            }
            else
            {Text = "SELECT detail.name, material.material , detail.count , detail.measurement , warehouse.name , shelf.number ," +
                "shelf.location, detail.id_cell " +
                "FROM `detail` " +
                "JOIN `material` " +
                "ON  detail.id_material = material.id " +
                "JOIN `warehouse` " +
                "ON  detail.id_warehouse = warehouse.id " +
                "JOIN `shelf` " +
                "ON detail.id_shelf = shelf.id" +
                " WHERE detail.name LIKE " + "'%" + textBox1.Text + "%' " + "ORDER BY detail.name"; }

             

            System.Collections.Generic.List<string> details = SQLClass.Select(Text);


            // Создаём шрифт и используем далее
            String FONT_FILENAME = "C:/Users/pc/source/repos/Sklad/Sklad/font/TTF.ttf";
            PdfFont font = PdfFontFactory.CreateFont(FONT_FILENAME);

            string today_date = Convert.ToString(DateTime.Now.ToLongDateString());
            string today_time = Convert.ToString(DateTime.Now.ToShortTimeString());
            doc.Add(new Paragraph("Пользователь:").SetFont(font));
            doc.Add(new Paragraph("Перечень деталей на " + today_date + ", " + today_time).SetFont(font));
            List<string[]> data = new List<string[]>();
            for (int i = 0; i < details.Count - 7; i += 8)
            {
                Cell cell1 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.LEFT)
                      .Add(new Paragraph(details[i].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell1));
                Cell cell2 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(details[i + 1].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell2));
                Cell cell3 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(details[i + 2].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell3));
                Cell cell4 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(details[i + 3].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell4));
                Cell cell5 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(details[i + 4].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell5));
                Cell cell6 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(details[i + 5].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell6));
                Cell cell7 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(details[i + 6].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell7));
                Cell cell8 = new Cell(1, 1)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(details[i + 7].ToString()).SetFont(font));
                table.AddCell(new Cell().Add(cell8));

            }


            doc.Add(table);
            doc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string today_date = Convert.ToString(DateTime.Now.ToLongDateString());
            string today_time = Convert.ToString(DateTime.Now.ToShortTimeString());
            ClsPrint _ClsPrint = new ClsPrint(dataGridView1, "Перечень деталей на " + today_date + ", " + today_time);
            _ClsPrint.PrintForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CreateTable(saveFileDialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();
                string Text11 = "SELECT detail.name, material.material , detail.count , detail.measurement , warehouse.name , shelf.number ," +
                "shelf.location, detail.id_cell " +
                "FROM `detail` " +
                "JOIN `material` " +
                "ON  detail.id_material = material.id " +
                "JOIN `warehouse` " +
                "ON  detail.id_warehouse = warehouse.id " +
                "JOIN `shelf` " +
                "ON detail.id_shelf = shelf.id"  +
                " WHERE detail.name LIKE " + "'%" + textBox1.Text + "%' " + "ORDER BY detail.name";

                System.Collections.Generic.List<string> details = SQLClass.Select(Text11);

                List<string[]> data = new List<string[]>();
                for (int i = 0; i < details.Count - 7; i += 8)
                {
                    data.Add(new string[8]);
                    data[data.Count - 1][0] = details[i].ToString();
                    data[data.Count - 1][1] = details[i + 1].ToString();
                    data[data.Count - 1][2] = details[i + 2].ToString();
                    data[data.Count - 1][3] = details[i + 3].ToString();
                    data[data.Count - 1][4] = details[i + 4].ToString();
                    data[data.Count - 1][5] = details[i + 5].ToString();
                    data[data.Count - 1][6] = details[i + 6].ToString();
                    data[data.Count - 1][7] = details[i + 7].ToString();

                }
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string Text = "SELECT detail.name, material.material , detail.count , detail.measurement , warehouse.name , shelf.number ," +
                "shelf.location, detail.id_cell " +
                "FROM `detail` " +
                "JOIN `material` " +
                "ON  detail.id_material = material.id " +
                "JOIN `warehouse` " +
                "ON  detail.id_warehouse = warehouse.id " +
                "JOIN `shelf` " +
                "ON detail.id_shelf = shelf.id";

            System.Collections.Generic.List<string> details = SQLClass.Select(Text);

            List<string[]> data = new List<string[]>();
            for (int i = 0; i < details.Count - 7; i += 8)
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = details[i].ToString();
                data[data.Count - 1][1] = details[i + 1].ToString();
                data[data.Count - 1][2] = details[i + 2].ToString();
                data[data.Count - 1][3] = details[i + 3].ToString();
                data[data.Count - 1][4] = details[i + 4].ToString();
                data[data.Count - 1][5] = details[i + 5].ToString();
                data[data.Count - 1][6] = details[i + 6].ToString();
                data[data.Count - 1][7] = details[i + 7].ToString();

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
