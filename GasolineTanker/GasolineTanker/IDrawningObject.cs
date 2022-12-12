namespace GasolineTanker
{
    internal interface IDrawningObject : IEquatable<IDrawningObject>
    {
        public float Step { get; }

        void SetObject(int x, int y, int width, int height);

        void MoveObject(Direction direction);

        void DrawningObject(Graphics g);

        (float Left, float Right, float Top, float Bottom) GetCurrentPosition();

        string GetInfo();
    }    
}
