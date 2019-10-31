using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ejercicio3
    {
        // stack move 
        //An array A consisting of N integers is given.Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place.For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7](elements are shifted right by one index and 6 is moved to the first place).

        //The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times
        //https://app.codility.com/demo/results/trainingA6H9WD-JDA/
        public int[] solution(int[] A, int k)
        {
            if (A.Length > 0)
            {
                Stack<int> MyStack = new Stack<int>();
                MyStack = ConvertStack(A);

                for (int i = 0; i < k; i++)
                {
                    int lastItem = MyStack.Pop();
                    MyStack = ConvertStack(MyStack.ToArray());
                    MyStack.Push(lastItem);
                    MyStack = ConvertStack(MyStack.ToArray());
                }
                MyStack = ConvertStack(MyStack.ToArray());
                return MyStack.ToArray();
            }
            else
            {
                return A;
            }
        }


        public Stack<int> ConvertStack(int[] A)
        {
            Stack<int> myStack = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                myStack.Push(A[i]);
            }
            return myStack;
        }
    }
}
