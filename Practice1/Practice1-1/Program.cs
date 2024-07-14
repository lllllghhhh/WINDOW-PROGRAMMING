using System;
using System.Collections.Generic;
namespace Practice1_1
{
    internal class Program
    {
        struct shopping_cart
        {
            
        }

        struct good
        {
            public string name;
            public int price;
            public int amount;
        }
        public static void Main(string[] args)
        {
            shopping_cart buyer_1;
            good safety_cord, weight_belt, compass;
            safety_cord.name = "潛水相機防丟繩";
            safety_cord.price = 199;
            weight_belt.name = "潛水配重帶";
            weight_belt.price = 460;
            compass.name = "潛水作業指北針";
            compass.price = 1100;
            Console.WriteLine("(1)商品列表(2)新增至購物車(3)自購物車刪除(4)查看購物車(5)計算總金額(6)退出網站");
            Console.Write("輸入數字選擇功能: ");
            var option = int.Parse(Console.ReadLine());
            switch (option) {
                case 1:
                    Console.WriteLine("列表:\n商品名稱 商品單價");
                    Console.WriteLine("1.潛水相機防丟繩 (TWD)199");
                    Console.WriteLine("2.潛水配重帶 (TWD)460");
                    Console.WriteLine("3.潛水作業指北針 (TWD)1100");
                    break;
                case 2:
                    Console.WriteLine("(1)潛水相機防丟繩 (2)潛水配重帶 (3)潛水作業指北針");
                    Console.Write("輸入數字選擇商品: ");
                    var type = int.Parse(Console.ReadLine());
                    switch (type) {
                       case 1:
                           Console.Write("輸入數量: ");
                           var unit = int.Parse(Console.ReadLine());
                           safety_cord.amount = unit;
                           buyer_1
                           
                    }
                    
                    
                    break;
                    
                    
                    
            }
            
        }
    }
}