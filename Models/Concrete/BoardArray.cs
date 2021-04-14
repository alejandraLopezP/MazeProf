using System;
using System.Collections.Generic;
using Logic.Infrastructure;
using Logic.Models;

namespace Logic.Models.Concrete
{
    public class BoardArray : IBoard
    {
        private int[,] InternalBoard { get; set; }
        public BoardArray()
        {
            InternalBoard= new int[3,3];
        }
        public int this[int f, int c]
        {
            get
            {
                return InternalBoard[f, c];
            }
            set
            {
                this.InternalBoard[f, c] = value;
            }
        }

        public int NumCols
        {
            get
            {
                return this.InternalBoard.GetLength(1);
            }
        }
        public int NumRaws 
        {
            get
            {
                return this.InternalBoard.GetLength(0);
            }
        }

        public void FillBoard()
        {
            FillBoardDummy();
            //FillBoardProperly();
        }

        

        public List<Coordinate> SolveBoard()
        {
            throw new NotImplementedException();
        }

        private void FillBoardDummy()
        {

            /*
            x 0 0
            0 x 0
            c 0 0
            */

            //filling wals with -1 (diagonal)
            InternalBoard[0,0]=-1;
            InternalBoard[1,1]= -1;
            

            //filling food with 1
            InternalBoard[2,0] =1;

            //empty spaces dont need to be filled
            //cuz arrays are initialized with 0 by default;
        }
    }
}