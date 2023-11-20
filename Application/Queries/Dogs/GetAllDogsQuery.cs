using MediatR;
using Domain.Modulea;

namespace Application.Queries.Dogs
{
    public class GetAllDogsQuery : IRequest<List<Dog>>
    {

    }
}
