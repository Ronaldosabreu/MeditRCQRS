using CQRSMediatoR.Domain.Commands.Responses;
using MediatR;

namespace CQRSMediatoR.Domain.Commands.Requests
{
  public class CreateCustomersRequests: IRequest<CreateCustomersResponse>
  {
    public string Name { get; set; }
    public string Email { get; set; }
  }
}
