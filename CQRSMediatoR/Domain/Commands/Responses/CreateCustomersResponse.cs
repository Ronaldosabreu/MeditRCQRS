using System;

namespace CQRSMediatoR.Domain.Commands.Responses
{
  public class CreateCustomersResponse
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime Date { get; set; }
  }
}
