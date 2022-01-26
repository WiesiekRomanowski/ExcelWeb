using ExcelWeb.SL.Models;
using System.Threading.Tasks;

namespace ExcelWeb.SL.Interfaces
{
    public interface IExcelService
    {
        Task<OutputExcelFile> ConvertAsync(InputExcelFile inputModel);
    }
}
