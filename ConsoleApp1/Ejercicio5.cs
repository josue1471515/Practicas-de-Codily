using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ejercicio5
    {
        public int solution(int[] A) {
            int n = A.Length + 1;
            int totalSum = (n * (1 + n)) / 2;
            int arraySum = 0;
            for (int i = 0; i < A.Length; i ++)
            {
                arraySum += A[i];
            }
            int result = totalSum - arraySum;
            return result;
        }
    }
}
