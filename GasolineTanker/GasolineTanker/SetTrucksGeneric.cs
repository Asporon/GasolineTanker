namespace GasolineTanker
{
    internal class SetTrucksGeneric<T>
        where T : class
    {
		private readonly T[] _places;
        public int Count => _places.Length;

        public SetTrucksGeneric(int count)
        {
            _places = new T[count];
        }

        public int Insert(T truck)
        {
            bool freeSpace = false;
            int firstFreeElement = -1;
            for (int i = Count - 1; i >= 0; i--)
            {
                if (_places[i] == null)
                {
                    freeSpace = true;
                    firstFreeElement = i;
                }
            }
            if (!freeSpace)
                return -1;

            for (int i = firstFreeElement - 1; i >= 0; i--)
            {
                _places[i + 1] = _places[i];
            }
            _places[0] = truck;

            return 0;
        }

        public int Insert(T truck, int position)
        {
            if (_places[position] != null)
            {
                bool freeSpace = false;
                int firstFreeElement = -1;
                for (int i = Count - 1; i < position; i--)
                {
                    if (_places[i] == null)
                    {
                        freeSpace = true;
                        firstFreeElement = i;
                    }
                }
                if (!freeSpace)
                    return -1;

                for (int i = firstFreeElement - 1; i > position; i--)
                {
                    _places[i + 1] = _places[i];
                }
            }
            _places[position] = truck;
            return position;
        }

        public T Remove(int position)
        {
            if (_places[position] != null)
            {
                T result = _places[position];
                _places[position] = null;
                return result;
            } else
                return null;
        }

        public T Get(int position)
        {
            if (_places[position] != null)
                return _places[position];
            else return null;
        }
    }
}
