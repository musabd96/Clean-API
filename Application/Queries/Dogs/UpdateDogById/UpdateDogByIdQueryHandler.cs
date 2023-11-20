using Domain.Modulea;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.UpdateDogById
{
    internal class UpdateDogByIdQueryHandler : IRequestHandler<UpdateDogByIdQuery, Dog>
    {
        private readonly MockDatabase _mockDatabase;

        public UpdateDogByIdQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Dog> Handle(UpdateDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog existingDog = _mockDatabase.allDogs.Where(Dog => Dog.animalId == request.Id).FirstOrDefault()!;
            if (existingDog == null)
            {
                throw new NotFiniteNumberException($"Dog with ID {request.Id} not found.");
            }

            existingDog.Name = request.Name;


            return Task.FromResult(existingDog);
        }
    }
}
