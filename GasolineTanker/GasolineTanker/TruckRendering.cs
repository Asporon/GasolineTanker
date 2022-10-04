namespace GasolineTanker
{
    internal class TruckRendering
    {
        public EntityTruck Truck { get; private set; }

        private float _startPosX;
        private float _startPosY;
        private int? _pictureWidth = null;
        private int? _pictureHeight = null;
        private readonly int _truckWidth = 80;
        private readonly int _truckHeight = 70;

        public void Init(int speed, float weight, Color bodyColor)
        {
            Truck = new EntityTruck();
            Truck.Init(speed, weight, bodyColor);
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            if (x > 0 && y > 0 && width > 0 && height > 0 &&  x < width && y < height)
            {
                _startPosX = x;
                _startPosY = y;
                _pictureWidth = width;
                _pictureHeight = height;
            }
        }

        public void MoveTransport(Directions direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                //12.
                case Directions.Up:
                    if (_startPosY - Truck.Step > 0)
                    {
                        _startPosY -= Truck.Step;
                    }
                    break;
                //3.
                case Directions.Right:
                    if (_startPosX + _truckWidth + Truck.Step < _pictureWidth)
                    {
                        _startPosX += Truck.Step;
                    }
                    break;
                //6.
                case Directions.Down:
                    if (_startPosY + _truckHeight + Truck.Step < _pictureHeight)
                    {
                        _startPosY += Truck.Step;
                    }
                    break;
                //9.
                case Directions.Left:
                    if (_startPosX - Truck.Step > 0)
                    {
                        _startPosX -= Truck.Step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            if (_startPosX < 0 || _startPosY < 0
                || !_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }

            //Кабина и рама.
            Brush brRandom = new SolidBrush(Truck?.BodyColor ?? Color.Black);
            g.FillRectangle(brRandom, _startPosX + 60, _startPosY, 20, 30);
            g.FillRectangle(brRandom, _startPosX, _startPosY + 35, 80, 15);

            //Колёса.
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX, _startPosY + 50, 20, 20);
            g.FillEllipse(brBlack, _startPosX + 20, _startPosY + 50, 20, 20);
            g.FillEllipse(brBlack, _startPosX + 60, _startPosY + 50, 20, 20);
        }

        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= _truckWidth || _pictureHeight <= _truckHeight)
            {
                _pictureWidth = null;
                _pictureHeight = null;
                return;
            }
            if (_startPosX + _truckWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - _truckWidth;
            }
            if (_startPosY + _truckHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - _truckHeight;
            }
        }
    }
}
