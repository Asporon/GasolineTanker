namespace GasolineTanker
{
    internal class DrawningGasolineTanker : DrawningTruck
    {
        public DrawningGasolineTanker(int speed, float weight, Color bodyColor, Color dopColor, bool cistern, bool flasher) :
            base(speed, weight, bodyColor, 80, 70)
        {
            Truck = new EntityGasolineTanker (speed, weight, bodyColor, dopColor, cistern, flasher);
        }

        public override void DrawTransport(Graphics g)
        {
            if (Truck is not EntityGasolineTanker gasolineTanker)
            {
                return;
            }

            Pen pen = new(Color.Black);
            Brush dopBrush = new SolidBrush(gasolineTanker.DopColor);

            if (gasolineTanker.Сistern)
            {
                
            }

            _startPosX += 10;
            _startPosY += 5;
            base.DrawTransport(g);
            _startPosX -= 10;
            _startPosY -= 5;

            if (gasolineTanker.Flasher)
            {
                
            }
        }
    }
}
