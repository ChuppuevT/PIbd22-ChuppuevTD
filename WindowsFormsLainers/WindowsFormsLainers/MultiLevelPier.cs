using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLainers
{
    class MultiLevelPier
    {
        List<Pier<ITransport>> pierStages;
        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;
        public MultiLevelPier(int countStages, int pictureWidth, int pictureHeight)
        {
            pierStages = new List<Pier<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                pierStages.Add(new Pier<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }

        public Pier<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < pierStages.Count)
                {
                    return pierStages[ind];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                //Записываем количество уровней
                fs.WriteLine("CountLeveles:" + pierStages.Count);
                foreach (var level in pierStages)
                {
                    //Начинаем уровень
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var ship = level[i];
                            if (ship.GetType().Name == "Ship")
                            {
                                fs.Write(i + ":Ship:");
                            }
                            if (ship.GetType().Name == "Lainer")
                            {
                                fs.Write(i + ":Lainer:");
                            }
                            //Записываемые параметры
                            fs.WriteLine(ship);
                        }
                        finally { }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader fs = new StreamReader(filename, System.Text.Encoding.Default))
            {
                int counter = -1;
                ITransport ship = null;
                string line;
                line = fs.ReadLine();
                if (line.Contains("CountLeveles"))
                {
                    //считываем количество уровней
                    int count = Convert.ToInt32(line.Split(':')[1]);
                    if (pierStages != null)
                    {
                        pierStages.Clear();
                    }
                    pierStages = new List<Pier<ITransport>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                while (true)
                {
                    line = fs.ReadLine();
                    if (line == null)
                        break;
                    //идем по считанным записям
                    if (line == "Level")
                    {
                        counter++;
                        pierStages.Add(new Pier<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(':')[1] == "Ship")
                    {
                        ship = new Ship(line.Split(':')[2]);
                    }
                    else if (line.Split(':')[1] == "Lainer")
                    {
                        ship = new Lainer(line.Split(':')[2]);
                    }
                    pierStages[counter][Convert.ToInt32(line.Split(':')[0])] = ship;
                }
            }
        }
    }
}
