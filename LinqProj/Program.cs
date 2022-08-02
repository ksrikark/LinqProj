using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace LinqProj
{
    class Program
    {
        public static void Main()
        {
            IEnumerable<DB> result = DB.InvokeDB().OrderByDescending(s => s.Name).ThenByDescending(s => (s.Runs).Sum());
            
            Console.WriteLine("Enter page number");
            int page = 0;

            if (int.TryParse(Console.ReadLine(), out page))
            {
                if (page >= 1 && page <= 6)
                {
                        int pageSize = 2;
                        IEnumerable<DB>paging = result.Skip((page - 1)*pageSize).Take(pageSize).ToList();
                    Console.WriteLine("-------------------------------------------------BATTING STATS-------------------------------------------------");
                    Console.WriteLine();
                        Console.WriteLine("Page " + page);
                    Console.WriteLine();
                    Console.WriteLine("\t\t\tName" + "\t\t" + "Innings" + "\t\t" + "Runs" + "\t\t" + "50s/100s" + "\t" + "Avg" + "\t\t" + "HS");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                        foreach (var item in paging)
                        {
                        if (item.Home)
                        {
                            Console.WriteLine("Home stats");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Away stats");
                            Console.WriteLine();

                        }
                        Console.WriteLine("\t\t\t" + item.Name + "\t\t" + item.Runs.Count() + "\t\t" + item.Runs.Sum()
                            + "\t\t" + item.Runs.Where(s => s > 50 && s < 100).Count() + "/" + 
                            item.Runs.Where(s => s > 100).Count() + "\t\t" + Math.Round(item.Runs.Average(),2) + "\t\t" + item.Runs.Max());
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");


                    }

                }
            }
            else
            {
                    Console.Write("Invalid Page Number");
            }
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("View Overall Batting Stats of:- ");
            Console.WriteLine();
            var batter = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Overall batting Stats of {batter}: ");
            Console.WriteLine();
            var result2 = DB.InvokeDB().Where(s => s.Name == batter).SelectMany(s => s.Runs);
            Console.WriteLine("\tName" + "\t\t" + "Innings" + "\t\t" + "Runs" + "\t\t" + "50s/100s" + "\t" + "Avg" + "\t\t" + "HS");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t" + batter + "\t\t" + result2.Count() + "\t\t" + result2.Sum()
                            + "\t\t" + result2.Where(s => s > 50 && s < 100).Count() + "/" + 
                            result2.Where(s => s > 100).Count() + "\t\t" + Math.Round(result2.Average(),2) + "\t\t" + result2.Max());
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
        }
    }
}