namespace GasolineTanker
{
    internal class TruckCompareByType : IComparer<IDrawningObject>
    {
        public int Compare(IDrawningObject? x, IDrawningObject? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null && y != null)
            {
                return 1;
            }
            if (x != null && y == null)
            {
                return -1;
            }

            var xTruck = x as DrawningObjectTruck;
            var yTruck = y as DrawningObjectTruck;
            if (xTruck == null && yTruck == null)
            {
                return 0;
            }
            if (xTruck == null && yTruck != null)
            {
                return 1;
            }
            if (xTruck != null && yTruck == null)
            {
                return -1;
            }

            if (xTruck.GetTruck.GetType().Name != yTruck.GetTruck.GetType().Name)
            {
                if (xTruck.GetTruck.GetType().Name == "DrawningTruck")
                {
                    return -1;
                }
                return 1;
            }
            var speedCompare = xTruck.GetTruck.Truck.Speed.CompareTo(yTruck.GetTruck.Truck.Speed);
            if (speedCompare != 0)
            {
                return speedCompare;
            }
            return xTruck.GetTruck.Truck.Weight.CompareTo(yTruck.GetTruck.Truck.Weight);
        }
    }
}
