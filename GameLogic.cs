using System;
using Logic.Models;
using Logic.Infrastructure;

namespace Logic
{
    public class GameLogic
    {
        public IDataManager Manager { get; set; }
        public int Points { get; set; }
        public IBoard UserBoard { get; set; }
        public Coordinate CurrentPosition { get; set; }

        public GameLogic()
        {

        }

        //public members
        public bool Move(int f, int c, Direction d)
        {
            if (!PossibleMove(f, c, d))
                return false;
            else
            {
                //haremos el movimiento
                return true;
            }
        }

        public bool SaveProgress()
        {
            DTO dataToSave = new DTO()
            {
                CurrentPosition = this.CurrentPosition,
                UserBoard = this.UserBoard,
                Points = this.Points
            };
            return Manager.Save(dataToSave);
        }

        public bool LoadProgress()
        {
            var dto = Manager.Load();
            if (!dto.Status)
            {
                return false;
            }
            else
            {
                AssignData(dto);
                return true;

            }
        }




        //private members
        private void AssignData(DTO dto)
        {
            this.Points = dto.Points;
            this.UserBoard = dto.UserBoard;
            this.CurrentPosition = dto.CurrentPosition;
        }
        private bool PossibleMove(int f, int c, Direction d)
        {
            throw new NotImplementedException();
        }
    }
}
