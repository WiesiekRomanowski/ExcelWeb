using ExcelWeb.SL.Models.FileModels;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ExcelWeb.SL.Interfaces
{
    public interface IFileService
    {
        Task<OutputExcelFile> ConvertAsync(InputExcelFile inputModel);
        byte[] GetFileData(IFormFile file);
    }
}
