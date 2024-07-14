﻿using System;
using System.Collections.Generic;
namespace Practice1_1
{
    internal class Program
    {
        struct shopping_cart
        {
            public good cord_block;
            public good belt_block;
            public good compass_block;
        }

        struct good
        {
            public string name;
            public int price;
            public int amount;
            public int total_amount;
        }
        
        public static void Main(string[] args)
        {
            shopping_cart buyer_1;
            good safety_cord, weight_belt, compass;
            safety_cord.name = "潛水相機防丟繩";
            safety_cord.price = 199;
            safety_cord.amount = 0;
            safety_cord.total_amount = 0;
            weight_belt.name = "潛水配重帶";
            weight_belt.price = 460;
            weight_belt.amount = 0;
            weight_belt.total_amount = 0;
            compass.name = "潛水作業指北針";
            compass.price = 1100;
            compass.amount = 0;
            compass.total_amount = 0;
            buyer_1.cord_block = safety_cord;
            buyer_1.belt_block = weight_belt;
            buyer_1.compass_block = compass;
            void shopping()
            {
                Console.WriteLine("(1)商品列表(2)新增至購物車(3)自購物車刪除(4)查看購物車(5)計算總金額(6)退出網站");
                Console.Write("輸入數字選擇功能: ");
                var option = int.Parse(Console.ReadLine());
                switch (option) {
                    case 1:
                        Console.WriteLine("列表:\n商品名稱 商品單價");
                        Console.WriteLine("1.潛水相機防丟繩 (TWD)199");
                        Console.WriteLine("2.潛水配重帶 (TWD)460");
                        Console.WriteLine("3.潛水作業指北針 (TWD)1100");
                        shopping();
                        break;
                    case 2:
                        Console.WriteLine("(1)潛水相機防丟繩 (2)潛水配重帶 (3)潛水作業指北針");
                        Console.Write("輸入數字選擇商品: ");
                        var type = int.Parse(Console.ReadLine());
                        Console.Write("輸入數量: ");
                        var unit = int.Parse(Console.ReadLine()); 
                        switch (type) {
                            case 1:
                                buyer_1.cord_block.amount = unit;
                                buyer_1.cord_block.total_amount = unit * safety_cord.price;
                                shopping();
                                break;
                            case 2:
                                weight_belt.amount = unit;
                                weight_belt.total_amount = unit * weight_belt.price; 
                                shopping();
                                break;
                            case 3:
                                compass.amount = unit;
                                compass.total_amount = unit * compass.price;
                                shopping();
                                break;
                            default:
                                Console.WriteLine("error");
                                shopping();
                                break;
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("購物車內容:");
                        Console.WriteLine("商品 單價 數量 小計");
                        Console.Write("1.");
                        Console.Write(buyer_1.cord_block.name);
                        Console.Write(" (TWD)");
                        Console.Write(buyer_1.cord_block.price);
                        Console.Write(" ");
                        Console.Write(buyer_1.cord_block.amount);
                        Console.Write(" ");
                        Console.Write(buyer_1.cord_block.total_amount);
                        Console.Write("2.");
                        Console.Write(buyer_1.belt_block.name);
                        Console.Write(" (TWD)");
                        Console.Write(buyer_1.belt_block.price);
                        Console.Write(" ");
                        Console.Write(buyer_1.belt_block.amount);
                        Console.Write(" ");
                        Console.Write(buyer_1.belt_block.total_amount);
                        Console.Write("3.");
                        Console.Write(buyer_1.compass_block.name);
                        Console.Write(" (TWD)");
                        Console.Write(buyer_1.compass_block.price);
                        Console.Write(" ");
                        Console.Write(buyer_1.compass_block.amount);
                        Console.Write(" ");
                        Console.Write(buyer_1.compass_block.total_amount);
                        break;
                    
                }
            }
            shopping();
            
        }
    }
}