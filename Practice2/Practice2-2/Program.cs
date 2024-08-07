﻿using System;
using System.Linq;

namespace Practice2_2
{
    class Board
    {

        private bool[,] ghost_state;
        private char[,] view_state;
        private bool initd = false;
        private uint x_size, y_size, ghost;

        public Board(uint x, uint y, uint ghost) {
            this.ghost = ghost;
            this.x_size = x;
            this.y_size = y;
            ghost_state = new bool[x, y];
            view_state = new char[x, y];
            for (uint i = 0; i < x_size; ++i)
            for (uint j = 0; j < y_size; ++j)
                view_state[i, j] = '-';
        }

        public bool view(uint x, uint y) {
            if (!initd) {
                initd = true;
                var rng = new Random();
                for (uint i = 0; i < ghost; ) {
                    var __x = rng.Next() % x_size;
                    var __y = rng.Next() % y_size;
                    if (ghost_state[__x, __y] || x == __x && y == __y) 
                        continue;
                    ghost_state[__x, __y] = true;
                    i++;
                }
            }

            if (ghost_state[x, y]) {
                view_state[x, y] = 'X';
                return false;
            }
            uint count = 0;
            bool no_left = x == 0, no_right = x == x_size - 1, no_up = y == 0, no_down = y == y_size - 1;
            if (!no_left && !no_up)
                count += ghost_state[x - 1, y - 1] ? 1u : 0u;
            if (!no_up)
                count += ghost_state[x, y - 1] ? 1u : 0u;
            if (!no_right && !no_up)
                count += ghost_state[x + 1, y - 1] ? 1u : 0u;
            if (!no_left)
                count += ghost_state[x - 1, y] ? 1u : 0u;
            if (!no_right)
                count += ghost_state[x + 1, y] ? 1u : 0u;
            if (!no_left && !no_down)
                count += ghost_state[x - 1, y + 1] ? 1u : 0u;
            if (!no_down)
                count += ghost_state[x, y + 1] ? 1u : 0u;
            if (!no_right && !no_down)
                count += ghost_state[x + 1, y + 1] ? 1u : 0u;
            view_state[x,y] = (char) ('0' + count);
            return true;
        }

        public void print()
        {
            Console.Write(" ");
            for (int k = 0; k < x_size; k++)
                Console.Write(" " + (char)(k + 'A' ));
                
            Console.WriteLine();
            for (int i = 0; i < y_size; i++) {
                Console.Write(i);
                for (int j = 0; j < x_size; j++) {
                    Console.Write(" " + view_state[j, i]);
                }
                Console.WriteLine();
            }
            
                
        }
    }
    
    internal class Program {
        
        public static void Main(string[] args)
        {  
            Console.WriteLine("設定遊戲參數"); 
            Console.Write("輸入空間大小: ");
           var k = Console.ReadLine().Split(',').Select(uint.Parse).ToArray();
           Console.Write("輸入鬼的數量:");
           var ghost = uint.Parse(Console.ReadLine());
           if (k[0] * k[1] <= ghost) {
               Console.WriteLine("遊戲參數錯誤!");
               Environment.Exit(0);
           }
           Console.Clear();
           var board = new Board(k[0], k[1], ghost);
           string [] c;
           uint x,y;
           do {
               board.print();
               Console.Write("輸入要查看的位置: ");
               c = Console.ReadLine().Split(',');
                x = (uint)(c[0][0]);
                y = (uint)(c[1][0]) - 65;
               
               Console.Clear();
           } while (board.view(x, y));
           board.print();
           if(!board.view(x, y))
               Console.WriteLine("遊戲結束! 你被鬼抓到了");
           else 
               Console.WriteLine("遊戲結束! 你成功躲避所有的鬼了");
           
        
           
        }
    }
}