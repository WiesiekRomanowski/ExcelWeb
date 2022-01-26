using AutoMapper;
using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models;
using ExcelWeb.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExcelWeb.WebUI.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IExcelService _excelService;

        public ExcelController(IMapper mapper, IExcelService excelService)
        {
            _mapper = mapper;
            _excelService = excelService;
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
            var response = await _excelService.ConvertAsync(inputModel);
            return View(response);
        }
    }
}
