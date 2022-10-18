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

        public int Insert(T truck)
        {
            return Insert(truck, 0);
        }

        public int Insert(T truck, int position)
        {
            if (position >= 0 && position <= _maxCount && position <= _places.Count && _places.Count + 1 <= _maxCount)
            {
                if (_places[position] == null)
                {
                    _places[position] = truck;
                    return position;
                } else
                {
                    for (int i = _places.Count - 1; i <= position; i--)
                        _places[i] = _places[i + 1];
                    
                }
                 

            }
            else 
                return -1;
        }

        public T Remove(int position)
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
