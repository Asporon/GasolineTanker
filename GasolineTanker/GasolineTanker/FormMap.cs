using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasolineTanker
{
    public partial class FormMap : Form
    {
        private AbstractMap _abstractMap;

        public FormMap()
        {
            InitializeComponent();
            _abstractMap = new SimpleMap();
        }

        private void SetData(DrawningTruck truck)
        {
            toolStripStatusLabelSpeed.Text = $"Скорость: {truck.Truck.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {truck.Truck.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {truck.Truck.BodyColor.Name}";
            pictureBoxTruck.Image = _abstractMap.CreateMap(pictureBoxTruck.Width, pictureBoxTruck.Height,
                new DrawningObject(truck));
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var truck = new DrawningTruck(rnd.Next(100, 300), rnd.Next(1000, 2000), 
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            SetData(truck);
        }

        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var truck = new DrawningGasolineTanker(rnd.Next(100, 300), rnd.Next(1000, 2000),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)));
            SetData(truck);
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender)?.Name ?? string.Empty;
            Direction dir = Direction.None;
            switch (name)
            {
                case "buttonUp":
                    dir = Direction.Up;
                    break;
                case "buttonDown":
                    dir = Direction.Down;
                    break;
                case "buttonLeft":
                    dir = Direction.Left;
                    break;
                case "buttonRight":
                    dir = Direction.Right;
                    break;
            }
            pictureBoxTruck.Image = _abstractMap?.MoveObject(dir);
        }

        private void ComboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectorMap.Text)
            {
                case "Простая карта":
                    _abstractMap = new SimpleMap();
                    break;
                case "Нефтехранилище":
                    _abstractMap = new OilStorageMap();
                    break;
            }
        }
    }
}
