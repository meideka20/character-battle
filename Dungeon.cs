using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaps
{
    class Dungeon
    {
        private int width;
        private int height;

        public Dungeon(string name, int width, int height)
        {
            if(height >= 0 && width >= 0)
            {
                if(width <= 100)
                {
                    this.width = width;
                }
                else
                {
                    this.width = 100;
                }
                if (height <= 60)
                {
                    this.height = height;
                }
                else
                {
                    this.height = 100;
                }
            }
            Console.Title = name;
            Console.WindowWidth = width;
            Console.WindowHeight = height;
        }

        public void DrawWallVertical(int x, int y, int length)
        {
            for(int i = 0; i < length; i++)
            {
                if (y > 0 && y <= height)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("║");
                }
                y++;
            }
        }

        public void DrawWallVertical(int x, int y, int length, ConsoleColor color, char symbol)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < length; i++)
            {
                if (y > 0 && y <= height)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(symbol);
                }
                y++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void DrawWallHorizontal(int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (x > 0 && x <= width)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("═");
                }
                x++;
            }
        }

        public void DrawWallHorizontal(int x, int y, int length, ConsoleColor color, char symbol)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < length; i++)
            {
                if (x > 0 && x <= width)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(symbol);
                }
                x++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void DrawObject(int x, int y, char symbol)
        {
            if(x >= 0 && x < width && y >= 0 && y < height)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        }

        public void DrawObject(int x, int y, char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            if (x >= 0 && x < width && y >= 0 && y < height)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
