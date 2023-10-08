using System;





class User
{
    public string varName { get; set; }
    public int varGrade { get; set; }

    public bool IsAdult() => varGrade >= 18;

    //This defines the the structure for our list first part being the name then the grade
    public User(string name, int grade)
    {
        varName = name;
        varGrade = grade;
    }
}

     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deliverable one . Year two, WS330240!");


            // This is a c# list
            List<User> users = new List<User>();
          
            users.Add(new User("Bob", 57));
            users.Add(new User("Alice", 55));

            int i = 0;
            while (i < 1)
            {
                //display text to user  
                Console.WriteLine("------------- MAIN MENU ------------");
                Console.WriteLine("---------- Grade Calculator ----------");
                Console.WriteLine("1) Add a student");//option 1
                Console.WriteLine("2) View my account Grades");
                Console.WriteLine("3) One time grade check");
                Console.WriteLine("4) Exit ");
                Console.WriteLine("");//makes space in windows for user input 


                // user inputs 

                string option = Console.ReadLine();


                // option 1 - add a student to the list 
                if (option == "1")
                {
                Console.WriteLine("Name of student you'd like to add");
                string name = Console.ReadLine();


                Console.WriteLine("What is their grade");
                int amount = Convert.ToInt32(Console.ReadLine());

                users.Add(new User(name, amount));





                // adding an input to varible  "name" string name = Console.ReadLine();
                
                }

                /// Option 2  - view my student data 
                else if (option == "2")
                {


                Console.WriteLine("Please enter in the user you would like to see infomation for");
                Console.WriteLine("");
                string x = Console.ReadLine();
                

                //get all students whose name is Bill
                // This function will define u as a looking varible , it will look in the list for the user inputs row
                var result = from u in users
                             where u.varName == x// users input 
                             select u;
               



                foreach (var student in result)
                {
                    Console.WriteLine(student.varName + " - " + student.varGrade);
                    int y=(student.varGrade);


                    Console.WriteLine(y);

                    if(y >= 20)
                    {
                        Console.WriteLine("You have failed - Ungraded Lowerband");
                    }
                    else if (y >= 10)
                    {
                        Console.WriteLine("You have failed - Ungraded Higer" );
                    }
                }


                

         

                }
                else if (option == "3")
                {
                    Console.WriteLine("");
                    i++;
                }
                else if (option == "4")
                {
                //kills the program for the xit command (kil())
                System.Diagnostics.Process.GetCurrentProcess().Kill(true);
                Console.WriteLine("");
                }
                else //error protection agaist invalid inputs such as "jack"
                {
                    Console.WriteLine("");
                }
            }

        }
    }
