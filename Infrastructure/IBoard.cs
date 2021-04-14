using System;
using System.Collections.Generic;
using Logic.Models;

namespace Logic.Infrastructure
{
    public interface IBoard
    {
        
        int NumCols { get; }
        int NumRaws { get; }

        int this [int f,int c]{ get; set; }

        void FillBoard();

        List<Coordinate> SolveBoard();


    }
}