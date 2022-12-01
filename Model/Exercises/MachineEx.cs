using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Model.Exercises
{
    public class MachineEx : Exercise
    {
        public int id;
        public string flexor;
        public string extensor;
        public int[] weights = new int[4];
        public MachineEx(JToken tok)
        {
            id = (int)tok["ID"];
            flexor = (string)tok["Flexor Exercise"];
            extensor = (string)tok["Extensor Exercise"];
            for (int i = 0; i < 4; i++)
            { weights[i] = (int)tok["Weights"][i]; }
        }

        public MachineEx(int id, string flexor, string extensor, int[] weights)
        {
            this.id = id;
            this.flexor = flexor;
            this.extensor = extensor;
            this.weights = weights;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Id: {id}.");
            Console.WriteLine($"Flexor Exercise: {flexor}.");
            Console.WriteLine($"Extensor Exercise: {extensor}.");
            Console.WriteLine($"Weights: {weights[0]},{weights[1]},{weights[2]},{weights[3]}.");
            Console.WriteLine();

        }


    }
}
