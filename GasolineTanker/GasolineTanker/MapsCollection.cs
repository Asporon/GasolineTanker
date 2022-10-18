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
            // TODO Прописать логику для добавления
        }
        public void DelMap(string name)
        {
            // TODO Прописать логику для удаления
        }
        public MapWithSetTrucksGeneric<DrawningObjectTruck, AbstractMap> this[string ind]
        {
            get
            {
                // TODO Продумать логику получения объекта
                return null;
            }
        }
    }
}
