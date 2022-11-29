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
            if (Count == _maxCount)
                throw new StorageOverflowException(_maxCount);
            
            if (position >= 0 && position <= _places.Count)
            {
                _places.Insert(position, truck); 
                return position;
            }
            else
                return -1;
        }

        public T Remove(int position)
        {
            if (position < 0 || position >= Count)
            {
                throw new TruckNotFoundException(position);
            }

            var truck = _places[position];
            _places.RemoveAt(position);
            return truck;
        }

        public T this[int position]
        {
            get
            {
                if (position < _places.Count)
                    return _places[position];
                else
                    throw new Exception("IndexOutOfRangeException");
            }
            set
            {
                Insert(value, position);
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
