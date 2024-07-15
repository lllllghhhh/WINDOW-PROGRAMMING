using System;
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
            public  string name;
            public int price;
            public int amount;
            public int total_price;
            public int stock;
        }
        
        
        public static void Main(string[] args)
        {
            shopping_cart buyer_1;
            good safety_cord, weight_belt, compass;
            safety_cord.name = "潛水相機防丟繩";
            safety_cord.price = 199;
            safety_cord.amount = 0;
            safety_cord.total_price = 0;
            safety_cord.stock = 1;
            weight_belt.name = "潛水配重帶";
            weight_belt.price = 460;
            weight_belt.amount = 0;
            weight_belt.total_price = 0;
            weight_belt.stock = 2;
            compass.name = "潛水作業指北針";
            compass.price = 1100;
            compass.amount = 0;
            compass.total_price = 0;
            compass.stock = 1;
            buyer_1.cord_block = safety_cord;
            buyer_1.belt_block = weight_belt;
            buyer_1.compass_block = compass;

            void show_cart_list(shopping_cart buyer)
            {
                Console.WriteLine("購物車內容:");
                Console.WriteLine("商品 單價 數量 小計");
                Console.WriteLine("1." + buyer.cord_block.name +" (TWD)" + buyer.cord_block.price +" " + 
                              buyer.cord_block.amount + " "+buyer.cord_block.total_price);
                Console.WriteLine("2." + buyer.belt_block.name +" (TWD)" + buyer.belt_block.price +" " + 
                                  buyer.belt_block.amount + " "+buyer.belt_block.total_price);
                Console.WriteLine("3." + buyer.compass_block.name +" (TWD)" + buyer.compass_block.price +" " + 
                                  buyer.compass_block.amount + " "+buyer.compass_block.total_price);
            }
            

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
                                buyer_1.cord_block.amount += unit;
                                buyer_1.cord_block.total_price += unit * safety_cord.price;
                                shopping();
                                break;
                            case 2:
                                buyer_1.belt_block.amount += unit;
                                buyer_1.belt_block.total_price += unit * weight_belt.price;
                                shopping();
                                break;
                            case 3:
                                buyer_1.compass_block.amount += unit;
                                buyer_1.compass_block.total_price += unit * compass.price;
                                shopping();
                                break;
                            default:
                                Console.WriteLine("error");
                                shopping();
                                break;
                        }

                        break;
                    case 3:
                        show_cart_list(buyer_1);
                        Console.Write("輸入數字選擇商品: ");
                        var delete_type = int.Parse(Console.ReadLine());
                        switch (delete_type) {
                            case 1:
                                Console.Write("輸入數量: ");
                                var delete_unit_cord = int.Parse(Console.ReadLine());
                                if (delete_unit_cord > buyer_1.cord_block.amount) 
                                    Console.WriteLine("error");
                                else {
                                    buyer_1.cord_block.amount -= delete_unit_cord;
                                    buyer_1.cord_block.total_price =
                                        buyer_1.cord_block.amount * buyer_1.cord_block.price;
                                    Console.WriteLine("成功刪除商品!");
                                }
                                shopping();
                                break;
                            case 2:
                                Console.Write("輸入數量: ");
                                var delete_unit_weight = int.Parse(Console.ReadLine());
                                if (delete_unit_weight > buyer_1.belt_block.amount) 
                                    Console.WriteLine("error");
                                else {
                                    buyer_1.belt_block.amount -= delete_unit_weight;
                                    buyer_1.belt_block.total_price = 
                                        buyer_1.belt_block.amount * buyer_1.belt_block.price;
                                    Console.WriteLine("成功刪除商品!");
                                }
                                shopping();
                                break;
                            case 3:
                                Console.Write("輸入數量: ");
                                var delete_unit_compass = int.Parse(Console.ReadLine());
                                if (delete_unit_compass > buyer_1.compass_block.amount) 
                                    Console.WriteLine("error");
                                else {
                                    buyer_1.compass_block.amount -= delete_unit_compass;
                                    buyer_1.compass_block.total_price =
                                        buyer_1.compass_block.amount * buyer_1.compass_block.price;
                                    Console.WriteLine("成功刪除商品!");
                                }
                                shopping();
                                break;
                            default:
                                Console.WriteLine("輸入錯誤!請重新輸入!");
                                shopping();
                                break;
                        }

                        break;
                    case 4:
                        show_cart_list(buyer_1);
                        shopping();
                        break;
                    case 5:
                        Console.WriteLine("購物車內容:");
                        Console.WriteLine("商品 單價 數量 小計");
                        if (buyer_1.cord_block.amount != 0) {
                            Console.WriteLine("1." + buyer_1.cord_block.name +" (TWD)" + buyer_1.cord_block.price +" " + 
                                              buyer_1.cord_block.amount + " "+buyer_1.cord_block.total_price);
                        }

                        if (buyer_1.belt_block.amount != 0) {
                            Console.WriteLine("2." + buyer_1.belt_block.name +" (TWD)" + buyer_1.belt_block.price +" " + 
                                              buyer_1.belt_block.amount + " "+buyer_1.belt_block.total_price);
                        }

                        if (buyer_1.compass_block.amount != 0) {
                            Console.WriteLine("3." + buyer_1.compass_block.name +" (TWD)" + buyer_1.compass_block.price +" " + 
                                              buyer_1.compass_block.amount + " "+buyer_1.compass_block.total_price);
                        }
                        Console.WriteLine("總價:" + (buyer_1.cord_block.total_price + buyer_1.belt_block.total_price + 
                                                   buyer_1.compass_block.total_price) );
                        Console.Write("*是否要結帳(Y/N)*:");
                        var y_or_n = Console.ReadLine();
                        switch (y_or_n) {
                            case "N":
                                shopping();
                                break;
                            case "Y":
                                bool stock_enough = true;
                                if (buyer_1.cord_block.amount > buyer_1.cord_block.stock) {
                                    Console.WriteLine("潛水相機防丟繩庫存不足!剩餘數量" + buyer_1.cord_block.stock + "!");
                                    stock_enough = false;
                                }

                                if (buyer_1.belt_block.amount > buyer_1.belt_block.stock) {
                                    Console.WriteLine("潛水配重帶庫存不足!剩餘數量" + buyer_1.belt_block.stock + "!");
                                    stock_enough = false;
                                }

                                if (buyer_1.compass_block.amount > buyer_1.compass_block.stock) {
                                    Console.WriteLine("潛水作業指北針庫存不足!剩餘數量" + buyer_1.compass_block.stock + "!");
                                    stock_enough = false;
                                }

                                if (stock_enough) {
                                    Console.Write("(選擇結帳方式(1.線上支付 2.貨到付款):");
                                    var checkout_type = int.Parse(Console.ReadLine());
                                }
                                
                                    
                                break;
                            default:
                                Console.WriteLine("輸入錯誤!請重新輸入!");
                                shopping();
                                break;
                        }
                        

                    {
                            
                        }
                        
                            
                        shopping();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("輸入錯誤!請重新輸入!");
                        shopping();
                        break;
                    
                }
            }

            shopping();
            
        }
    }
}