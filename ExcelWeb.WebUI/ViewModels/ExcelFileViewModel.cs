using Microsoft.AspNetCore.Http;

namespace ExcelWeb.WebUI.ViewModels
{
    public class ExcelFileViewModel
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}
