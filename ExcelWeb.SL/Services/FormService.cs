using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.SL.Models.InputModels;
using ExcelWeb.SL.Models.OutputModels;
using OfficeOpenXml;
using System;

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
        private InputForm _inputForm;

        public InputForm GetInputFormData(ExcelFileModel fileModel)
        {
            try
            {
                //SetExcelFile(fileModel.FileData);
                //SetExcelWorksheet();
                SetInputForm(fileModel.FileData);

                return _inputForm;
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

        private void SetInputForm(byte[] fileData)
        {
            _inputForm = new InputForm
            {
                Questionnaries = _excelService.LoopExcel(fileData)
            };
        }

        //TODO: tymczasowo na inputForm
        public byte[] GetOutputExcelFile(InputForm inputForm)
        {
            using var excelPackage = new ExcelPackage();
            var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            worksheet.Cells["A1"].LoadFromCollection(inputForm.Questionnaries, true);
            return excelPackage.GetAsByteArray();
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
