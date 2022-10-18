namespace GasolineTanker
{
    internal class SetTrucksGeneric<T>
        where T : class
    {
		private readonly List<T> _places;
        public int Count => _places.Count;
        private readonly int _maxCount;

        public SetTrucksGeneric(int count)
        {
            _maxCount = count;
            _places = new List<T>();
        }

        public bool Insert(T truck)
        {

        }

        public bool Insert(T truck, int position)
        {

        }

        public bool Remove(int position)
        {

        }

        public T this[int position]
        {
            get
            {
                // TODO проверка позиции
                return _places[position];
            }
            set
            {
                // TODO проверка позиции
                // TODO вставка в список по позиции
            }
        }

        public IEnumerable<T> GetTrucks()
        {
            foreach (var truck in _places)
            {
                if (truck != null)
                {
                    yield return truck;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}
