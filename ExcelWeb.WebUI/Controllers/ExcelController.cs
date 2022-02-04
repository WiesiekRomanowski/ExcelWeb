using AutoMapper;
using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult AddFormData(ExcelFileViewModel viewModel)
        {
            if (viewModel.File == null)
            {
                return View();
            }

            var inputModel = _mapper.Map<InputExcelFile>(viewModel);
            var outputModel = _fileService.Convert(inputModel);

            return File(outputModel, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Ankieta.xlsx");
        }
    }
}
