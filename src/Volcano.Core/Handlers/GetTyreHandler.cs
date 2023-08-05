using MediatR;
using Microsoft.Extensions.Logging;
using Volcano.Core.Requests;

namespace Volcano.Core.Handlers;

public class GetTyreHandler : IRequestHandler<GetTyreRequest, int>
{
    private readonly ILogger<GetTyreHandler> _logger;
    
    public GetTyreHandler(ILogger<GetTyreHandler> logger)
    {
        _logger = logger;
    }
    
    public Task<int> Handle(GetTyreRequest request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Getting tyre with id {id}", request.TyreId);

        return Task.FromResult(request.TyreId);
    }
}