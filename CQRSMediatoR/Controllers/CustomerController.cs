using CQRSMediatoR.Domain.Commands.Handlers;
using CQRSMediatoR.Domain.Commands.Requests;
using CQRSMediatoR.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSMediatoR.Controllers
{
  [ApiController]
  [Route("v1/customers")]
  public class CustomerController : ControllerBase
  {

    [HttpPost]
    [Route("")]
    public Task<CreateCustomersResponse> Create(
                          [FromServices]IMediator mediator,
                          [FromBody] CreateCustomersRequests command) 
    {
      return mediator.Send(command);
    }


  }
}
