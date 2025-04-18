using System;
using System.Collections.Generic;
using System.Linq;

namespace _01ChickenSnack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> money = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> prices = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int foodEaten = 0;
            while (true)
            {
                if (money.Count <= 0 || prices.Count <= 0)
                {
                    break;
                }
                int currentMoney = money.Peek();
                int currentPrice = prices.Peek();

                if (currentMoney == currentPrice)
                {
                    foodEaten++;
                    money.Pop();
                    prices.Dequeue();
                }
                else if (currentMoney < currentPrice)
                {
                    money.Pop();
                    prices.Dequeue();
                }
                else if (currentMoney > currentPrice)
                {
                    int diff = currentMoney - currentPrice;
                    foodEaten++;
                    money.Pop();
                    if (money.Count == 0)
                    {
                        break;
                    }
                    money.Push(money.Pop() + diff);
                    prices.Dequeue();

                }

            }
            if (foodEaten >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodEaten} foods.");
            }
            else if (foodEaten == 0)
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
            else if (foodEaten == 1)
            {
                Console.WriteLine($"Henry ate: {foodEaten} food.");
            }
            else
            {
                Console.WriteLine($"Henry ate: {foodEaten} foods.");
            }
        }
    }
}
/*
18 10 8 9
5 10 12 18
 */