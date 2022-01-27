using AutoMapper;
using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExcelWeb.WebUI.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;

        public ExcelController(IMapper mapper, IFileService excelService)
        {
            _mapper = mapper;
            _fileService = excelService;
        }

        [HttpGet]
        public IActionResult AddFormData()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFormData(ExcelFileViewModel viewModel)
        {
            var inputModel = _mapper.Map<InputExcelFile>(viewModel);
            var response = await _fileService.ConvertAsync(inputModel);
            return View();
        }
    }
}
