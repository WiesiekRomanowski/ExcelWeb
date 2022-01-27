using OfficeOpenXml;
using System.Collections.Generic;

namespace ExcelWeb.SL.Interfaces
{
    public interface IExcelService
    {
        ExcelPackage GetExcelFile(byte[] fileData);
        ExcelWorksheet GetExcelWorksheet(ExcelPackage excelFilePackage, string worksheetName);
        List<string> LoopExcel(byte[] fileData);
    }
}
