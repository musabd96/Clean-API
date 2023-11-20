using Domain.Modulea;
using MediatR;

namespace Application.Queries.Dogs.GetDogById
{
    public class GetDogByIdQuery : IRequest<Dog>
    {
        public GetDogByIdQuery(Guid dogId) 
        { 
            Id = dogId;
        }

        public Guid Id { get; set; }
    }
}
