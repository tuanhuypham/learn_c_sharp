
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Todo
{
    public class main
    {

        class toDoitem
        {
            public Boolean isCheck;
            public string job;

            public toDoitem(bool isCheck, string job)
            {
                this.isCheck = isCheck;
                this.job = job;
            }

            public toDoitem()
            {
                this.isCheck = false;
                this.job = " ";
            }
            public void show()
            {
                string check = (isCheck) ? "[x]" : "[] ";
                if(job == "")
                {
                    Console.Write(" not data user\n");
                }
                else
                {
                    if(this.job != ""){

                    }
                    Console.WriteLine(check + job);
                }
            }
        }
        static void Main(string[] args)
        {
            int sttFunction = 0;
            string content = "";

            List<toDoitem> _list = new List<toDoitem>();
            do
            {
                Console.WriteLine("0 de thoat : ");
                Console.WriteLine("1 Nhap cong viec : ");
                Console.WriteLine("2 Hien thi cong viec : ");
                Console.WriteLine("3 Danh dau cong viec : ");
                Console.WriteLine("4 bo danh dau cong viec : ");
                Console.WriteLine("5 xoa cong viec : ");
                Console.WriteLine("6 sua cong viec : ");
                Console.WriteLine("7 tim cong viec : ");
                Console.Write("input : ");
                sttFunction = 0;
                sttFunction = Convert.ToInt32(Console.ReadLine());

                switch (sttFunction)
                {
                    case 1:
                        Console.Write("Nhap vao cong viec : ");
                        content = Console.ReadLine();
                        _list.Add(new toDoitem(false, content));                     
                        //neu ko nhap gi thi chuyen gi se xay ra  
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Danh sach cong viec");
                        Console.WriteLine("");
                        Console.WriteLine("-----===-----");
                        foreach (toDoitem item in _list)
                        {
                            item.show();
                        }
                        Console.WriteLine("-----===-----");
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.Write("nhap vi tri danh dau : ");
                        int toggle = Convert.ToInt32(Console.ReadLine()); //neu nhapc 999999 thi chuyen gi se xay ra
                        if (toggle > 7 & toggle < 0)
                        {
                            break;
                        }
                        else
                        {
                            _list[toggle].isCheck = true;
                        }
                        break;
                    case 4:
                        Console.Write("nhap vi tri bo danh dau: ");
                        toggle = Convert.ToInt32(Console.ReadLine()); //neu nhapc 999999 thi chuyen gi se xay ra
                        if (toggle > 7 & toggle < 0)
                        {
                            break;
                        }
                        else
                        {
                            _list[toggle].isCheck = false;
                        }
                        break;
                    case 5:
                        Console.WriteLine("nhap vao vi tri can xoa : ");
                        int remove = Convert.ToInt32(Console.ReadLine()); //neu nhapc 999999 thi chuyen gi se xay ra
                        if(remove > 7 & remove < 0)
                        {
                            break;
                        }
                        else
                        {
                            _list.RemoveAt(remove);
                        }
                        break;
                    case 6:
                        Console.Write("Nhap vao vi tri can sua :");
                        int index = Convert.ToInt32(Console.ReadLine()); //neu nhapc 999999 thi chuyen gi se xay ra  
                        Console.Write("noi dung can sua :");
                        content = Console.ReadLine(); //ko nhap gi chuyen gi se xay ra
                        _list[index].job = content;
                        break;
                    case 7:
                        Console.WriteLine("Nhap vao vi tri can tim : "); //di tim no dung gi do thi hop ly hon
                        toggle = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < _list.Count; i++)
                        {
                            if (i == toggle)
                            {
                                Console.WriteLine("");
                                Console.Write("cong viec can tim");
                                Console.WriteLine("-----===-----");
                                _list[i].show();
                                Console.WriteLine("-----===-----");
                                Console.WriteLine("");
                                break;
                            }
                        }
                        break;
                    default:
                        if (sttFunction == 0)
                        {
                            Console.WriteLine("cam on ban da su dung tool nay !!!");
                        }
                        break;
                }
            } while (sttFunction != 0);
            //BigNumber.BigNumber_1 a = new BigNumber.BigNumber_1();
            //a.find(); 
            //Print a = new Print();
            //a.Display();
        }
    }
}
