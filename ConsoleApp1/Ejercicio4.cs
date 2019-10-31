using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ejercicio4
    {

        //A small frog wants to get to the other side of the road.The frog is currently located at position X and wants to get to a position greater than or equal to Y.The small frog always jumps a fixed distance, D.
        //Count the minimal number of jumps that the small frog must perform to reach its target.
        //https://app.codility.com/demo/results/trainingA5P3NW-G5K/
        public int solution(int X, int Y, int D)
        {
            if (X <= Y)
            {
                int camino =   Y - X;
                int saltos = camino / D;
                if (D*saltos < camino) {
                    saltos++;
                }
                return saltos;
            }
            else {
                return 0;
            }

        }
    }
}
