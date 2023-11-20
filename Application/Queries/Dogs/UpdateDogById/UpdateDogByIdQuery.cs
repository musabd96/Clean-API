using Domain.Modulea;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.UpdateDogById
{
    public class UpdateDogByIdQuery : IRequest<Dog>
    {
        public UpdateDogByIdQuery(Guid dogId, string name)
        {
            Id = dogId;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
