using Domain.Modulea;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.GetDogById
{
    internal class GetDogByIdQueryHabdler : IRequestHandler<GetDogByIdQuery, Dog>
    {
        private readonly MockDatabase _mockDatabase;

        public GetDogByIdQueryHabdler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Dog> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog wantedDag = _mockDatabase.allDogs.Where(Dog => Dog.animalId == request.Id).FirstOrDefault()!;
            return Task.FromResult(wantedDag);
        }
    }
}
