using ExcelWeb.SL.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExcelWeb.SL.Services
{
    public class ExcelService : IExcelService
    {
        public ExcelPackage GetExcelFile(byte[] fileData)
        {
            try
            {
                using var stream = new MemoryStream(fileData);
                return new ExcelPackage(stream);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ExcelWorksheet GetExcelWorksheet(ExcelPackage excelFilePackage, string worksheetName)
        {
            try
            {
                return excelFilePackage.Workbook.Worksheets
                    .FirstOrDefault(x => x.Name == worksheetName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> LoopExcel(byte[] fileData)
        {
            try
            {
                var excelData = new List<string>();

                using var stream = new MemoryStream(fileData);
                using var excelPackage = new ExcelPackage(stream);
                foreach (var worksheet in excelPackage.Workbook.Worksheets)
                {
                    for (int i = worksheet.Dimension.Start.Row; i < worksheet.Dimension.End.Row; i++)
                    {
                        for (int j = worksheet.Dimension.Start.Column; j < worksheet.Dimension.End.Column; j++)
                        {
                            if (worksheet.Cells[i, j].Value != null)
                            {
                                excelData.Add(worksheet.Cells[i, j].Value.ToString());
                            }
                        }
                    }
                }

                return excelData;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
