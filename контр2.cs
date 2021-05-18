using System;

namespace контр2
{
    class Program
    {
        static bool BolResult (float res)
        {
            if (res >= 0) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("кол-во отрезков");
            int n = 2 * int.Parse(Console.ReadLine());

            float[] coordsX = new float[n];
            float[] coordsY = new float[n];

            Console.WriteLine("Введите координаты X начало и конец каждого из отрезков");
            for(int i = 0; i < n; i++)
            {
                coordsX[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите координаты Y начало и конец каждого из отрезков");
            for (int i = 0; i < n; i++)
            {
                coordsY[i] = float.Parse(Console.ReadLine());
            }

            int countLines = n / 2;


            bool CheckFinalResult(float[] coordsX, float[] coordsY)
            {
                bool metka = true;
                int number = 0;
                if (metka)
                {
                    metka = false;
                    for (int i = number; i < n - 4; i++)
                    {
                        if (AlgorithThree(coordsX[number], coordsY[number], coordsX[number + 1], coordsY[number + 1],
                            coordsX[i + 2], coordsY[i + 2], coordsX[i + 3], coordsY[i + 3]))
                        {
                            metka = true;
                            break;
                        }
                    }
                    return metka; 
                }
            }

            bool AlgorithThree(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
            {
                float[] dot = new float[3];
                float n;
                if (y2 - y1 != 0)
                { 
                    float q = (x2 - x1) / (y1 - y2);
                    float sn = (x3 - x4) + (y3 - y4) * q; if (!BolResult(sn)) { return false; }  
                    float fn = (x3 - x1) + (y3 - y1) * q;   
                    n = fn / sn;
                }
                else
                {
                    if (!BolResult(y3 - y4)) { return false; }  
                    n = (y3 - y1) / (y3 - y4);   
                }
                dot[0] = x3 + (x4 - x3) * n;  
                dot[1] = y3 + (y4 - y3) * n;  
                return true;
            }
        }
    }

    

}
