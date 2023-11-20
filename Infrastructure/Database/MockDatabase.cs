using Domain.Modulea;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List<Dog> allDogs 
        {
            get { return allDogsFromMockDatabase; } 
            set { allDogsFromMockDatabase = value; }
        }
        private static List<Dog> allDogsFromMockDatabase = new()
        {
           new Dog
           {
               animalId = Guid.NewGuid(), Name = "PeppeLeDog"
           },
           
            new Dog
           {
               animalId = Guid.NewGuid(), Name = "Nemo"
           },
            
            new Dog
           {
               animalId = Guid.NewGuid(), Name = "Amanda"
           },
            
            new Dog
           {
               animalId = Guid.NewGuid(), Name = "Filip"
           },
        };
    }
}
