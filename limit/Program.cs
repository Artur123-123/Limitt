using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace limit
{
    internal class Program
    {
        class Elementy
        {
            public int[] nums = new int[10];

            public void Limit()
            {
                int result;
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                    if (nums[i] > 0 && nums[i] < 10)
                    {
                        result = nums[i];
                    }
                    else
                    {
                        i--;
                        Console.WriteLine("Enter number between 1 and 9");
                    }
                }
            }

            public string ToText()
            {

            }

        }

        static void Main(string[] args)
        {
            Elementy element = new Elementy();
            element.Limit();
        }
    }
}
