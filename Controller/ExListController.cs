using JSONWorkout2.Model.Exercises;
using JSONWorkout2.Model.Repo;
using JSONWorkout2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWorkout2.Controller
{
    public class ExListController
    {
        private MenuView view;
        
        public ExListController(MenuView view)
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
                            CreateEx();
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

        private void CreateEx()
        { 
        
            view.CreateExListBanner();
            string newName = view.GetString("Enter New Exercise Set Name: ");
            string newType = "";
            int currentId = 0;

        view.ExTypeMenu();

            Boolean haveType = false;
            while (haveType == false) 
            {

                int type = 0;
                type = view.GetInt("Enter Type Selection: ");
                switch(type)
                {
                    case 1 :
                        {
                            newType = "Machine";
                            haveType = true;
                            break;
                        }
                    case 2 :
                        {
                            newType = "Free";
                            haveType = true;
                            break;
                        }
                    case 3:
                        {
                            newType = "Core";
                            haveType = true;
                            break;
                        }
                    case 4:
                        {
                            newType = "Cardio";
                            haveType = true;
                            break;
                        }
                    default:
                        { 
                        
                            view.ExTypeErrorMsg();
                            break;

                        }
                }

            }

            ExList exList = new ExList(newName, newType);

            Boolean makeEx = true;
            while(makeEx == true)
            {

                switch (exList.GetListType())
                {
                    case "Machine":
                        {
                            exList.AddEx(CreateMachineEx(exList.GetID()));
                            break;
                        }

                    case "Free":
                        {
                            exList.AddEx(CreateFreeEx(exList.GetID()));
                            break;
                        }
                    case "Core":
                        {

                            exList.AddEx(CreateCoreEx(exList.GetID()));
                            break;
                        }
                    case "Cardio":
                        {
                            exList.AddEx(CreateCardioEx(exList.GetID()));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("This shouldn't happen.");
                            makeEx = false;
                            break;
                        }

                }
                
                exList.IdAdd();
                Boolean keepGoing = true;
                while (keepGoing == true)
                {
                    string cont = view.GetString("Make another exercise? Y/N: ").ToLower();
                    if (cont == "y") { break; }
                    else if (cont == "n") { keepGoing = false; makeEx = false; break; }
                    else view.InvalidMsg();

                }
                    
            }

            Console.WriteLine();
            Console.WriteLine("Test output");
            Console.WriteLine($"List name: {exList.GetListName()}. List Type: {exList.GetListType()}.");
            Console.WriteLine("Exercises:");
            exList.ListExercises();

        }

        public MachineEx CreateMachineEx(int id)
        {

            view.CreateMachExBanner();
            int newId = id;
            string flexor = view.GetString("Enter name of flexor exercise: ");
            string extensor = view.GetString("Enter name of extensor exercise: ");
            int repSix = view.GetInt("Enter weight for set of 6 reps: ");
            int repEight = view.GetInt("Enter weight for set of 8 reps: ");
            int repTen = view.GetInt("Enter weight for set of 10 reps: ");
            int repTwelve = view.GetInt("Enter weight for set of 12 reps: ");

            int[] weights = new int[]{repSix,repEight,repTen,repTwelve};

            MachineEx newEx = new MachineEx(id, flexor, extensor, weights);

            return newEx;
        }

        public FreeEx CreateFreeEx(int id)
        { 
            view.CreateFreeExBanner();
            int newId = id;
            string name = view.GetString("Enter name for new exercise: ");
            int repSix = view.GetInt("Enter weight for set of 6 reps: ");
            int repEight = view.GetInt("Enter weight for set of 8 reps: ");
            int repTen = view.GetInt("Enter weight for set of 10 reps: ");
            int repTwelve = view.GetInt("Enter weight for set of 12 reps: ");

            int[] weights = new int[] { repSix, repEight, repTen, repTwelve };

            FreeEx ex = new FreeEx(id, name, weights);
            
            return ex;
        }

        public CoreEx CreateCoreEx(int id)
        { 
        
            int newId = id;
            string name = view.GetString("Enter name for new exercise: ");
            int rep20 = view.GetInt("Enter weight for set of 20 reps: ");
            int rep30 = view.GetInt("Enter weight for set of 30 reps: ");
            int rep40 = view.GetInt("Enter weight for set of 40 reps: ");
            int rep50 = view.GetInt("Enter weight for set of 50 reps: ");
            int[] weights = new int[] {rep20,rep30, rep40, rep50};

            CoreEx ex = new CoreEx(newId,name, weights);
            return ex;

        }

        public Cardio CreateCardioEx(int id) 
        {
            int newId = id;
            string name = view.GetString("Enter name for new exercise: ");
            int time = view.GetInt("Enter time for new exercise in minutes: ");

            Cardio ex = new Cardio(newId,name,time);
            return ex;
        }


    }
}
