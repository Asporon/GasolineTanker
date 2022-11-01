using System.Net.NetworkInformation;

namespace GasolineTanker
{
    internal class EntityGasolineTanker : EntityTruck
    {
        public Color DopColor { get; private set; }
        public bool Сistern { get; private set; }
        public bool Flasher { get; private set; }

        public EntityGasolineTanker(int speed, float weight, Color bodyColor, Color dopColor, bool cistern, bool flasher) :
            base(speed, weight, bodyColor)
        {
            DopColor = dopColor;
            Сistern = cistern;
            Flasher = flasher;
        }

        public void ChangeDopColor(Color newBaseColor) { DopColor = newBaseColor; }
    }
}
