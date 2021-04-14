using System;
using Logic.Models;
using Logic.Infrastructure;
using System.IO;

namespace Logic.Models.Concrete
{
    public class DataManagerTXT : IDataManager
    {
        public DTO Load()
        {
            throw new NotImplementedException();
        }

        public bool Save(DTO dataToSave)
        {
            string path ="status.txt";

            FileStream f = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);

            sw.WriteLine(dataToSave.Points);
            sw.WriteLine(dataToSave.CurrentPosition);
            sw.WriteLine(dataToSave.UserBoard);

            sw.Close();
            f.Close();

            throw new NotImplementedException();
        }
    }
}