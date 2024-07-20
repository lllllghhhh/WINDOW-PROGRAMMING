using System;
using System.Collections.Generic;
using System.IO;

namespace Practice1_1
{
    internal class Program {
        struct good
        {
            public string name;
            public int price;
            public int stock;
            public int amount;
            public int total_price;
        }
            
        static List<good> item_list = new List<good>{
            new good{name = "潛水相機防丟繩", price = 199, stock = 10},
            new good{name = "潛水配重帶", price = 460, stock = 10},
            new good{name = "潛水作業指北針", price = 1100, stock = 10}
        };

        class shopping_cart
        {
            private Dictionary<good, uint> cart_items;

            public bool add_item(int item_id, uint count) {
                var current_item = item_list[item_id];
                cart_items.TryGetValue(current_item, out uint original_count);
                if (original_count + count > current_item.stock)
                    return false;
                cart_items[current_item] = original_count + count;
                return true;
            }
        }

        private static shopping_cart current_user;

        static void print_all_items(bool print_only_name = false) {
            if (!print_only_name)
                Console.WriteLine("列表:\n商品名稱 商品單價");
            for (int i = 0; i < item_list.Count; ++i) {
                var item = item_list[i];
                if (print_only_name)
                    Console.Write("({0}) {1} ", i + 1, item.name);
                else
                    Console.WriteLine("{0}. {1} NTD${2}", i + 1, item.name, item.price);
            }
        }
        
        
        public static void Main(string[] args) {

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

            void checkout(shopping_cart buyer)
            {
                Console.WriteLine("商品 單價 數量 小計");
                if (buyer.cord_block.amount != 0) {
                    Console.WriteLine("1." + buyer.cord_block.name +" (TWD)" + buyer.cord_block.price +" " + 
                                      buyer.cord_block.amount + " "+ buyer.cord_block.total_price);
                }

                if (buyer_1.belt_block.amount != 0) {
                    Console.WriteLine("2." + buyer.belt_block.name +" (TWD)" + buyer.belt_block.price +" " + 
                                      buyer.belt_block.amount + " "+ buyer.belt_block.total_price);
                }

                if (buyer_1.compass_block.amount != 0) {
                    Console.WriteLine("3." + buyer.compass_block.name +" (TWD)" + buyer.compass_block.price +" " + 
                                      buyer.compass_block.amount + " "+ buyer.compass_block.total_price);
                }
                Console.WriteLine("總價 = " + (buyer.cord_block.total_price + buyer.belt_block.total_price + 
                                           buyer.compass_block.total_price) );
            }
            

            void shopping()
            {
                Console.WriteLine("(1)商品列表(2)新增至購物車(3)自購物車刪除(4)查看購物車(5)結帳(6)轉換幣值(7)退出網站");
                Console.Write("輸入數字選擇功能: ");
                var option = int.Parse(Console.ReadLine());
                switch (option) {
                    case 1:
                        print_all_items();
                        break;
                    case 2:
                        int type;
                        while (true) {
                            print_all_items(true);
                            Console.Write("\n輸入數字選擇商品: ");
                            type = int.Parse(Console.ReadLine());
                            if (type < item_list.Count && type > 0)
                                break;
                            Console.WriteLine("找不到商品{0}，請重新輸入。", type);
                        }
                        Console.Write("輸入數量: ");
                        var unit = uint.Parse(Console.ReadLine());
                        if (!current_user.add_item(type - 1, unit))
                            Console.WriteLine("Too many items!!!");
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
                        checkout(buyer_1);
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
                                    Console.Write("*(選擇結帳方式(1.線上支付 2.貨到付款):");
                                    var payment = Console.ReadLine();
                                    if (payment != "1" && payment != "2") {
                                        Console.WriteLine("輸入錯誤!請重新輸入!");
                                        shopping();
                                    }

                                    Console.Write("*折扣碼(若無折扣碼則輸入N):");
                                    var discount_code = Console.ReadLine();
                                    switch (discount_code) {
                                        case "N":
                                            Console.WriteLine("訂單狀態:");
                                            checkout(buyer_1);
                                            if(payment == "1")
                                                Console.WriteLine("已付款");
                                            else if(payment == "2")
                                                Console.WriteLine("尚未付款");
                                            else 
                                                Console.WriteLine("error");
                                            break;
                                        case "1111":
                                            checkout(buyer_1);
                                            Console.WriteLine("總價(折扣後) = " +
                                                              (buyer_1.cord_block.total_price +
                                                               buyer_1.belt_block.total_price +
                                                               buyer_1.compass_block.total_price) * 0.95);
                                            if(payment == "1")
                                                Console.WriteLine("已付款");
                                            else if(payment == "2")
                                                Console.WriteLine("尚未付款");
                                            else 
                                                Console.WriteLine("error");
                                            break;
                                        default:
                                            Console.WriteLine("輸入錯誤!請重新輸入!");
                                            shopping();
                                            break;
                                            
                                            
                                }
                                
                                }
                                
                                    
                                break;
                            default:
                                Console.WriteLine("輸入錯誤!請重新輸入!");
                                shopping();
                                break;
                        }
                        shopping();
                        break;
                    case 6:
                        Console.Write("選擇貨幣 1.TWD 2.USD 3.CNY 4.JPY :");
                        var forex = Console.ReadLine();
                        switch (forex) {
                            case "1":
                                Console.WriteLine("列表:\n商品名稱 商品單價");
                                Console.WriteLine("1.潛水相機防丟繩 (USD)" + buyer_1.cord_block.price );
                                Console.WriteLine("2.潛水配重帶 (USD)" + buyer_1.belt_block.price );
                                Console.WriteLine("3.潛水作業指北針 (USD)" + buyer_1.compass_block.price );
                                shopping();
                                break;
                            case "2":
                                Console.WriteLine("列表:\n商品名稱 商品單價");
                                Console.WriteLine("1.潛水相機防丟繩 (TWD)" + buyer_1.cord_block.price * 0.031);
                                Console.WriteLine("2.潛水配重帶 (TWD)" + buyer_1.belt_block.price * 0.031);
                                Console.WriteLine("3.潛水作業指北針 (TWD)" + buyer_1.compass_block.price * 0.031);
                                shopping();
                                break;
                            case "3" :
                                Console.WriteLine("列表:\n商品名稱 商品單價");
                                Console.WriteLine("1.潛水相機防丟繩 (CNY)" + buyer_1.cord_block.price * 0.23);
                                Console.WriteLine("2.潛水配重帶 (CNY)" + buyer_1.belt_block.price * 0.23);
                                Console.WriteLine("3.潛水作業指北針 (CNY)" + buyer_1.compass_block.price * 0.23);
                                shopping();
                                break;
                            case "4" :
                                Console.WriteLine("列表:\n商品名稱 商品單價");
                                Console.WriteLine("1.潛水相機防丟繩 (JPY)" + buyer_1.cord_block.price * 4.59);
                                Console.WriteLine("2.潛水配重帶 (JPY)" + buyer_1.belt_block.price * 4.59);
                                Console.WriteLine("3.潛水作業指北針 (JPY)" + buyer_1.compass_block.price * 4.59);
                                shopping();
                                break;
                            default:
                                Console.WriteLine("輸入錯誤!請重新輸入!");
                                shopping();
                                break;
                        }
                        shopping();
                        break;
                    case 7:
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