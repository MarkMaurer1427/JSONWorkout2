using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Model.Exercises
{
    public class Cardio : Exercise
    {
        private int id;
        private string name;
        private int time;

        public Cardio(int id,string name, int time)
        {

            this.id = id;
            this.name = name;
            this.time = time;
            
        }
        public void DisplayInfo()
        {

            Console.WriteLine();
            Console.WriteLine($"Id: {id}.");
            Console.WriteLine($"Name: {name}.");
            Console.WriteLine($"Time: {time} minutes.");
            Console.WriteLine();

        }
    }
}
