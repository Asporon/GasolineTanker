﻿using Microsoft.Extensions.Logging;

namespace GasolineTanker
{
    public partial class FormMapWithSetTrucks : Form
    {
        private readonly Dictionary<string, AbstractMap> _mapsDict = new()
        {
            { "Простая карта", new SimpleMap() },
            { "Нефтехранилище", new OilStorageMap() }
        };
        private readonly MapsCollection _mapsCollection;

        private readonly ILogger _logger;

        public FormMapWithSetTrucks(ILogger<FormMapWithSetTrucks> logger)
        {
            InitializeComponent();
            _logger = logger;
            _mapsCollection = new MapsCollection(pictureBox.Width, pictureBox.Height);
            comboBoxSelectorMap.Items.Clear();
            foreach (var elem in _mapsDict)
            {
                comboBoxSelectorMap.Items.Add(elem.Key);
            }
        }

        private void ReloadMaps()
        {
            int index = listBoxMaps.SelectedIndex;

            listBoxMaps.Items.Clear();
            for (int i = 0; i < _mapsCollection.Keys.Count; i++)
            {
                listBoxMaps.Items.Add(_mapsCollection.Keys[i]);
            }

            if (listBoxMaps.Items.Count > 0 && (index == -1 || index >= listBoxMaps.Items.Count))
            {
                listBoxMaps.SelectedIndex = 0;
            }
            else if (listBoxMaps.Items.Count > 0 && index > -1 && index < listBoxMaps.Items.Count)
            {
                listBoxMaps.SelectedIndex = index;
            }
        }

        private void ButtonAddMap_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectorMap.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxNewMapName.Text))
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_mapsDict.ContainsKey(comboBoxSelectorMap.Text))
            {
                MessageBox.Show("Нет такой карты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _mapsCollection.AddMap(textBoxNewMapName.Text, _mapsDict[comboBoxSelectorMap.Text]);
            ReloadMaps();
            _logger.LogInformation($"Добавлена карта {textBoxNewMapName.Text}");
        }

        private void ListBoxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }

        private void ButtonDeleteMap_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }

            if (MessageBox.Show($"Удалить карту {listBoxMaps.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mapsCollection.DelMap(listBoxMaps.SelectedItem?.ToString() ?? string.Empty);
                ReloadMaps();
                _logger.LogInformation($"Удалена карта {listBoxMaps.SelectedItem?.ToString()}");
            }
        }

        private void ButtonAddTruck_Click(object sender, EventArgs e)
        {
            var formTruckConfig = new FormTruckConfig();
            formTruckConfig.AddEvent(InsertCheck);
            formTruckConfig.Show();
            _logger.LogInformation($"Удалена карта {listBoxMaps.SelectedItem?.ToString()}");
        }
        private void InsertCheck(DrawningTruck _truck)
        {
            DrawningObjectTruck truck = new(_truck);
            if (_mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty] + truck >= 0)
            {
                MessageBox.Show("Объект добавлен");
                pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
            }
            else
            {
                MessageBox.Show("Не удалось добавить объект");
            }
        }
        
        private void ButtonRemoveTruck_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxPosition.Text))
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxPosition.Text);
            try
            {
                if (_mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty] - pos != null)
                {
                    MessageBox.Show("Объект удален");
                    pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить объект");
                }
            }
            catch (TruckNotFoundException ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}");
            }
        }

        private void ButtonShowStorage_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }

        private void ButtonShowOnMap_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowOnMap();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
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
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].MoveObject(dir);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mapsCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не сохранилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mapsCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadMaps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не загрузилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
