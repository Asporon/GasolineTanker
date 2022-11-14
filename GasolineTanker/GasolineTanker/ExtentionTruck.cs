namespace GasolineTanker
{
    internal static class ExtentionTruck
    {
        private static readonly char _separatorForObject = ':';

        public static DrawningTruck CreateDrawningTruck(this string info)
        {
            string[] strs = info.Split(_separatorForObject);
            if (strs.Length == 3)
            {
                return new DrawningTruck(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]));
            }
            if (strs.Length == 6)
            {
                return new DrawningGasolineTanker(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]),
                    Color.FromName(strs[3]), Convert.ToBoolean(strs[4]),
                    Convert.ToBoolean(strs[5]));
            }
            return null;
        }

        public static string GetDataForSave(this DrawningTruck drawningTruck)
        {
            var truck = drawningTruck.Truck;
            var str = $"{truck.Speed}{_separatorForObject}{truck.Weight}{_separatorForObject}{truck.BodyColor.Name}";
            if (truck is not EntityGasolineTanker gasolineTanker)
            {
                return str;
            }
            return $"{str}{_separatorForObject}{gasolineTanker.DopColor.Name}{_separatorForObject}{gasolineTanker.Сistern}" +
                $"{_separatorForObject}{gasolineTanker.Flasher}";
        }
    }
}
