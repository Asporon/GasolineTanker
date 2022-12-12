namespace GasolineTanker
{
    internal class DrawningObjectTruck : IDrawningObject
    {
        private DrawningTruck _truck = null;

        public DrawningObjectTruck(DrawningTruck truck)
        {
            _truck = truck;
        }

        public DrawningTruck GetTruck => _truck;

        public float Step => _truck?.Truck?.Step ?? 0;

        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return _truck?.GetCurrentPosition() ?? default;
        }

        public void MoveObject(Direction direction)
        {
            _truck?.MoveTransport(direction);
        }

        public void SetObject(int x, int y, int width, int height)
        {
            _truck.SetPosition(x, y, width, height);
        }

        void IDrawningObject.DrawningObject(Graphics g)
        {
            _truck.DrawTransport(g);
        }

        public string GetInfo() => _truck?.GetDataForSave();

        public static IDrawningObject Create(string data) => new DrawningObjectTruck(data.CreateDrawningTruck());

        public bool Equals(IDrawningObject? other)
        {
            if (other == null)
            {
                return false;
            }

            var otherTruck = other as DrawningObjectTruck;
            if (otherTruck == null)
            {
                return false;
            }

            var truck = _truck.Truck;
            var otherTruckTruck = otherTruck._truck.Truck;
            if (truck.GetType().Name != otherTruckTruck.GetType().Name)
            {
                return false;
            }
            if (truck.Speed != otherTruckTruck.Speed)
            {
                return false;
            }
            if (truck.Weight != otherTruckTruck.Weight)
            {
                return false;
            }
            if (truck.BodyColor != otherTruckTruck.BodyColor)
            {
                return false;
            }

            if (truck is EntityGasolineTanker gasolineTanker &&
                otherTruckTruck is EntityGasolineTanker otherGasolineTanker)
            {
                if (gasolineTanker.DopColor != otherGasolineTanker.DopColor)
                {
                    return false;
                }
                if (gasolineTanker.Сistern != otherGasolineTanker.Сistern)
                {
                    return false;
                }
                if (gasolineTanker.Flasher != otherGasolineTanker.Flasher)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
