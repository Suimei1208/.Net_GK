using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;
using System.Globalization;
using _521H0049_521H0174.Models;
using System.Data.Entity;
using CsvHelper.Configuration;

namespace _521H0049_521H0174
{
    public class ImportAndExport
    {
        private Model1 dbContext;
        public ImportAndExport()
        {
            dbContext = new Model1();
        }
        public static List<Student> ReadCsvFile(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null,
            };

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<Student>().ToList();
            }
        }

        public static void ExportToExcel(List<Student> students, string filePath)
        {
            ExcelPackage package = null;
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                package = new ExcelPackage();
                var worksheet = package.Workbook.Worksheets.Add("Students");

                worksheet.Cells["A1"].Value = "FirstName";
                worksheet.Cells["B1"].Value = "LastName";
                worksheet.Cells["C1"].Value = "Age";
                worksheet.Cells["D1"].Value = "Gender";
                worksheet.Cells["E1"].Value = "GPA";
                worksheet.Cells["F1"].Value = "Status";
                worksheet.Cells["G1"].Value = "PhoneNumber";

                for (int i = 0; i < students.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = students[i].FirstName;
                    worksheet.Cells[i + 2, 2].Value = students[i].LastName;
                    worksheet.Cells[i + 2, 3].Value = students[i].Age;
                    worksheet.Cells[i + 2, 4].Value = students[i].Gender;
                    worksheet.Cells[i + 2, 5].Value = students[i].GPA;
                    worksheet.Cells[i + 2, 6].Value = students[i].Status;
                    worksheet.Cells[i + 2, 7].Value = students[i].PhoneNumber;
                }

                package.SaveAs(new FileInfo(filePath));
            }
            finally
            {
                if (package != null)
                {
                    package.Dispose();
                }
            }
        }

        public static void ExportToCsv(List<Student> students, string filePath)
        {
            StreamWriter writer = null;
            CsvWriter csv = null;

            try
            {
                writer = new StreamWriter(filePath);
                csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(students);
            }
            finally
            {
                if (csv != null)
                {
                    csv.Dispose();
                }

                if (writer != null)
                {
                    writer.Dispose();
                }
            }
        }

        public void ImportFile()
        {
            string filePath = GetFilePath();
            if (!string.IsNullOrEmpty(filePath))
            {
                var students = ReadCsvFile(filePath);            
                dbContext.Students.AddRange(students);
                dbContext.SaveChanges();

                MessageBox.Show("Import successful!");
                
            }
            else
            {
                MessageBox.Show("No file selected.");
            }
        }

        public List<Student> GetAllStudent()
        {
            var students = dbContext.Students.ToList(); 

            var studentDTOs = students.Select(s => new Student
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Gender = s.Gender,
                GPA = s.GPA,
                Status = s.Status,
                PhoneNumber = s.PhoneNumber
            }).ToList();

            return studentDTOs;
        }
        public void ExportFile()
        {
            var filePath = GetSaveFilePath();
            if (!string.IsNullOrEmpty(filePath))
            {
                if (Path.GetExtension(filePath).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                {
                    ExportToExcel(GetAllStudent(), filePath);
                    MessageBox.Show("Export successfully");
                }
                else if (Path.GetExtension(filePath).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    ExportToCsv(dbContext.Students.ToList(), filePath);
                    MessageBox.Show("Export successfully");
                }
                else
                {
                    MessageBox.Show("Unsupported file format.");
                }
            }
            else
            {
                MessageBox.Show("Export canceled.");
            }
        }

        public static string GetSaveFilePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public static string GetFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();          
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return null;
            }
            
        }

    }
}
