using ExcelWeb.SL.Models.FileModels;
using Microsoft.AspNetCore.Http;

namespace ExcelWeb.SL.Interfaces
{
    public interface IFileService
    {
        byte[] ConvertAsync(InputExcelFile inputModel);
        byte[] GetFileData(IFormFile file);
    }
}
