using JSONWorkout2.View;

namespace JSONWorkout2.Controller
{
    internal class MainMenu
    {
        public MainMenu(MenuView view)
        {
            this.View = view;
        }

        public MenuView View { get; private set; }

        public void Run()
        {
            ExController exController = new ExController(View);
            WorkoutController workoutController = new WorkoutController(View);
            WorkoutGen workoutGen = new WorkoutGen();

            Boolean running = true;
            int selection = 0;
            do 
            {
                View.MainMenu();
                string input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3" || input == "4") selection = int.Parse(input);
                else Console.WriteLine("Wrong input.");

                switch (selection)
                {
                    case 1:
                    {
                        exController.Run();
                        break;
                    }

                    case 2:
                    {
                        workoutController.Run();
                        break;
                    }

                    case 3:
                    {
                        workoutGen.Run();
                        break;
                    }
                    case 4:
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
