using System.Xml.Linq;

namespace GasolineTanker
{
    internal class MapsCollection
    {
        readonly Dictionary<string, MapWithSetTrucksGeneric<DrawningObjectTruck, AbstractMap>> _mapStorages;
        public List<string> Keys => _mapStorages.Keys.ToList();

        private readonly int _pictureWidth;
        private readonly int _pictureHeight;

        public MapsCollection(int pictureWidth, int pictureHeight)
        {
            _mapStorages = new Dictionary<string, MapWithSetTrucksGeneric<DrawningObjectTruck, AbstractMap>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }

        public void AddMap(string name, AbstractMap map)
        {
            if (!Keys.Contains(name)) {
                Keys.Add(name);
                _mapStorages.Add(name, new MapWithSetTrucksGeneric<DrawningObjectTruck, AbstractMap>
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
        public MapWithSetTrucksGeneric<DrawningObjectTruck, AbstractMap> this[string ind]
        {
            get
            {
                if (Keys.Contains(ind))
                    return _mapStorages[ind];
                else
                    return null;
            }
        }
    }
}
