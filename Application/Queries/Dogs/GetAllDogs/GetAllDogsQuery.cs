using MediatR;
using Domain.Modulea;

namespace Application.Queries.Dogs.GetAllDogs
{
    public class GetAllDogsQuery : IRequest<List<Dog>>
    {

    }
}
