using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Model.Exercises
{
    public class CoreEx : Exercise
    {
        private int id;
        private string name;
        private int[] weights; //Sets of 20,30,40,50

        public CoreEx(int id, string name, int[] weights)
        {
            
            this.id = id;
            this.name = name;
            this.weights = weights;

        }

        public void DisplayInfo()
        {

            Console.WriteLine();
            Console.WriteLine($"Id: {id}.");
            Console.WriteLine($"Name: {name}.");
            Console.WriteLine($"Weights: {weights[0]},{weights[1]},{weights[2]},{weights[3]}.");
            Console.WriteLine();

        }

    }
}
