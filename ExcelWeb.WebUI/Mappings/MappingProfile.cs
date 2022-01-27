using AutoMapper;
using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.SL.Models.InputModels;
using ExcelWeb.SL.Models.OutputModels;
using ExcelWeb.WebUI.ViewModels;

namespace ExcelWeb.WebUI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExcelFileViewModel, InputExcelFile>();
            CreateMap<InputForm, OutputForm>();
        }
    }
}
