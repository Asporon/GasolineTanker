using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineTanker
{
    internal abstract class AbstractMap
    {
        private IDrawningObject _drawningObject = null;
        protected int[,] _map = null;
        protected int _width;
        protected int _height;
        protected float _size_x;
        protected float _size_y;
        protected readonly Random _random = new();
        protected readonly int _freeRoad = 0;
        protected readonly int _barrier = 1;

        public Bitmap CreateMap(int width, int height, IDrawningObject drawningObject)
        {
            _width = width;
            _height = height;
            _drawningObject = drawningObject;
            GenerateMap();
            while (!SetObjectOnMap())
            {
                GenerateMap();
            }
            return DrawMapWithObject();
        }

        public Bitmap MoveObject(Direction direction)
        {
            _drawningObject.MoveObject(direction);
            if(!CheckCollisison())
            {
                switch (direction)
                {
                    case Direction.Up:
                        _drawningObject.MoveObject(Direction.Down);
                        break;
                    case Direction.Right:
                        _drawningObject.MoveObject(Direction.Left);
                        break;
                    case Direction.Down:
                        _drawningObject.MoveObject(Direction.Up);
                        break;
                    case Direction.Left:
                        _drawningObject.MoveObject(Direction.Right);
                        break;
                }
            }

            return DrawMapWithObject();
        }
        private bool SetObjectOnMap()
        {
            if (_drawningObject == null || _map == null)
            {
                return false;
            }
            int x = _random.Next(1, 10);
            int y = _random.Next(1, 10);
            _drawningObject.SetObject(x, y, _width, _height);

            return CheckCollisison(); 
        }
        private bool CheckCollisison()
        {
            (float left, float right, float top, float bottom) = _drawningObject.GetCurrentPosition();
            for (int i = (int)(top / _size_y); i < (int)(bottom / _size_y) + 1; i++)
            {
                for (int j = (int)(left / _size_x); j < (int)(right / _size_x) + 1; j++)
                {
                    if (_map[i, j] == _barrier)
                        return false;
                }
            }
            return true;
        }

        private Bitmap DrawMapWithObject()
        {
            Bitmap bmp = new(_width, _height);
            if (_drawningObject == null || _map == null)
            {
                return bmp;
            }
            Graphics gr = Graphics.FromImage(bmp);
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    if (_map[i, j] == _freeRoad)
                    {
                        DrawRoadPart(gr, i, j);
                    }
                    else if (_map[i, j] == _barrier)
                    {
                        DrawBarrierPart(gr, i, j);
                    }
                }
            }
            _drawningObject.DrawningObject(gr);
            return bmp;
        }

        protected abstract void GenerateMap();
        protected abstract void DrawRoadPart(Graphics g, int i, int j);
        protected abstract void DrawBarrierPart(Graphics g, int i, int j);
    }
}
