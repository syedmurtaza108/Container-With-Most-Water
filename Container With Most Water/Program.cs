using System;

namespace Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            //Console.WriteLine(MaxArea(new int[] { 2, 3, 4, 5, 18, 17, 6 }));
        }

        static int MaxArea(int[] height)
        {
            int maxArea = int.MinValue;
            for (int i = 0, j = height.Length - 1; i < height.Length;)
            {
                int _base = j - i;
                int _height = Math.Min(height[i], height[j]);
                int area = _base * _height;
                maxArea = Math.Max(area, maxArea);
                if (height[i] > height[j]) j--;
                else i++;
                if (j < i) break;
            }

            return maxArea;
        }
    }
}
