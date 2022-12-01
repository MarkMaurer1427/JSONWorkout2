using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Model.Exercises
{
    public class FreeEx : Exercise

    {
        private int id;
        private string name;
        private int[] weights = new int[4];
        public FreeEx(JToken tok)
        {
            name = (string)tok["Name"];
            for (int i = 0; i < 4; i++)
            { weights[i] = (int)tok["Weights"][i]; }
        }

        public FreeEx(int id, string name, int[] weights)
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
