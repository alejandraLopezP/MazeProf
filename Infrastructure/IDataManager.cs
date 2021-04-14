using System;
using Logic.Models;

namespace Logic.Infrastructure
{
    public interface IDataManager
    {
        bool Save(DTO dataToSave);

        DTO Load();
    }
}