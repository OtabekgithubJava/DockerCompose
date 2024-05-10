using MediatR;

namespace Payment.Application.UseCases.Payment.Queries;

public class GetAllPaymentQueryHandler: IRequestHandler<Handlers.GetAllPaymentQueryHandler, List<SharedModels.SharedModels.Payment>>
{
    
    // private readonly IPaymentDbContext
    
    public async Task<List<SharedModels.SharedModels.Payment>> Handle(Handlers.GetAllPaymentQueryHandler request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}