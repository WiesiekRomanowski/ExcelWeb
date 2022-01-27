using Microsoft.AspNetCore.Http;

namespace ExcelWeb.SL.Models.FileModels
{
    public class InputExcelFile
    {
        public IFormFile File { get; set; }
    }
}
