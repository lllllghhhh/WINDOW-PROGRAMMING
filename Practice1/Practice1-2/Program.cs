using System;
using System.Collections.Generic;
using System.IO;

namespace Practice1_1
{
    struct good
    {
        public string name;
        public int price;
        public int stock;
        public int amount;
        public int total_price;
    }

    struct order
    {
        public Dictionary<good, uint> order_list;
        public int original_price;
        public int final_price;
        public bool paid;

        public void print() {
            Console.WriteLine("訂單狀態：\n商品 單價 數量 小計");
            foreach (var item in order_list)
                Console.WriteLine("{0} NTD${1} {2} {3}", item.Key.name, item.Key.price, item.Value, item.Key.price * item.Value);
            Console.WriteLine("總價 = " + original_price);
            if (original_price != final_price)
                Console.WriteLine("總價(折扣後) = " + final_price);
            Console.WriteLine("狀態：{0}付款", paid ? "已" : "未");
        }
    }

    internal class Program {

        static List<good> item_list = new List<good>{
            new good{name = "潛水相機防丟繩", price = 199, stock = 10},
            new good{name = "潛水配重帶", price = 460, stock = 10},
            new good{name = "潛水作業指北針", price = 1100, stock = 10}
        };

        static List<Tuple<string, float>> currency = new List<Tuple<string, float>> {
            new Tuple<string, float>("NTD", 1f),
            new Tuple<string, float>("USD", 0.031f),
            new Tuple<string, float>("CNY", 0.23f),
            new Tuple<string, float>("JPY", 4.59f),
        };

        class shopping_cart
        {
            public Dictionary<good, uint> cart_items = new Dictionary<good, uint>();

            public bool add_item(int item_id, uint count) {
                var current_item = item_list[item_id];
                cart_items.TryGetValue(current_item, out uint original_count);
                if (original_count + count > current_item.stock)
                    return false;
                cart_items[current_item] = original_count + count;
                return true;
            }

            public void remove_item(int item_id, uint count) {
                var current_item = item_list[item_id];
                cart_items.TryGetValue(current_item, out uint original_count);
                if (original_count <= count)
                    cart_items.Remove(current_item);
                else
                    cart_items[current_item] = original_count - count;
            }

            public void print_by_id(uint use_currency = 0) {
                Console.WriteLine("購物車內容:\n商品 單價 數量 小計");
                var currency_data = currency[(int) use_currency];
                for (uint i = 0; i < item_list.Count; ++i) {
                    var item = item_list[(int) i];
                    cart_items.TryGetValue(item, out uint cart_count);
                    Console.WriteLine("{0}. {1} {5}${2} {3} {4}", i + 1, item.name, item.price, cart_count, item.price * cart_count * currency_data.Item2, currency_data.Item1);
                }
            }

            public void print() {
                Console.WriteLine("商品 單價 數量 小計");
                foreach (var item in cart_items)
                    Console.WriteLine("{0} NTD${1} {2} {3}", item.Key.name, item.Key.price, item.Value, item.Key.price * item.Value);
            }

            public int total_price() {
                int result = 0;
                foreach (var item in cart_items)
                    result += (int) (item.Key.price * item.Value);
                return result;
            }
        }

        private static shopping_cart current_user = new shopping_cart();

        static void print_all_items(uint use_currency = 0) {
            var currency_data = currency[(int) use_currency];
            Console.WriteLine("列表:\n商品名稱 商品單價");
            for (int i = 0; i < item_list.Count; ++i) {
                var item = item_list[i];
                Console.WriteLine("{0}. {1} {3}${2}", i + 1, item.name, item.price * currency_data.Item2, currency_data.Item1);
            }
        }

        static void print_simple_items() {
            for (int i = 0; i < item_list.Count; ++i)
                Console.Write("({0}) {1} ", i + 1, item_list[i].name);
        }

        static void print_available_currency() {
            uint i = 1;
            foreach (var p in currency)
                Console.Write("{0}. {1} ", i++, p.Item1);
        }
        
        static bool shopping()
        {
            Console.WriteLine("(1)商品列表(2)新增至購物車(3)自購物車刪除(4)查看購物車(5)結帳(6)轉換幣值(7)退出網站");
            Console.Write("輸入數字選擇功能: ");
            switch (Console.ReadLine()) {
                case "1":
                    print_all_items();
                    break;
                case "2":
                    int type;
                    while (true) {
                        print_simple_items();
                        Console.Write("\n輸入數字選擇商品: ");
                        try {
                            type = int.Parse(Console.ReadLine());
                        } catch {
                            Console.WriteLine("輸入錯誤，重新輸入！");
                            continue;
                        }
                        if (type <= item_list.Count && type > 0)
                            break;
                        Console.WriteLine("找不到商品{0}，請重新輸入。", type);
                    }

                    while (true) {
                        Console.Write("輸入數量: ");
                        uint unit;
                        try {
                            unit = uint.Parse(Console.ReadLine());
                        }
                        catch {
                            Console.WriteLine("輸入錯誤，重新輸入！");
                            continue;
                        }
                        if (!current_user.add_item(type - 1, unit))
                            Console.WriteLine("Too many items!!!");
                        break;
                    }
                    break;
                case "3":
                    while (true) {
                        current_user.print_by_id();
                        Console.Write("\n輸入數字選擇商品: ");
                        try {
                            type = int.Parse(Console.ReadLine());
                        }
                        catch  {
                            Console.WriteLine("error!! input again!");
                            continue;
                        }
                        if (type <= item_list.Count && type > 0)
                            break;
                        Console.WriteLine("找不到商品{0}，請重新輸入。", type);
                    }
                    while (true) {
                        Console.Write("輸入數量: ");
                        try {
                            current_user.remove_item(type - 1, uint.Parse(Console.ReadLine()));
                        }
                        catch {
                            Console.WriteLine("error!! input again!");
                            continue;
                        }
                        break;
                    }
                    break;
                case "4":
                    current_user.print_by_id();
                    break;
                case "5":
                    Console.WriteLine("購物車內容:");
                    current_user.print();
                    Console.WriteLine("總價 = " + current_user.total_price());
                    Console.Write("*是否要結帳(Y/N)*:");
                    var y_or_n = Console.ReadLine();
                    switch (y_or_n) {
                        case "N":
                            shopping();
                            break;
                        case "Y":
                            order current_order = new order();
                            current_order.order_list = current_user.cart_items;
                            current_order.final_price = current_order.original_price = current_user.total_price();
                            while (true) {
                                Console.Write("*選擇結帳方式(1.線上支付 2.貨到付款):");
                                switch (Console.ReadLine()) {
                                    case "1":
                                        current_order.paid = true;
                                        break;
                                    case "2":
                                        current_order.paid = false;
                                        break;
                                    default:
                                        Console.WriteLine("輸入錯誤!請重新輸入!");
                                        continue;
                                }
                                break;
                            }
                            while (true) {
                                Console.Write("*折扣碼(若無折扣碼則輸入N):");
                                switch (Console.ReadLine()) {
                                    case "N":
                                        break;
                                    case "1111":
                                        current_order.final_price = (int) (current_order.final_price * 0.95);
                                        break;
                                    default:
                                        Console.WriteLine("輸入錯誤!請重新輸入!");
                                        continue;
                                }
                                break;
                            }
                            current_order.print();
                            break;
                        default:
                            Console.WriteLine("輸入錯誤!請重新輸入!");
                            break;
                    }
                    break;
                case "6":
                    while (true) {
                        Console.Write("選擇貨幣 ");
                        print_available_currency();
                        Console.Write(":");
                        uint forex;
                        try {
                            forex = uint.Parse(Console.ReadLine());
                        }
                        catch {
                            Console.WriteLine("error!! input again!");
                            continue;
                        }
                        if (forex > currency.Count || forex == 0) {
                            Console.WriteLine("error!! input again!");
                            continue;
                        }
                        print_all_items(forex - 1);
                        break;
                    }
                    break;
                case "7":
                    return false;
                default:
                    Console.WriteLine("輸入錯誤!請重新輸入!");
                    break;
            }

            return true;
        }
        
        public static void Main(string[] args) {
            while (shopping())
                ;
        }
    }
}