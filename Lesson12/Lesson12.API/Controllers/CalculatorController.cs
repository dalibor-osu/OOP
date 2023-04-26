using Lesson12.API.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace Lesson12.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost(Name = "Calculate")]
        public decimal Post([FromBody] CalcDTO calcDTO)
        {
            switch (calcDTO.Operation)
            {
                case "plus":
                    return calcDTO.Operand1 + calcDTO.Operand2;
                case "minus":
                    return calcDTO.Operand1 - calcDTO.Operand2;
                case "deleno":
                    return calcDTO.Operand1 / calcDTO.Operand2;
                default:
                    return calcDTO.Operand1 * calcDTO.Operand2;
            }
        }

    }
}
