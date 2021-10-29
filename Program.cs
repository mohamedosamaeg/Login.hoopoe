using System;

namespace Login.hoopoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName;
            string Password;
            Console.WriteLine("Hello my dear customer,we have to know your user name & password To Login to our Community :)" );
            Console.WriteLine("User name :");
            UserName = Console.ReadLine();
            Console.WriteLine("Password :");
            Password = Console.ReadLine();
            if (UserName == "mohamed" || UserName == "ahmed" || UserName == "reham" || UserName == "mona" )
            {
                if (Password == "hoopoe2021")
                {
                    Console.WriteLine("WELCOME :)" + UserName);
                }
                else
                { 
                    Console.WriteLine("Password are wrong"); 
                }
            }
            else
            {
                Console.WriteLine("Username are wrong");


            }
            


        }
    }
}
