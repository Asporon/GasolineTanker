using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineTanker
{
    internal class OilStorageMap : AbstractMap
    {
        private readonly Brush tankColor = new SolidBrush(Color.White);
        private readonly Pen logoPen = new Pen(Color.Red);
        private readonly Brush roadColor = new SolidBrush(Color.Gray);
        
        protected override void DrawBarrierPart(Graphics g, int i, int j)
        {
            g.FillRectangle(roadColor, i * _size_x, j * _size_y, _size_x, _size_y);
            g.FillEllipse(tankColor, i * _size_x, j * _size_y, _size_x, _size_y);
            g.DrawEllipse(logoPen, i * _size_x, j * _size_y, _size_x, _size_y);
        }
        protected override void DrawRoadPart(Graphics g, int i, int j)
        {
            g.FillRectangle(roadColor, i * _size_x, j * _size_y, _size_x, _size_y);
        }

        protected override void GenerateMap()
        {
            _map = new int[39, 26];
            _size_x = (float)_width / _map.GetLength(0);
            _size_y = (float)_height / _map.GetLength(1);
            int counter = 0;
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    _map[i, j] = _freeRoad;
                }
            }
            while (counter < 20)
            {
                int x = _random.Next(0, 39);
                int y = _random.Next(0, 26);
                if (_map[x, y] == _freeRoad)
                {
                    _map[x, y] = _barrier;
                    counter++;
                }
            }
        }
    }

}
