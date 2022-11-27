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
            if (_places.Count + 1 <= _maxCount)
            {
                _places.Insert(0, truck);
                return 0;
            }
            else
                return -1;
        }

        public int Insert(T truck, int position)
        {
            if (_places.Count + 1 == _maxCount)
                throw new StorageOverflowException();
            
            if (position <= _places.Count && _places.Count + 1 <= _maxCount)
            {
                _places.Insert(position, truck); 
                return position;
            }
            else
                return -1;
        }

        public T Remove(int position)
        {
            if (_places[position] == null)
                throw new TruckNotFoundException();
            
            if (position < _places.Count)
            {
                var truck = _places[position];
                _places.RemoveAt(position);       
                return truck;
            }
            else
                return null;
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
