using MediatR;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommand : IRequest<Unit>
    {
        public FinishProjectCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public string CreditCardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiresAt { get; set; }
        public string FullName { get; set; }
    }
}