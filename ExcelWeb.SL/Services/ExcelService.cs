using ExcelWeb.SL.Interfaces;
using ExcelWeb.SL.Models;
using System.Threading.Tasks;

namespace ExcelWeb.SL.Services
{
    public class ExcelService : IExcelService
    {
        public Task<OutputExcelFile> ConvertAsync(InputExcelFile inputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
