using System.Collections.Generic;
using csharp_refactor.Model;

namespace csharp_refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int animalNumber = 1;

            Animal animal1 = new Animal
            {
                AnimalNumber = animalNumber,
                AnimalType = "Mouse",
                AnimalName = "Mickey"
            };

            animalNumber = animalNumber + 1;

            Animal animal2 = new Animal
            {
                AnimalNumber = animalNumber,
                AnimalType = "Mouse",
                AnimalName = "Minnie"
            };

            animalNumber = animalNumber + 1;

            Animal animal3 = new Animal
            {
                AnimalNumber = animalNumber,
                AnimalType = "Mouse",
                AnimalName = "Fievel"
            };

            animalNumber = animalNumber + 1;

            Animal animal4 = new Animal
            {
                AnimalNumber = animalNumber,
                AnimalType = "Mouse",
                AnimalName = "Speedy"
            };

            animalNumber = animalNumber + 1;


            Animal animal5 = new Animal
            {
                AnimalNumber = animalNumber,
                AnimalType = "Mouse",
                AnimalName = "Jerry"
            };

            List<Animal> forStudy1 = new List<Animal>();
            forStudy1.Add(animal1);
            forStudy1.Add(animal2);
            forStudy1.Add(animal5);

            List<Animal> forStudy2 = new List<Animal>();
            forStudy1.Add(animal3);

            List<Animal> forStudy3 = new List<Animal>();
            forStudy1.Add(animal1);
            forStudy1.Add(animal4);
            forStudy1.Add(animal5);

            List<Animal> forStudy4 = new List<Animal>();
            forStudy1.Add(animal1);
            forStudy1.Add(animal2);
            forStudy1.Add(animal4);
            forStudy1.Add(animal5);


            List<Study> studyList = new List<Study>
            {
                new Study {StudyName = "Study1", StudyNumber = 1, StudyAnimals = forStudy1},
                new Study {StudyName = "Study2", StudyNumber = 2, StudyAnimals = forStudy2},
                new Study {StudyName = "Study3", StudyNumber = 3, StudyAnimals = forStudy3},
                new Study {StudyName = "Study4", StudyNumber = 4, StudyAnimals = forStudy4}
            };

            DataReceiver dataReceiver = new DataReceiver(studyList);
        }
    }
}
