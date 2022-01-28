using ExcelWeb.SL.Models.FileModels;
using Microsoft.AspNetCore.Http;

namespace ExcelWeb.SL.Interfaces
{
    public interface IFileService
    {
        byte[] Convert(InputExcelFile inputModel);
        byte[] GetFileData(IFormFile file);
    }
}
