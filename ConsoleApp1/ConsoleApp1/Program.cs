using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capacity");
            int capaCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Count");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("IsAuto");
            bool IsAuto = Convert.ToBoolean(Console.ReadLine());
            Weapon weapon = new Weapon(capaCapacity, Count, IsAuto);
            int check = 0;
            do
            {
                Console.WriteLine("0   informasya almaq");
                Console.WriteLine("1   shoot method");
                Console.WriteLine("2   Fire method");
                Console.WriteLine("3   GetRaminBulletCount");
                Console.WriteLine("4   Relod method");
                Console.WriteLine("5   ChangeFireMode");
                Console.WriteLine("6   exit");
                 check = Convert.ToInt32(Console.ReadLine());


                switch (check)
                {
                    case 0:
                        weapon.Getinfo();
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        weapon.GetRemainBullentCount();
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("END");
                        break;
                    default:
                        Console.WriteLine("Entered incorrectly");
                        break;

                }

            } while (check != 6);

        }
    }
}
