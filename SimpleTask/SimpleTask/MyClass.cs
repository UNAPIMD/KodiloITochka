using System;

namespace SimpleTask
{
    public static class MyClass
    {
        /// <summary>
        /// Задача с LeetCode 11. Container With Most Water
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxArea(int[] height)
        {
            if (height == null) throw new ArgumentNullException("height is null");
            if (height.Length == 0) throw new ArgumentOutOfRangeException("Length of height is 0");

            int left = 0; //Левая граница ёмкости
            int right = height.Length - 1; //Правая граница ёмкости
            int V = 0; //Искомый объём
            while (left < right)
            {
                V = Math.Max(V, Math.Min(height[left], height[right]) * (right - left));
                //Необходимо передвигать границу с наименьшей высотой, иначе - объём жидкости только уменьшится
                if (height[left] < height[right]) left++;
                else right--;
            }
            return V;
        }
    }
}
