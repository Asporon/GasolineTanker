﻿namespace GasolineTanker
{
    internal class EntityTruck
    {
        public int Speed { get; private set; }
        public float Weight { get; private set; }
        public Color BodyColor { get; private set; }
        public float Step => Speed * 100 / Weight;

        public void Init(int speed, float weight, Color bodyColor)
        {
            Random rnd = new();
            Speed = speed <= 0 ? rnd.Next(50, 150) : speed;
            Weight = weight <= 0 ? rnd.Next(40, 70) : weight;
            BodyColor = bodyColor;
        }
    }
}