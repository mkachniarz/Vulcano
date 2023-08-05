using MediatR;

namespace Volcano.Core.Requests;

public class GetTireRequest : IRequest<int>
{
    public int TireId { get; private set; }
    
    public GetTireRequest(int id) 
        => TireId = id;
}