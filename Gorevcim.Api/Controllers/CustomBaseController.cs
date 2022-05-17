using Gorevcim.Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {

        //metot tanılaması yapıyoruz
        //Geriye Iactionresult dönsün
        //CreateActinresult oluşturulsn diğer productControllerlarımı implement 
        //t data dönebilir genel olarakta customResponse alsın 
        //Aşagıdaki tanımlamada endpoint olmadığı iin no action
       [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        
        }
    }
}
