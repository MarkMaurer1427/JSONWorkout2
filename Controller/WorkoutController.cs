using JSONWorkout2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Controller
{
    internal class WorkoutController
    {

        MenuView view;

        public WorkoutController(MenuView view)
        {
            this.view = view;
        }

        public void Run()
        {
            Boolean running = true;

            do
            {
                view.WorkoutMenu();

                int selection = 0;
                string input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5") selection = int.Parse(input);
                else Console.WriteLine("Wrong input.");

                switch (selection)
                {
                    case 1:
                        {
                            Console.WriteLine("Create workout");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Edit workout");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("delete workout");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("list workouts");
                            break;
                        }
                    case 5:
                        {
                            running = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("This shouldn't happen.");
                            break;
                        }
                }


            }
            while (running == true);
        }

    }
}
