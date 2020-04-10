using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to indicate what major stat they want, effective field goal percentage, or shooting percentage
            bool Continue = true;

            while (Continue)
            {
                Console.WriteLine("Press 1 for Shooting Percentage, or Press 2 for Effective Shotting Percentage");
                string stat = Console.ReadLine();

                //If they choose shooting percentage
                if (stat == "1")
                {
                    //Prompt them to enter if they want normal shooting percentage or just 3-point percentage
                    Console.WriteLine("Press 1 for Normal Shooting Percentage, or Press 2 for 3-Point Percentage");
                    string shot = Console.ReadLine();
                    //If they choose normal
                    if (shot == "1")
                    {
                        string input = "";
                        int shotsMade = 0;
                        int shotsAtt = 0;

                        //Prompt them to enter field goals attempted, and field goals made
                        Console.WriteLine("Enter the number of shots attempted");
                        input = Console.ReadLine();
                        shotsAtt = int.Parse(input);

                        Console.WriteLine("Enter the number of shots made");
                        input = Console.ReadLine();
                        shotsMade = int.Parse(input);
                        //Calculate the shooting percentage
                        BasketballStats stats = new BasketballStats();
                        decimal avg = stats.CalculateShootingPercentage(shotsMade, shotsAtt); 
                        //Write the shooting percentage to the console
                        Console.WriteLine("Shooting Percentage:" + avg);
                    }
                    //Else they choose 3-point
                    else if (shot == "2")
                    {
                        string input = "";
                        int threeAtt = 0;
                        int threeMade = 0;
                        //Prompt them to enter 3-point shots attempted, and 3-point shots made
                        Console.WriteLine("Enter the number 3-point shots attempted");
                        input = Console.ReadLine();
                        threeAtt = int.Parse(input);

                        Console.WriteLine("Enter the number of 3-point shots made");
                        input = Console.ReadLine();
                        threeMade = int.Parse(input);
                        //Calculate the 3-point percentage
                        //Write the 3-point percentage to the console
                        Console.WriteLine("3-Point Percentage:");
                    }   
                }
                //Else they choose effective field goal percentage
                else if (stat == "2")
                {
                    string input = "";
                    int shotsMade = 0;
                    int shotsAtt = 0;
                    int threeMade = 0;
                    //Prompt them to enter field goals made/attempted, and 3-point shots made
                    Console.WriteLine("Enter the number of shots attempted");
                    input = Console.ReadLine();
                    shotsAtt = int.Parse(input);

                    Console.WriteLine("Enter the number of shots made");
                    input = Console.ReadLine();
                    shotsMade = int.Parse(input);

                    Console.WriteLine("Enter the number of 3-point shots made");
                    input = Console.ReadLine();
                    threeMade = int.Parse(input);
                    //Calculate the effective field goal percentage
                    //Write the effective field goal percentage to the console
                    Console.WriteLine("Effective Field Goal Percentage:");
                }
                //Prompt the user to see if the want to calculate another stat
                Console.WriteLine("Do you want to calculate another stat? Type 'yes' or 'no'");
                String more = Console.ReadLine();
                //If yes, go back to the top
                if (more == "no")
                {
                    //Else no, end the program
                    Continue = false;
                }
                
            }
            Console.WriteLine("The program has ended");
        }
        
    }
}