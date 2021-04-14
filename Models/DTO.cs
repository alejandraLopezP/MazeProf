using System;
using Logic.Infrastructure;
using Logic.Models;

namespace Logic.Models
{
    public class DTO
    {
        public int Points { get; set; }
        public IBoard UserBoard { get; set; }
        public Coordinate CurrentPosition { get; set; }

        public bool Status { get; set; }
    }
}