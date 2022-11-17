using JSONWorkout2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Controller
{
    public class ExController
    {
        private MenuView view;
        public ExController(MenuView view)
        {
            this.view = view;
        }

        public void Run()
        {
            Boolean running = true;

            do
            {
                view.ExerciseMenu();

                int selection = 0;
                string input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5") selection = int.Parse(input);
                else Console.WriteLine("Wrong input.");

                switch (selection)
                {
                    case 1:
                        {
                            Console.WriteLine("Create Exercise Set");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Edit Exercise Set");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("delete Exercise Set");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("list Exercise Sets");
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
