using AutoMapper;
using ExcelWeb.SL.Models;
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
