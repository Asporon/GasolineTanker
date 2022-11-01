namespace GasolineTanker
{
    public class EntityTruck
    {
        public int Speed { get; private set; }
        public float Weight { get; private set; }
        public Color BodyColor { get; private set; }
        public float Step => Speed * 100 / Weight;

        public EntityTruck(int speed, float weight, Color bodyColor)
        {
            Random rnd = new();
            Speed = speed <= 0 ? rnd.Next(50, 150) : speed;
            Weight = weight <= 0 ? rnd.Next(40, 70) : weight;
            BodyColor = bodyColor;
        }

        public void ChangeBaseColor(Color newBaseColor) { BodyColor = newBaseColor; }
    }
}