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

        public void CreateExListBanner() 
        {
            Console.WriteLine();
            Console.WriteLine("**** Create New Exercise Set ****");
            Console.WriteLine();
        }

        public void CreateMachExBanner()
        {
            Console.WriteLine();
            Console.WriteLine("**** Create New Machine Exercise ****");
            Console.WriteLine();
        }

        public void CreateFreeExBanner()
        {
            Console.WriteLine();
            Console.WriteLine("**** Create Free Weight Exercise ****");
            Console.WriteLine();
        }

        public void ExTypeErrorMsg() { Console.WriteLine("Invalid type entered. Returning to type selection."); }
        public void InvalidMsg() { Console.WriteLine("Invalid input."); }

        public string GetString(string prompt)
        {
            
            Console.Write(prompt);
            return Console.ReadLine();

        }

        public void ExTypeMenu()
        {

            Console.WriteLine("Select Exercise Set Type.");
            Console.WriteLine("1. Machine Exercises");
            Console.WriteLine("2. Free Weight Exercises");
            Console.WriteLine("3. Core Exercises");
            Console.WriteLine("4. Cardio Exercises");
            Console.WriteLine();
        
        }


        public int GetInt(string prompt)
        {
            while(true)
            {
                try
                {

                    Console.Write(prompt);
                    return int.Parse(Console.ReadLine());

                }
                catch(Exception e) { Console.WriteLine("Wrong input.");}
                

            }

        }



    }
}
