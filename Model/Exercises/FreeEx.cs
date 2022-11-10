using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Model.Exercises
{
    internal class FreeEx
    {
        public string name;
        public int[] weights = new int[4];
        public FreeEx(JToken tok)
        {
            name = (string)tok["Name"];
            for (int i = 0; i < 4; i++)
            { weights[i] = (int)tok["Weights"][i]; }
        }
    }
}
