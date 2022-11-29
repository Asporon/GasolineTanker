namespace GasolineTanker
{
    internal class MapsCollection
    {
        readonly Dictionary<string, MapWithSetTrucksGeneric<IDrawningObject, AbstractMap>> _mapStorages;
        public List<string> Keys => _mapStorages.Keys.ToList();

        private readonly int _pictureWidth;
        private readonly int _pictureHeight;

        private readonly char separatorDict = '|';
        private readonly char separatorData = ';';

        public MapsCollection(int pictureWidth, int pictureHeight)
        {
            _mapStorages = new Dictionary<string, MapWithSetTrucksGeneric<IDrawningObject, AbstractMap>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        public void AddMap(string name, AbstractMap map)
        {
            if (!Keys.Contains(name)) {
                Keys.Add(name);
                _mapStorages.Add(name, new MapWithSetTrucksGeneric<IDrawningObject, AbstractMap>
                    (_pictureWidth, _pictureHeight, map));
            }
        }
        public void DelMap(string name)
        {
            if (Keys.Contains(name))
            {
                Keys.Remove(name);
                _mapStorages.Remove(name);
            }
        }
        public MapWithSetTrucksGeneric<IDrawningObject, AbstractMap> this[string ind]
        {
            get
            {
                if (Keys.Contains(ind))
                    return _mapStorages[ind];
                else
                    return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new(filename))
            {
                sw.WriteLine($"MapsCollection");
                foreach (var storage in _mapStorages)
                {
                    sw.WriteLine($"{storage.Key}{separatorDict}{storage.Value.GetData(separatorDict, separatorData)}");
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Файл не найден");
            }

            string bufferStringFromFile = "";
            using (StreamReader sr = new(filename))
            {
                bufferStringFromFile = sr.ReadLine();
                if (bufferStringFromFile == null || !bufferStringFromFile.Contains("MapsCollection"))
                {
                    throw new FileFormatException("Формат данных в файле не правильный");
                }

                _mapStorages.Clear();
                while ((bufferStringFromFile = sr.ReadLine()) != null)
                {
                    var elem = bufferStringFromFile.Split(separatorDict);
                    AbstractMap map = null;
                    switch (elem[1])
                    {
                        case "SimpleMap":
                            map = new SimpleMap();
                            break;
                        case "OilStorageMap":
                            map = new OilStorageMap();
                            break;
                    }
                    _mapStorages.Add(elem[0], new MapWithSetTrucksGeneric<IDrawningObject, AbstractMap>(_pictureWidth, _pictureHeight, map));
                    _mapStorages[elem[0]].LoadData(elem[2].Split(separatorData, StringSplitOptions.RemoveEmptyEntries));
                }
            }
        }
    }
}
