namespace GasolineTanker
{
    internal class TruckCompareByColor : IComparer<IDrawningObject>
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

            var bodyColorCompare = xTruck.GetTruck.Truck.BodyColor.ToArgb().CompareTo(yTruck.GetTruck.Truck.BodyColor.ToArgb());
            if (bodyColorCompare != 0)
            {
                return bodyColorCompare;
            }
            if (xTruck.GetTruck.Truck is EntityGasolineTanker xGasolineTanker &&
                yTruck.GetTruck.Truck is EntityGasolineTanker yGasolineTanker)
            {
                var dopColorCompare = xGasolineTanker.DopColor.ToArgb().CompareTo(yGasolineTanker.DopColor.ToArgb());
                if (dopColorCompare != 0)
                {
                    return dopColorCompare;
                }
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
