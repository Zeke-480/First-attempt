using System;



namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello from Business Incorporations!");
            Console.WriteLine("Please write down your name in the space below");
            string info = Console.ReadLine();
            Console.WriteLine("Greetings " + info);
            Console.WriteLine("How old are you?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So you are " + number + " years old?");
            string response = "let us proceed then";
            string response2 = "I must stop you now";
            string respone3 = "Welcome aboard";
            char symbol = '@';
            string dot = ".";
            



            if (number >= 18 )
            {
                Console.WriteLine(response);
                Console.WriteLine("Would you like to join our organization?");
                
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("Please input your email and contact number below.");
                    string email = Console.ReadLine();
                    if (email.Contains(symbol) && email.Contains(dot) && email.IndexOf(symbol) < email.LastIndexOf(dot) && email.IndexOf(symbol) > 0 && email.LastIndexOf(dot) < email.Length - 1)
                        
                    {
                        Console.WriteLine("Thank you for your email, now we require your contact number please.");
                        string contact = (Console.ReadLine());
                        if (contact.Length == 10)
                        {
                            Console.WriteLine(respone3);
                            Console.WriteLine("Thank you for your contact number, we will reach out to you soon.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid contact number. Please try again.");

                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Invalid email format. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Thank you for your time, have a nice day <3");
                }
            }
            else
            {
                Console.WriteLine(response2);
            }
            
    

        }
    }
}
