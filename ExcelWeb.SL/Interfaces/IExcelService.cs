using ExcelWeb.SL.Models.Common;
using OfficeOpenXml;
using System.Collections.Generic;

namespace ExcelWeb.SL.Interfaces
{
    public interface IExcelService
    {
        ExcelPackage GetExcelFile(byte[] fileData);
        ExcelWorksheet GetExcelWorksheet(ExcelPackage excelFilePackage, string worksheetName);
        List<Questionnaire> LoopExcel(byte[] fileData);
    }
}
