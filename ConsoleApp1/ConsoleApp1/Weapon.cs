using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Weapon
    {
        public static int Capacity { get; set; }
        public static int Count { get; set; }
        public static bool IsAuto { get; set; }


        public Weapon(int capacity, int count, bool isauto)
        {
            Capacity = capacity;
            Count = count;
            IsAuto = isauto;
        }



        public void Shoot()
        {
            if (IsAuto == false)
            {
                Count = Count - 1;
            }
            Console.WriteLine(Count);

        }

        public void Fire()
        {
            if (IsAuto == true)
            {
                for (int i = 0; i < Count; i--)
                {
                    if (Count > 0)
                    {
                        Count--;
                        Console.WriteLine(Count);
                    }
                }
            }
        }


        public int GetRemainBullentCount()
        {
            return Capacity - Count;
        }


        public void Reload()
        {
            Console.WriteLine(Capacity = Count + GetRemainBullentCount());
        }


        public void ChangeFireMode()
        {
            if (IsAuto == false)
            {
                Shoot();
            }
            else if (IsAuto == true)
            {
                Fire();
            }
         

        }
        public void Getinfo()
        {
            Console.WriteLine("1 Shoot ");
            Console.WriteLine("2 Fire ");
            Console.WriteLine("3 GetRemainBulletCount ");
            Console.WriteLine("4 Reload ");
            Console.WriteLine("5 ChangeFireMode");

        }
    }
}
