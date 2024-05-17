using Microsoft.AspNetCore.Mvc;
using WebService.DataAccess;
using WebService.Models;
using System.Collections.Generic;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CatalumnoController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Catalumnocs>> Get()
        {
            return _dataAccessProvider.GetAlumnos();
        }
    }
}
