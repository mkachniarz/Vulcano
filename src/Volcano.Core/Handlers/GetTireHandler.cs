using MediatR;
using Microsoft.Extensions.Logging;
using Volcano.Core.Requests;

namespace Volcano.Core.Handlers;

public class GetTireHandler : IRequestHandler<GetTireRequest, int>
{
    private readonly ILogger<GetTireHandler> _logger;

    public GetTireHandler(ILogger<GetTireHandler> logger)
    {
        _logger = logger;
    }

    public Task<int> Handle(GetTireRequest request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Getting tire with id {id}", request.TireId);

        return Task.FromResult(request.TireId);
    }
}