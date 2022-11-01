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
    public partial class FormTruckConfig : Form
    {
        DrawningTruck _truck = null;
        private event TruckDelegate EventAddTruck;

        public FormTruckConfig()
        {
            InitializeComponent();

            panelBlack.MouseDown += PanelColor_MouseDown;
            panelPurple.MouseDown += PanelColor_MouseDown;
            panelGray.MouseDown += PanelColor_MouseDown;
            panelGreen.MouseDown += PanelColor_MouseDown;
            panelRed.MouseDown += PanelColor_MouseDown;
            panelWhite.MouseDown += PanelColor_MouseDown;
            panelYellow.MouseDown += PanelColor_MouseDown;
            panelBlue.MouseDown += PanelColor_MouseDown;

            buttonCancel.Click += (s, e) => Close();
        }

        private void DrawTruck()
        {
            Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _truck?.SetPosition(5, 5, pictureBoxObject.Width, pictureBoxObject.Height);
            _truck?.DrawTransport(gr);
            pictureBoxObject.Image = bmp;
        }

        public void AddEvent(TruckDelegate ev)
        {
            if (EventAddTruck == null)
            {
                EventAddTruck = new TruckDelegate(ev);
            }
            else
            {
                EventAddTruck += ev;
            }
        }

        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).DoDragDrop((sender as Label).Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void PanelObject_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelSimpleObject":
                    _truck = new DrawningTruck((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelModifiedObject":
                    _truck = new DrawningGasolineTanker((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxCistern.Checked, checkBoxFlasher.Checked);
                    break;
            }
            DrawTruck();
        }

        private void PanelObject_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void LabelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            //Fix
            _truck = new DrawningTruck((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, (Color)e.Data.GetData(typeof(Color)));
            DrawTruck();
        }

        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            //Fix
            if (_truck is DrawningGasolineTanker gasolineTanker)
            {
                _truck = new DrawningGasolineTanker((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value,
                    Color.White, (Color)e.Data.GetData(typeof(Color)), checkBoxCistern.Checked, checkBoxFlasher.Checked);
            }
            DrawTruck();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            EventAddTruck?.Invoke(_truck);
            Close();
        }
    }
}
