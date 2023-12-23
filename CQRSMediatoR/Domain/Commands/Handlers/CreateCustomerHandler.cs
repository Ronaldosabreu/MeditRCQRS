using CQRSMediatoR.Domain.Commands.Responses;
using CQRSMediatoR.Domain.Commands.Requests;
using System;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace CQRSMediatoR.Domain.Commands.Handlers
{
  public class CreateCustomerHandler:
    IRequestHandler<CreateCustomersRequests , CreateCustomersResponse>
  {

    public Task<CreateCustomersResponse> Handle(CreateCustomersRequests request, CancellationToken cancellationToken)
    {
      //verica se o cliente ja esta cadastrado
      //valuda os dados
      //insere o cliente
      //envia email de boas vindas

      //retorna os dados
      var result =  new CreateCustomersResponse
      {
        Id = Guid.NewGuid(),
        Name = "Ronaldo Abreu",
        Email = "Ronaldosoares.a@gmail.com",
        Date = DateTime.Now

      };

      return Task.FromResult(result);
    }
  }
}
