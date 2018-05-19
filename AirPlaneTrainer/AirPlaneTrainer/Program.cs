using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AirPlaneTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            AirPlane plane = AirPlane.GetInstance();
            Dispatcher dispatcher = new Dispatcher();
            Menu menu = new Menu();
            while(true)
            {
                switch (menu.ShowMenu())
                {
                    case 0:
                        if (plane.StartFligth())
                        { 
                            do
                            {
                                try
                                {
                                    plane.PlaneControl();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                            } while (!plane.IsLanding);
                            plane.SuccsessEndOfFly();
                        }
                        break;
                    case 1:
                        Console.WriteLine("Enter the name of the dispatcher for adding:");
                        string name = Console.ReadLine();
                        plane.AddDispatcher(new Dispatcher(name));
                        while (plane.Count < 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the name of the dispatcher for adding:");
                            name = Console.ReadLine();
                            plane.AddDispatcher(new Dispatcher(name));
                        }
                        break;
                    case 2:
                        if (plane.Count > 2)
                        {
                            Console.WriteLine("Enter the name of the dispatcher for removing:");
                            string Src_name = Console.ReadLine();
                            plane.DeleteDispatcher(Src_name);
                        }
                        else Console.WriteLine("You can not delete the dispatcher!");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}