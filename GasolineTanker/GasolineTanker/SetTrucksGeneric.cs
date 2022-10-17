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

        public bool Insert(T truck)
        {
            // TODO вставка в начало набора
            return true;
        }

        public bool Insert(T truck, int position)
        {
            // TODO проверка позиции
            // TODO проверка, что элемент массива по этой позиции пустой, если нет, то
            //		проверка, что после вставляемого элемента в массиве есть пустой элемент
            //		сдвиг всех объектов, находящихся справа от позиции до первого пустого элемента
            // TODO вставка по позиции
            _places[position] = truck;
            return true;
        }

        public bool Remove(int position)
        {
            // TODO проверка позиции
            // TODO удаление объекта из массива, присовив элементу массива значение null
            return true;
        }

        public T Get(int position)
        {
            // TODO проверка позиции
            return _places[position];
        }
    }
}
