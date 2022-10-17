namespace GasolineTanker
{
    public partial class FormTruck : Form
    {
        private DrawningTruck _truck;
        public DrawningTruck SelectedTruck { get; private set; }

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

        private void SetData()
        {
            Random rnd = new();
            _truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTruck.Width, pictureBoxTruck.Height);
            toolStripStatusLabelSpeed.Text = $"Скорость: {_truck.Truck.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {_truck.Truck.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {_truck.Truck.BodyColor.Name}";
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            _truck = new DrawningTruck(rnd.Next(100, 300), rnd.Next(1000, 2000), color);
            SetData();
            Draw();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _truck?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _truck?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _truck?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _truck?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void pictureBoxTruck_Resize(object sender, EventArgs e)
        {
            _truck?.ChangeBorders(pictureBoxTruck.Width, pictureBoxTruck.Height);
            Draw();
        }

        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            Color dopColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialogDop = new();
            if (dialogDop.ShowDialog() == DialogResult.OK)
            {
                dopColor = dialogDop.Color;
            }
            _truck = new DrawningGasolineTanker(rnd.Next(100, 300), rnd.Next(1000, 2000), color, dopColor,
                Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)));
            SetData();
            Draw();
        }

        private void ButtonSelectTruck_Click(object sender, EventArgs e)
        {
            SelectedTruck = _truck;
            DialogResult = DialogResult.OK;
        }
    }
}
