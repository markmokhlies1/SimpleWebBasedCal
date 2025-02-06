using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCalcorator.Model;
using SimpleCalcorator.Services;
using System.Linq.Expressions;

namespace SimpleCalcorator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalController : ControllerBase
    {
        private ICalService _calService;
        public CalController(ICalService calService)
        {
            _calService = calService;
        }
        [HttpPost]
        [Route("Calculate")]
        public string Calculate( Expression01 expression01)
        {
            double ope1 = Convert.ToDouble(expression01.Operand1);
            char ope =Convert.ToChar(expression01.Operator);
            double ope2 = Convert.ToDouble(expression01.Operand2);
            return _calService.CalResult(ope1,ope,ope2);
        }
    }
}
