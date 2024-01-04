
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
			hideTimePeriod();
		}


		private void generatePDF()
		{
			string LogsdesktopDire = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Logs");
			if (!Directory.Exists(LogsdesktopDire))
			{
				Directory.CreateDirectory(LogsdesktopDire);
			}
			string pdfFilePath = Path.Combine(LogsdesktopDire, $"{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-MealLog.pdf");





			Document doc = new Document();
			Section section = doc.AddSection();


			// 1. Date and Time Section
			Paragraph dateAndTime = section.AddParagraph();
			string finalTxt = "تاريخ السجل";
			finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(finalTxt);
			finalTxt = new string(finalTxt.Reverse().ToArray());
			dateAndTime.AddFormattedText($"{DateTime.Now.ToString("dd/MM/yyyy")}:{finalTxt}");

			if(specificPeriodCB.Checked)
			{
				Paragraph fromDateToDate = section.AddParagraph();
				string fromText = "من";
				fromText = ArabicGlyphConverter.ConvertToArabicGlyphs(fromText);
				fromText = new string(fromText.Reverse().ToArray());

				string toText = "إلى";
				toText = ArabicGlyphConverter.ConvertToArabicGlyphs(toText);
				toText = new string(toText.Reverse().ToArray());


				DateTime fromDate = specificTimeFrom.Value.Date;
				DateTime toDate = specificTimeTo.Value.Date;
				TimeSpan ts = new TimeSpan(11, 59, 0);
				toDate = toDate.AddHours(23.9999);

				fromDateToDate.AddFormattedText($"{toDate.ToString("dd/MM/yyyy")}: {toText} {fromDate.ToString("dd/MM/yyyy")}: {fromText}");
			}

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


		private void CreateTable(Section section)
		{


			// Create the table
			Table table = section.AddTable();
			table.Borders.Width = 0.75;

			// Define the columns
			Column column1 = table.AddColumn(Unit.FromCentimeter(10));
			Column column2 = table.AddColumn(Unit.FromCentimeter(5));
			Column column3 = table.AddColumn(Unit.FromCentimeter(3));

			// Create the header row
			Row headerRow = table.AddRow();
			headerRow.Shading.Color = Colors.LightGray;
			string finalTxt = "اسم الوجبه";
			finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(finalTxt);
			finalTxt = new string(finalTxt.Reverse().ToArray());

			headerRow.Cells[0].AddParagraph(finalTxt);

			finalTxt = "عدد مرات السحب";
			finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(finalTxt);
			finalTxt = new string(finalTxt.Reverse().ToArray());

			headerRow.Cells[1].AddParagraph(finalTxt);

			finalTxt = "نوع الوجبه";
			finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(finalTxt);
			finalTxt = new string(finalTxt.Reverse().ToArray());

			headerRow.Cells[2].AddParagraph(finalTxt);

			// Add sample data to the table (replace with your actual data)
			SqlConnection conn = new SqlConnection(db.Database.GetConnectionString());
			SqlCommand cmd;
			if (specificPeriodCB.Checked) {
				DateTime fromDate = specificTimeFrom.Value.Date;
				DateTime toDate = specificTimeTo.Value.Date;
				TimeSpan ts = new TimeSpan(11, 59, 0);
				toDate = toDate.AddHours(23.9999);

				cmd = new SqlCommand("SELECT   choosen_meal AS taken_meal,    COUNT(*) AS meal_count,  CASE    WHEN MAX(CAST(is_buffet AS INT)) = 1 THEN '1'       WHEN MAX(CAST(is_kitchen AS INT)) = 1 THEN '2'    ELSE 'unknown'   END AS meal_type FROM MealLog WHERE time_taken BETWEEN @StartTime AND @EndTime GROUP BY   choosen_meal;", conn);
				
				cmd.Parameters.AddWithValue("@StartTime", fromDate);
				cmd.Parameters.AddWithValue("@EndTime", toDate);
			}
			else
			{
				 cmd = new SqlCommand("SELECT   choosen_meal AS taken_meal,    COUNT(*) AS meal_count,  CASE    WHEN MAX(CAST(is_buffet AS INT)) = 1 THEN '1'       WHEN MAX(CAST(is_kitchen AS INT)) = 1 THEN '2'    ELSE 'unknown'   END AS meal_type FROM MealLog GROUP BY   choosen_meal;", conn);
			}

			conn.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				AddTableRow(table, reader["taken_meal"].ToString(), reader["meal_count"].ToString(), reader["meal_type"].ToString());

			}
			conn.Close();


			//Styling

			table.Format.Font.Size = 20;
			table.Format.Alignment = ParagraphAlignment.Center;

			// Set table style
			table.Style = "Table";
		}

		static void AddTableRow(Table table, string mealType, string orderCount, string mealKind)
		{
			Row row = table.AddRow();
			//char[] charArray = mealType.ToCharArray();
			//Array.Reverse(charArray);


			string finalTxt = ArabicGlyphConverter.ConvertToArabicGlyphs(mealType);
			finalTxt = new string(finalTxt.Reverse().ToArray());

			string secondFintalText;
			if (mealKind == "1")
			{
				secondFintalText = "بوفيه";
			}
			else
			{
				secondFintalText = "مطبخ";
			}
			secondFintalText= ArabicGlyphConverter.ConvertToArabicGlyphs(secondFintalText);
			secondFintalText = new string(secondFintalText.Reverse().ToArray());

			row.Cells[0].AddParagraph(finalTxt);
			row.Cells[1].AddParagraph(orderCount);
			row.Cells[2].AddParagraph(secondFintalText);
		}





		private void LogWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			Manager.ManagerInstance.CloseApp();
		}

		private void LogWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				pdfButton.PerformClick();
			}
		}

		private void specificPeriodCB_CheckedChanged(object sender, EventArgs e)
		{
			if (specificPeriodCB.Checked)
			{
				specificTimeBTN.Visible = true;
				specificTimeTo.Visible = true;
				specificTimeFrom.Visible = true;
				ToLabel.Visible = true;
				FromLabel.Visible = true;
			}
			else
			{
				hideTimePeriod();
				LogDataGridView.DataBindings.Clear();
				var dt = Utility.db.MealLog.ToList();
				LogDataGridView.DataSource = Utility.ToDataTable(dt);
			}
		}

		private void hideTimePeriod()
		{
			specificTimeBTN.Visible = false;
			specificTimeTo.Visible = false;
			specificTimeFrom.Visible = false;
			ToLabel.Visible = false;
			FromLabel.Visible = false;
		}

		private void specificTimeBTN_Click(object sender, EventArgs e)
		{
			DateTime fromDate = specificTimeFrom.Value.Date;
			DateTime toDate = specificTimeTo.Value.Date;
			TimeSpan ts = new TimeSpan(11, 59, 0);
			toDate = toDate.AddHours(23.9999);
			var query = Utility.db.MealLog.AsQueryable();
			LogDataGridView.DataBindings.Clear();
			query = query.Where(u => u.TimeTaken >= fromDate && u.TimeTaken <= toDate);
			var dt = query.ToList();
			LogDataGridView.DataSource = Utility.ToDataTable(dt);
		}
	}
}
