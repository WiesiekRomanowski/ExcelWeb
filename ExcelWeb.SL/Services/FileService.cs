using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.FileModels;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ExcelWeb.SL.Services
{
    public class FileService : IFileService
    {
        private readonly IFormService _formService;

        public FileService(IFormService formService)
        {
            _formService = formService;
        }

        public byte[] ConvertAsync(InputExcelFile inputModel)
        {
            try
            {
                var fileModel = new ExcelFileModel
                {
                    FileData = GetFileData(inputModel.File),
                    FileName = inputModel.File.FileName
                };

                var inputExcel = _formService.GetInputFormData(fileModel);
                var outputExcel = _formService.GetOutputFormData(inputExcel);

                var excelFile = _formService.GetOutputExcelFile(inputExcel);

                return excelFile;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public byte[] GetFileData(IFormFile file)
        {
            byte[] data;
            using (var inputStream = file.OpenReadStream())
            {
                if (!(inputStream is MemoryStream memoryStream))
                {
                    memoryStream = new MemoryStream();
                    inputStream.CopyTo(memoryStream);
                }
                data = memoryStream.ToArray();
            }

            return data;
        }
    }
}
