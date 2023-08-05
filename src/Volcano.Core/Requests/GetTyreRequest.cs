using MediatR;

namespace Volcano.Core.Requests;

public class GetTyreRequest : IRequest<int>
{
    public int TyreId { get; private set; }
    
    public GetTyreRequest(int id) 
        => TyreId = id;
}