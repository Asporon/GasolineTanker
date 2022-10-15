using System;

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

            Brush brDop = new SolidBrush(gasolineTanker.DopColor);
            Brush brDarkGray = new SolidBrush(Color.DarkGray);

            if (gasolineTanker.Сistern)
            {
                g.FillRectangle(brDop, _startPosX, _startPosY + 20, 50, 20);
                g.FillRectangle(brDarkGray, _startPosX + 10, _startPosY + 20, 5, 20);
                g.FillRectangle(brDarkGray, _startPosX + 35, _startPosY + 20, 5, 20);
            }

            if (gasolineTanker.Flasher)
            {
                g.FillRectangle(brDarkGray, _startPosX + 55, _startPosY + 8, 5, 37);

                Brush brOrange = new SolidBrush(Color.FromArgb(255, 140, 0));
                g.FillRectangle(brOrange, _startPosX + 53, _startPosY, 9, 8);
            }

            _startPosX += 5;
            _startPosY += 5;
            base.DrawTransport(g);
            _startPosX -= 5;
            _startPosY -= 5;
        }
    }
}
