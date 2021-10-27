using System.Collections.Generic;

namespace csharp_refactor.Model
{
    public class Study
    {
        public string StudyName { get; set; }

        public int StudyNumber { get; set; }

        public List<Animal> StudyAnimals { get; set; }

        public List<AnimalData> AnimalDataList { get; set; }
    }
}