using WebService.Controllers;
using WebService.Models;

namespace WebService.DataAccess
{
    public interface IDataAccessProvider
    {
        List<Catalumnocs> GetAlumnos();
    }
}
