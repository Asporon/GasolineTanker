﻿namespace GasolineTanker
{
    internal class MapWithSetTrucksGeneric<T, U>
        where T : class, IDrawningObject
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

        public static bool operator +(MapWithSetTrucksGeneric<T, U> map, T truck)
        {
            if (map._setTrucks.Insert(truck) >= 0)
                return true;
            else return false;
        }
        public static bool operator -(MapWithSetTrucksGeneric<T, U> map, int position)
        {
            if (map._setTrucks.Remove(position) != null)
                return true;
            else return false;
        }

        public Bitmap ShowSet()
        {
            Bitmap bmp = new(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp);
            DrawBackground(gr);
            DrawTrucks(gr);
            return bmp;
        }

        public Bitmap ShowOnMap()
        {
            Shaking();
            for (int i = 0; i < _setTrucks.Count; i++)
            {
                var Truck = _setTrucks.Get(i);
                if (Truck != null)
                {
                    return _map.CreateMap(_pictureWidth, _pictureHeight, Truck);
                }
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
                if (_setTrucks.Get(i) == null)
                {
                    for (; j > i; j--)
                    {
                        var Truck = _setTrucks.Get(j);
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
            
            for (int i = 0; i < _setTrucks.Count; i++)
            {
                _setTrucks.Get(i)?.SetObject(xStartPos, yStartPos, _pictureWidth, _pictureHeight);
                _setTrucks.Get(i)?.DrawningObject(g);

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
