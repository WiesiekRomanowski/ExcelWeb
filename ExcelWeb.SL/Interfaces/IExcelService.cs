using ExcelWeb.SL.Models.Common;
using OfficeOpenXml;
using System.Collections.Generic;

namespace ExcelWeb.SL.Interfaces
{
    public interface IExcelService
    {
        List<Questionnaire> LoopInputExcel(byte[] fileData);
        byte[] LoopOutputExcel(List<Questionnaire> questionnaries);
    }
}
