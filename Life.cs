using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLife
{
    class Life
    {
        const int BoardSize = 60;
        char[,] mainBoard = new char[BoardSize, BoardSize];
        char[,] bufferBoard = new char[BoardSize, BoardSize];
        public Life()
        {
            //init two boards
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; row++)
                {
                    //process the array
                    Console.Write(mainBoard[row,col]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //make a new game and play it
            Life game = new Life();


        }
    }
}
