﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zapis_app
{
    public class DataHandler
    {
        public List<string> zakladniSkoly = new List<string> { "Čapkova", "Masarykova", "Plánická", "Tolstého" };
        public string rok = "2022/2023";
        public string akt_rok = "";
        public int celkemDeti; 

        public string fileCSV = "databaze.csv";
        public List<Record> records = new List<Record>();
       
        public void LoadDB(string fileCSV)
        {
            string radky;
            using (StreamReader sr = new StreamReader(fileCSV, Encoding.UTF8))
            {
                while((radky = sr.ReadLine()) != null)
                {
                    string[] sloupce = radky.Split(';');
                    records.Add(new Record(Int32.Parse(sloupce[0]), sloupce[1], sloupce[2], sloupce[3], sloupce[4], sloupce[5]));
                }
            }
            celkemDeti = records.Count;
            
        }

        public List<Record> SortData(string aktualniZS)
        {
            LoadDB(fileCSV);
            // třídit podle příjmení vzestupně a pouze aktuální škola
            var sorted = from rec in records where rec.Skola == aktualniZS orderby rec.Prijmeni select rec;
            return (List<Record>)sorted.ToList();
        }



    }
}
