using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProj
{
    public class DB
    {
        public int JerseyNum { get; set; }
        public string Name { get; set; }
        public bool Home { get; set; }  
        public List<int> Runs { get; set; }

        public static List<DB> InvokeDB()
        {
            DB[] list1 =
            {new DB
                {
                    JerseyNum = 10,
                    Name = "Sachin",
                    Home = true,
                    Runs = new List<int> { 55, 37, 104, 21, 142, 87, 8, 26, 114, 44, 28, 3}
                },
                new DB
                {
                    JerseyNum = 19,
                    Name = "Dravid",
                    Home = true,
                    Runs = new List<int> { 67, 33, 72, 69, 29, 127, 32, 52, 12, 39, 105, 48 }
                },
                new DB
                {
                    JerseyNum = 24,
                    Name = "Ganguly",
                    Home = true,
                    Runs = new List<int> { 42, 31, 18, 12, 158, 25, 88, 31, 7, 101, 39, 47 }
                },
                new DB
                {
                    JerseyNum = 7,
                    Name = "Dhoni",
                    Home = true,
                    Runs = new List<int> { 23, 33, 59, 27, 40, 79, 19, 35, 62, 43, 20, 110 }
                },
                new DB
                {
                    JerseyNum = 18,
                    Name = "Kohli",
                    Home = true,
                    Runs = new List<int> { 27, 108, 133, 23, 17, 40, 68, 71, 9, 22, 56, 61 }
                },
                new DB
                {
                    JerseyNum = 45,
                    Name = "Rohit",
                    Home = true,
                    Runs = new List<int> { 12, 12, 75, 176, 5, 42, 52, 36, 103, 21, 23, 64 }
                },
                new DB
                {
                    JerseyNum = 24,
                    Name = "Ganguly",
                    Home = false,
                    Runs = new List<int> { 28, 11, 22, 9, 96, 66, 111, 6, 15, 68}
                },
                new DB
                {
                    JerseyNum = 19,
                    Name = "Dravid",
                    Home = false,
                    Runs = new List<int> { 16, 38, 35, 47, 8, 16, 138, 4, 29, 43 }
                },
                new DB
                {
                    JerseyNum = 10,
                    Name = "Sachin",
                    Home = false,
                    Runs = new List<int> { 54, 32, 87, 10, 7, 128, 109, 6, 14, 29 }
                },
                new DB
                {
                    JerseyNum = 7,
                    Name = "Dhoni",
                    Home = false,
                    Runs = new List<int> { 7, 31, 9, 69, 32, 37, 77, 25, 24, 49 }
                },
                new DB
                {
                    JerseyNum = 18,
                    Name = "Kohli",
                    Home = false,
                    Runs = new List<int> { 28, 84, 30, 21, 105, 32, 11, 107, 45, 53 }
                },
                new DB
                {
                    JerseyNum = 45,
                    Name = "Rohit",
                    Home = false,
                    Runs = new List<int> { 6, 11, 19, 148, 41, 24, 16, 61, 15, 63 }
                },

            };
            List<DB>list2 = new List<DB>(list1);
            return list2;
        }
    }
}
