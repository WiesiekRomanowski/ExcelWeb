using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.SL.Models.InputModels;
using ExcelWeb.SL.Models.OutputModels;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExcelWeb.SL.Services
{
    public class FormService : IFormService
    {
        private readonly IExcelService _excelService;

        public FormService(IExcelService excelService)
        {
            _excelService = excelService;
        }

        private string[] _worksheetName = { "Sheet1" };

        private ExcelPackage _excelFile;
        private ExcelWorksheet _excelWorksheet;

        public InputForm GetInputFormData(ExcelFileModel fileModel)
        {
            try
            {
                SetExcelFile(fileModel.FileData);
                SetExcelWorksheet();

                var valA1 = _excelWorksheet.Cells["A1"].Value.ToString();
                var valI1 = _excelWorksheet.Cells["I1"].Value.ToString();
                var valI2 = _excelWorksheet.Cells["I2"].Value.ToString();
                var formatted = valI2.Split(';');

                return new InputForm();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OutputForm GetOutputFormData(InputForm inputForm)
        {
            try
            {
                return new OutputForm();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetExcelFile(byte[] fileData)
        {
            _excelFile = _excelService.GetExcelFile(fileData);
        }

        private void SetExcelWorksheet()
        {
            _excelWorksheet = _excelService.GetExcelWorksheet(_excelFile, _worksheetName[0]);
        }
    }
}
