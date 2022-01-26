using Microsoft.AspNetCore.Http;

namespace ExcelWeb.SL.Models
{
    public class InputExcelFile
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}
