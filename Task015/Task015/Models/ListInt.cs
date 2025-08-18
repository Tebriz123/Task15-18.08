using System;
using System.Collections.Generic;
using System.Text;

namespace Task015.Models
{
    internal class ListInt
    {
        private int[] arrey;

        public int[] Arrey
        {
            get
            {
                return arrey;
            }
            set
            {
                arrey = value;
            }
        }
        public int this[int index]
        {
            get
            {
                return arrey[index];
            }
            set
            {
                arrey[index] = value;
            }
        }

        public void Add(int num)
        {
            Array.Resize(ref arrey, arrey.Length + 1);
            arrey[arrey.Length-1] = num;    
        }

        public void AddRange(params int[] nums)
        {
            Array.Resize(ref arrey,arrey.Length + nums.Length);
            for(int i = 0; i < nums.Length; i++)
            {
                arrey[arrey.Length-nums.Length+i] = nums[i];
            }
        }

        public bool Contains(int num)
        {
            for(int i = 0;i < arrey.Length; i++)
            {
                if(this[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            for( int i = 0;i < arrey.Length ; i++)
            {
                 sum+= this[i] ;
            }
            return sum;
        }
        public void Remove(int num)
        {
            int[] newArrey = new int[arrey.Length-1];
            int j = 0;

            for(int i = 0; i <  arrey.Length; i++)
            {
                if(arrey[i] != num)
                {
                    newArrey[j] = arrey[i];
                    j++;
                }
            }
            arrey = newArrey;

        }
        public void RemoveRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Remove(nums[i]);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", Arrey);
        }

    }
}
