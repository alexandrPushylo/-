using System;
using System.Collections.Generic;
using System.Text;

namespace algoritms
{
    class Paint
    {
        int[,] map;
        int w, h;

        public Paint(int w, int h)
        {
            this.w = w;
            this.h = h;
            map = new int[w, h];
        }

        void SetMap(int x, int y, int number)
        {
            if (x < 0 || x >= w) return;
            if (y < 0 || x >= h) return;
            map[x, y] = number;
            PrintAt(x, y);
        }

        void PrintAt(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(map[x, y]);
        }

        public void PutRandomNumber(int count)
        {
            Random random = new Random();
            for (int j = 0; j < count; j++)
                SetMap(random.Next(w), random.Next(h), 1);
        }

        //42:35
        
        
        
    }
}
