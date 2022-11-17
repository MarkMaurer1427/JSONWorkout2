using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.View
{
    public class MenuView
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome to Mark's Workout Generator 2.0");
            Console.WriteLine("Please make a selection.");
            Console.WriteLine("1. Exercise Set Editor.");
            Console.WriteLine("2. Workout Template Editor.");
            Console.WriteLine("3. Workout Generator.");
            Console.WriteLine("4. Exit.");

            Console.WriteLine("Enter selection: ");
        }

        public void WorkoutMenu()
        {
            Console.WriteLine("Workout Editor");
            Console.WriteLine("Please make a selection.");
            Console.WriteLine("1. Create Workout.");
            Console.WriteLine("2. Edit Workout.");
            Console.WriteLine("3. Delete Workout.");
            Console.WriteLine("4. List Workouts.");
            Console.WriteLine("5. Exit.");

            Console.WriteLine("Enter selection: ");
        }

        public void ExerciseMenu()
        {
            Console.WriteLine("Exercise Editor");
            Console.WriteLine("Please make a selection.");
            Console.WriteLine("1. Create Exercise Set.");
            Console.WriteLine("2. Edit Exercise Set.");
            Console.WriteLine("3. Delete Exercise Set.");
            Console.WriteLine("4. List Exercise Set.");
            Console.WriteLine("5. Exit.");

            Console.WriteLine("Enter selection: ");
        }
    }
}
