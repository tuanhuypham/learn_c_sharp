using System;
using System.ComponentModel;

namespace homeWorld
{
    
    public class main
    {
        class aplication
        {
            public void print()
            {
                Console.WriteLine("hello world");
            }
        }
        class bignumber
        {
            public void find()
            {
                int[] arr = { 12, -4, 10, 4, 2, 71, -2, -6 };

                int max = arr[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (max < arr[i])

                        max = arr[i];
                }
                Console.WriteLine("\n\n So lon nhat trong mang la: {0}", max);
            }
        }
        class todo
        {
            private String content;
            private Boolean Ischeck;
            public todo()
            {
                this.Ischeck = false;
                this.content = "";
            }
            public todo(String content,Boolean Ischeck)
            {
                this.Ischeck = Ischeck;
                this.content = content;
            }
        }
        class todoList
        {
            int n;
            private todo[] list;
            public todoList()
            {
                this.list = new todo[n];
            }
            public void add()
            {

            }

        }
        static void Main(string[] args)
        {
            
        }
    }
}
