using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GasolineTanker
{
    public partial class FormMapWithSetTrucks : Form
    {
        private MapWithSetTrucksGeneric<DrawningObjectTruck, AbstractMap> _mapTrucksCollectionGeneric;

        public FormMapWithSetTrucks()
        {
            InitializeComponent();
        }

        private void ComboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbstractMap map = null;
            switch (comboBoxSelectorMap.Text)
            {
                case "Простая карта":
                    map = new SimpleMap();
                    break;
                case "Нефтехранилище":
                    map = new OilStorageMap();
                    break;
            }
            if (map != null)
            {
                _mapTrucksCollectionGeneric = new MapWithSetTrucksGeneric<DrawningObjectTruck, AbstractMap>(
                    pictureBox.Width, pictureBox.Height, map);
            }
            else
            {
                _mapTrucksCollectionGeneric = null;
            }
        }

        private void ButtonAddTruck_Click(object sender, EventArgs e)
        {
            if (_mapTrucksCollectionGeneric == null)
            {
                return;
            }
            FormTruck form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DrawningObjectTruck truck = new(form.SelectedTruck);
                if (_mapTrucksCollectionGeneric + truck >= 0)
                {
                    MessageBox.Show("Объект добавлен");
                    pictureBox.Image = _mapTrucksCollectionGeneric.ShowSet();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
        }

        private void ButtonRemoveTruck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxPosition.Text))
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxPosition.Text);
            if (_mapTrucksCollectionGeneric - pos != null)
            {
                MessageBox.Show("Объект удален");
                pictureBox.Image = _mapTrucksCollectionGeneric.ShowSet();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void ButtonShowStorage_Click(object sender, EventArgs e)
        {
            if (_mapTrucksCollectionGeneric == null)
            {
                return;
            }
            pictureBox.Image = _mapTrucksCollectionGeneric.ShowSet();
        }

        private void ButtonShowOnMap_Click(object sender, EventArgs e)
        {
            if (_mapTrucksCollectionGeneric == null)
            {
                return;
            }
            pictureBox.Image = _mapTrucksCollectionGeneric.ShowOnMap();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_mapTrucksCollectionGeneric == null)
            {
                return;
            }
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
            pictureBox.Image = _mapTrucksCollectionGeneric.MoveObject(dir);
        }
    }
}
