using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] inputs = new int[,]
            {
               {1,2,3,4,5,6,7,8,9},
               {2,3,4,5,6,7,8,9,1},
               {3,4,5,6,7,8,9,1,5},
               {4,5,6,7,8,9,1,5,8},
               {5,6,7,8,9,1,5,6,7},
               {6,7,8,9,1,5,6,7,8},
               {9,8,5,6,7,4,3,2,2},
               {2,3,4,5,6,7,7,8,9},
               {1,2,3,4,5,6,9,8,7 }
            };
            var suduko = new Suduko(inputs);
                Console.WriteLine(suduko[5, 5]);

         /* 
          * Ip ip = new Ip(119, 111, 112, 33); 
            var iip = new Ip(111, 112, 113, 114);

            Console.WriteLine(iip.Address);
            Console.WriteLine(ip.Address);

            var FirstSegment = ip[0];
            Console.WriteLine(FirstSegment);
         */
        }
    }
    public class Suduko
    {
        private int[,] _matrix;
        public int this[int row, int col]
        {
            get
            {
                return _matrix[row, col];
            }
            set {
                _matrix[row, col] = value;
            }
        }
        public Suduko(int[,] matrix)
        {
            _matrix = matrix;

        }
    }

   /*
    *public class Ip
    {
        private int[] segments = new int[4];
        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            { 
                segments[index] = value;
            }
        }

        public Ip(int segment1, int segment2, int segment3,int segment4)
        {
            segments[0]= segment1;  
            segments[1]= segment2;  
            segments[2]= segment3;
            segments[3]= segment4;
        }
        public string Address => string.Join(".", segments);

    }
   */
}