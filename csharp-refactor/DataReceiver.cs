using System;
using System.Collections.Generic;
using csharp_refactor.Model;

namespace csharp_refactor
{
    public class DataReceiver
    {
        private List<Study> _studyList;

        public DataReceiver(List<Study> studyList)
        {
            _studyList = studyList;

            AnimalDataTestInput();
        }

        public void SetData(string studyName, int animalNumber, float? weight = null)
        {
            int studyNumber = 0;

            for (int i = 0; i < _studyList.Count; i++)
            {
                if (_studyList[i].StudyName.Equals(studyName))
                {
                    studyNumber = _studyList[i].StudyNumber;
                }
            }

            string status = "Normal";

            if (weight != null && weight >= 1 && weight <= 5)
            {
                status = "Underweight";
            }
            else if (weight != null && weight > 10 && weight <= 15)
            {
                status = "Overweight";
            }
            else if (weight != null && weight > 15)
            {
                status = "Obese";
            }
            else if (weight == null || weight == 0)
            {
                status = "Deceased";
            }

            AnimalData animalData = new AnimalData();
            animalData.StudyNumber = studyNumber;
            animalData.AnimalNumber = animalNumber;
            animalData.Weight = weight;
            animalData.Status = status;

            Study currentStudy = null;

            foreach (var study in _studyList)
            {
                if (study.StudyNumber == studyNumber)
                {
                    currentStudy = study;

                    if (currentStudy.AnimalDataList == null)
                    {
                        currentStudy.AnimalDataList = new List<AnimalData>();
                    }

                    currentStudy.AnimalDataList.Add(animalData);

                    break;
                }
            }
        }

        public void AnimalDataTestInput()
        {
            SetData("Study1", 1, 1.28f);
            SetData("Study1", 2, 5.75f);
            SetData("Study1", 5, 1.23f);

            SetData("Study2", 3, 0f);

            SetData("Study3", 1, 17.23f);
            SetData("Study3", 4, 3.21f);
            SetData("Study3", 5, 12.2f);

            SetData("Study4", 2, 5.25f);
            SetData("Study4", 3, 7.45f);
            SetData("Study4", 4, 5.76f);
            SetData("Study4", 5, 8.12f);


            foreach (var study in _studyList)
            {
                Console.WriteLine("\nStudy: " + study.StudyName);

                foreach (var animalData in study.AnimalDataList)
                {
                    Console.WriteLine("\tAnimal " + animalData.AnimalNumber + " Weight: " + animalData.Weight + " Status: " + animalData.Status);
                }
            }

            Console.ReadKey();
        }
    }
}