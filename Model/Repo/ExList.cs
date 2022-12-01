using JSONWorkout2.Model.Exercises;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Model.Repo
{
    internal class ExList
    {
        private string name;
        private string type;
        private int currentId;

        private List<Exercise> exercises= new List<Exercise>();

        public ExList(string name, string type)
        {
            this.name = name;
            this.type = type;
            this.currentId = 0;

        }

        public string GetListName() { return name; }
        public string GetListType() { return type; }
        public int GetID() { return currentId; }
        public void IdAdd() { currentId++; }
        public void AddEx(Exercise ex)
        {
            this.exercises.Add(ex);
        }

        public void ListExercises()
        {
            switch (type)
            {

                case "Machine":
                    {
                        foreach (MachineEx ex in exercises)
                        {
                            ex.DisplayInfo();
                        }
                        break;
                    }

                case "Free":
                    {
                        foreach (FreeEx ex in exercises)
                        {
                            ex.DisplayInfo();
                        }
                        break;
                    }
                case "Core":
                    {
                        foreach (CoreEx ex in exercises)
                        {
                            ex.DisplayInfo();
                        }
                        break;
                    }
                case "Cardio":
                    {
                        foreach (Cardio ex in exercises)
                        {
                            ex.DisplayInfo();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This shouldn't happen.");
                        break;
                    }


            }

        }

    }
}
