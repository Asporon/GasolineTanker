namespace GasolineTanker
{
    internal class DrawningObjectTruck : IDrawningObject
    {
        private DrawningTruck _truck = null;

        public DrawningObjectTruck(DrawningTruck truck)
        {
            _truck = truck;
        }

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
    }
}
