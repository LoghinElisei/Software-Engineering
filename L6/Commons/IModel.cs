using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IModel
    {
        bool Add(City city);

        bool DataExists();

        bool Delete(string cityName);

        int CityCount { get; }

        void InitializeData();

        string ListAll();

        bool SaveData();

        bool Exists(string cityName);

        City Search(string cityName);
    }

