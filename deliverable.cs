using System;





class User
{
    public string varName { get; set; }
    public int varGrade { get; set; }
    public string varHIlo { get; set; }

    public bool IsAdult() => varGrade >= 18;

    //This defines the the structure for our list first part being the name then the grade
    public User(string name, int grade, string HIlo)
    {
        varName = name;
        varGrade = grade;
        varHIlo = HIlo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Deliverable one . Year two, WS330240!");


        // This is a c# list
        List<User> users = new List<User>();

        users.Add(new User("Bob", 57, "H"));
        users.Add(new User("Alice", 55, "L"));

        int i = 0;
        while (i < 1)
        {
            //display text to user  
            Console.WriteLine("------------- MAIN MENU ------------");
            Console.WriteLine("---------- Grade Calculator ----------");
            Console.WriteLine("1) Add a student");//option 1
            Console.WriteLine("2) View my account Grades");
            Console.WriteLine("3) Satistics");
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

                Console.WriteLine("Did they undergo and low or high grade test. HIGH(H) or LOW(L)");
                string test = Console.ReadLine();

                users.Add(new User(name, amount, test));





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
                    Console.WriteLine(student.varName + " - " + student.varGrade + student.varHIlo);
                    int y = (student.varGrade);
                    string type = student.varHIlo;


                    // testing purposes Console.WriteLine(y);
                    //testing purposes prints higher or lower band (Console.WriteLine(type);)


                    //higher band 
                    if (type == "H" || type == "HIGH" || type == "h" || type == "high")
                    {
                        if (y >= 91)
                        {
                            Console.WriteLine("You have passed  - A* ( Higher band test )");
                        }
                        else if (y >= 81)
                        {

                            Console.WriteLine("You have passed - A ( Higher band test )");
                        }
                        else if (y >= 71)
                        {
                            Console.WriteLine("You have passed - B ( Higher band test )");
                        }
                        else if (y >= 61)
                        {
                            Console.WriteLine("You have passed - C ( Higher band test )");
                        }
                        else if (y >= 51)
                        {
                            Console.WriteLine(" Grade - D ( Higher band test )");
                        }
                        else if (y >= 31)
                        {
                            Console.WriteLine(" Grade - E ( Higher band test )");

                        }
                        else if (y >= 11)
                        {
                            Console.WriteLine("Grade - F ( Higher band test )");
                        }
                        else if (y >= 0)
                        {
                            Console.WriteLine("ungraded");
                        }


                    }// Lower garde Results 
                    else if (type == "L" || type == "low" || type == "l" || type == "LOW")
                    {
                        if (y >= 100)//invlaid 
                        {
                            Console.WriteLine("NA INVALID ENTRY ERROR CODE 1");
                        }
                        else if (y >= 91)// B
                        {

                            Console.WriteLine("You have passed - B( Lower band )");
                        }
                        else if (y >= 81)
                        {
                            Console.WriteLine("You have passed - C ( Lower band test )");
                        }
                        else if (y >= 61)
                        {
                            Console.WriteLine("You have passed - D ( Lower band test )");
                        }
                        else if (y >= 41)
                        {
                            Console.WriteLine(" Grade - E ( Lower band )");
                        }
                        else if (y >= 21)
                        {
                            Console.WriteLine(" Grade - F ( Lower band )");

                        }
                        else if (y >= 0)
                        {
                            Console.WriteLine("Grade - undergarded ( HLower band )");
                        }

                    }

                }

            }









            else if (option == "3")
            {

                //Totla number of users
                int total = users.Count();
                Console.WriteLine("There are "+ "  " + total + "  " + "students");

                //average grade
                double avgGrade = users.Average(x => x.varGrade);
                Console.WriteLine("The average grade is " + avgGrade);

                //leaderboard
                var leaderbaord = users.OrderByDescending(x => x.varGrade);


                Console.WriteLine("---------- Leaderboard ---------");
                int y =1;
                foreach(var user in leaderbaord) {
                    Console.WriteLine(y + " " + user.varName + " " + user.varGrade);
                    y++;
                        }
                
            }
            else if (option == "4")
            {
                i++;
            }
            else //error protection agaist invalid inputs such as "jack"
            {
                Console.WriteLine("");
            }
        }

    }
}