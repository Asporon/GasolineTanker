﻿namespace GasolineTanker
{
    internal class MapWithSetTrucksGeneric<T, U>
        where T : class, IDrawningObject, IEquatable<T>
        where U : AbstractMap
    {
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;
        private readonly int _placeSizeWidth = 110;
        private readonly int _placeSizeHeight = 90;
        private readonly SetTrucksGeneric<T> _setTrucks;
        private readonly U _map;

        public MapWithSetTrucksGeneric(int picWidth, int picHeight, U map)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _setTrucks = new SetTrucksGeneric<T>(width * height);
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _map = map;
        }

        public static int operator +(MapWithSetTrucksGeneric<T, U> map, T truck)
        {
            return map._setTrucks.Insert(truck);
        }
        public static T operator -(MapWithSetTrucksGeneric<T, U> map, int position)
        {
            return map._setTrucks.Remove(position);
        }

        public Bitmap ShowSet()
        {
            Bitmap bmp = new(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp);
            DrawBackground(gr);
            DrawTrucks(gr);
            return bmp;
        }

        public string GetData(char separatorType, char separatorData)
        {
            string data = $"{_map.GetType().Name}{separatorType}";
            foreach (var car in _setTrucks.GetTrucks())
            {
                data += $"{car.GetInfo()}{separatorData}";
            }
            return data;
        }
        public void LoadData(string[] records)
        {
            foreach (var rec in records)
            {
                _setTrucks.Insert(DrawningObjectTruck.Create(rec) as T);
            }
        }

        public void Sort(IComparer<T> comparer)
        {
            _setTrucks.SortSet(comparer);
        }

        public Bitmap ShowOnMap()
        {
            Shaking();
            foreach (var truck in _setTrucks.GetTrucks())
            {
                return _map.CreateMap(_pictureWidth, _pictureHeight, truck);
            }
            return new(_pictureWidth, _pictureHeight);
        }

        public Bitmap MoveObject(Direction direction)
        {
            if (_map != null)
            {
                return _map.MoveObject(direction);
            }
            return new(_pictureWidth, _pictureHeight);
        }

        private void Shaking()
        {
            int j = _setTrucks.Count - 1;
            for (int i = 0; i < _setTrucks.Count; i++)
            {
                if (_setTrucks[i] == null)
                {
                    for (; j > i; j--)
                    {
                        var Truck = _setTrucks[j];
                        if (Truck != null)
                        {
                            _setTrucks.Insert(Truck, i);
                            _setTrucks.Remove(j);
                            break;
                        }
                    }
                    if (j <= i)
                    {
                        return;
                    }
                }
            }
        }

        private void DrawBackground(Graphics g)
        {
            Brush asphaltColor = new SolidBrush(Color.Gray);
            g.FillRectangle(asphaltColor, 0, 0, _pictureWidth, _pictureHeight);

            Pen pen = new(Color.Yellow, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        private void DrawTrucks(Graphics g)
        {
            int xStartPos = 10;
            int yStartPos = (_pictureHeight / _placeSizeHeight - 1) * _placeSizeHeight + 5;

            foreach (var truck in _setTrucks.GetTrucks())
            {
                truck.SetObject(xStartPos, yStartPos, _pictureWidth, _pictureHeight);
                truck.DrawningObject(g);

                xStartPos += _placeSizeWidth;
                if (xStartPos + _placeSizeWidth > _pictureWidth)
                {
                    yStartPos -= _placeSizeHeight;
                    xStartPos = 10;
                }
            }
        }
    }
}
