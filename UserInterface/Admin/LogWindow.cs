
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Westry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Westry.ManagerForm;
using Westry.Util;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Fonts;


namespace Westry
{


	public partial class LogWindow : Form
	{
		private static DevDbContext db;

		public LogWindow()
		{
			InitializeComponent();
			LogDataGridView.ReadOnly = true;
			db = new DevDbContext();
		}

		private void pdfButton_Click(object sender, EventArgs e)
		{

			generatePDF();

		}

		private void Log_Load(object sender, EventArgs e)
		{
			KeyPreview = true;
			LogDataGridView.DataBindings.Clear();
			var dt = Utility.db.MealLog.ToList();
			LogDataGridView.DataSource = Utility.ToDataTable(dt);
		}

		private void LogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void generatePDF()
		{
			string LogsdesktopDire = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs");
			if (!Directory.Exists(LogsdesktopDire))
			{
				Directory.CreateDirectory(LogsdesktopDire);
			}
			string pdfFilePath = Path.Combine(LogsdesktopDire, $"{DateTime.Now.ToString("yyyy-MM-dd-HH-mm")}-MealLog.pdf");





			Document doc = new Document();
			Section section = doc.AddSection();


			// 1. Date and Time Section
			Paragraph dateAndTime = section.AddParagraph();
			string finalTxt = "التاريخ";
			finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(finalTxt);
			finalTxt = new string(finalTxt.Reverse().ToArray());
			dateAndTime.AddFormattedText($"{finalTxt}: {DateTime.Now}");

			section.AddParagraph();

			CreateTable(section);






			PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();

			// Associate the document with the renderer
			pdfRenderer.Document = doc;

			// Render the PDF to a file (replace "output.pdf" with your desired file path)

			pdfRenderer.RenderDocument();
			pdfRenderer.PdfDocument.Save(pdfFilePath);
			MessageBox.Show("تم صنع ملف \nPDF\nعلى سطح المكتب");
			this.Close();

		}


		static void CreateTable(Section section)
		{


			// Create the table
			Table table = section.AddTable();
			table.Borders.Width = 0.75;

			// Define the columns
			Column column1 = table.AddColumn(Unit.FromCentimeter(13));
			Column column2 = table.AddColumn(Unit.FromCentimeter(5));

			// Create the header row
			Row headerRow = table.AddRow();
			headerRow.Shading.Color = Colors.LightGray;
			string finalTxt = "نوع الوجبه";
			finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(finalTxt);
			finalTxt = new string(finalTxt.Reverse().ToArray());

			headerRow.Cells[0].AddParagraph(finalTxt);

			finalTxt = "عدد مرات السحب";
			finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(finalTxt);
			finalTxt = new string(finalTxt.Reverse().ToArray());

			headerRow.Cells[1].AddParagraph(finalTxt);

			// Add sample data to the table (replace with your actual data)
			SqlConnection conn = new SqlConnection(db.Database.GetConnectionString());
			SqlCommand cmd = new SqlCommand("SELECT    MAX(choosen_meal) AS taken_meal,  COUNT(*) AS meal_count FROM  MealLog GROUP BY   choosen_meal", conn);

			conn.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				AddTableRow(table, reader["taken_meal"].ToString(), reader["meal_count"].ToString());

			}
			conn.Close();


			//Styling

			table.Format.Font.Size = 20;
			table.Format.Alignment = ParagraphAlignment.Center;

			// Set table style
			table.Style = "Table";
		}

		static void AddTableRow(Table table, string mealType, string orderCount)
		{
			Row row = table.AddRow();
			//char[] charArray = mealType.ToCharArray();
			//Array.Reverse(charArray);


			string finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(mealType);
			finalTxt = new string(finalTxt.Reverse().ToArray());

			row.Cells[0].AddParagraph(finalTxt);
			row.Cells[1].AddParagraph(orderCount);
		}





		private void LogWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			Manager.ManagerInstance.CloseApp();
		}

		private void LogWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				pdfButton.PerformClick();
			}
		}
	}
}
