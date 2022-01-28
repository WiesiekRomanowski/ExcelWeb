using AutoMapper;
using ExcelWeb.SL.Models.FileModels;
using ExcelWeb.WebUI.ViewModels;

namespace ExcelWeb.WebUI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExcelFileViewModel, InputExcelFile>();
        }
    }
}
