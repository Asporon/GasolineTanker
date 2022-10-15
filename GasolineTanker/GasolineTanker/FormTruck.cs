namespace GasolineTanker
{
    public partial class FormTruck : Form
    {
        private DrawningTruck _truck;
        
        public FormTruck()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new(pictureBoxTruck.Width, pictureBoxTruck.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _truck?.DrawTransport(gr);
            pictureBoxTruck.Image = bmp;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _truck = new DrawningTruck();
            _truck.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            _truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTruck.Width, pictureBoxTruck.Height);
            toolStripStatusLabelSpeed.Text = $"Скорость: {_truck.Truck.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {_truck.Truck.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {_truck.Truck.BodyColor.Name}";
            Draw();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _truck?.MoveTransport(Directions.Up);
                    break;
                case "buttonDown":
                    _truck?.MoveTransport(Directions.Down);
                    break;
                case "buttonLeft":
                    _truck?.MoveTransport(Directions.Left);
                    break;
                case "buttonRight":
                    _truck?.MoveTransport(Directions.Right);
                    break;
            }
            Draw();
        }

        private void pictureBoxTruck_Resize(object sender, EventArgs e)
        {
            _truck?.ChangeBorders(pictureBoxTruck.Width, pictureBoxTruck.Height);
            Draw();
        }
    }
}
