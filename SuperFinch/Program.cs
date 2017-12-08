using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

namespace SuperFinch
{
    class Program
    {
        static void Main(string[] args)
        {
            //**********************************************
            // Application: CIT 110 Exam 2
            // Author: Kazi Arafat 
            // Date: 11/19/2017
            // Level of Solution (1, 2, or 3): 1
            //**********************************************

      
            Finch freddy = new Finch();
            freddy.connect();
            

            Console.WriteLine("Welcome to Super Finch!");
            Console.WriteLine("SuperFinch, the superhero, is going into battle.");
            Console.WriteLine("She will encounter both lasers and freeze rays.");

            Console.WriteLine();

            Console.Write("Please enter the shield level for Super Finch.");
            int result;

            if (int.TryParse(Console.ReadLine(), out result))

            {

                if (result == 1)
                {
                    Console.WriteLine("SuperFinch is moving forward into battle!");

                    freddy.setMotors(100, 100);
                   

                }

                else if (result == 2)
                {
                    Console.WriteLine("Super Finch is moving forward into battle!");

                    freddy.setMotors(100, 100);
                }

                else if (result == 3)
                {

                    Console.WriteLine("Super Finch is moving forward into battle!");

                    freddy.setMotors(100, 100);
                }

                else
                    Console.WriteLine("Sorry, Invalid shield level value. Unable to continue.                                                                  Game over!");




            }

            else
                Console.WriteLine("Sorry, Invalid shield level value. Unable to continue.                                                                  Game over!");
                Console.Read();
                
            


        }
    }
}
