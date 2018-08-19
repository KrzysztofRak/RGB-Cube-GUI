using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace RGB_Cube_Interface
{
    public partial class Main : Form, IMainView
    {
        public Color SelectedColor
        {
            get
            {
                return picSelectedColor.BackColor;
            }
            set
            {
                picSelectedColor.BackColor = value;
                picSelectedColor2.BackColor = value;
                picSelectedColor3.BackColor = value;
            }
        }

        public Image ColorPicker
        {
            get
            {
                return pictureColorPicker.Image;
            }
        }

        public string TextToSend
        {
            get
            {
                return textBoxText.Text;
            }
        }

        public string BtnConnectText
        {
            get
            {
                return btnConnect.Text;
            }
            set
            {
                btnConnect.Text = value;
            }
        }

        public bool RadioSendAnimation
        {
            get
            {
                return radioAnimation.Checked;
            }
        }

        public bool RadioSendText
        {
            get
            {
                return radioText.Checked;
            }
        }

        public bool RadioSetColor
        {
            get
            {
                return radioColors.Checked;
            }
        }

        public bool RadioUpdateDiodes
        {
            get
            {
                return radioUpdateDiode.Checked;
            }
        }

        public bool RadioUpdateLayer
        {
            get
            {
                return radioUpdateLayer.Checked;
            }
        }

        public bool RadioUpdateCube
        {
            get
            {
                return radioUpdateCube.Checked;
            }
        }

        public int AnimationDelay
        {
            get
            {
                return sliderAnimationDelay.Value;
            }
        }

        public int TextDelay
        {
            get
            {
                return sliderTextDelay.Value;
            }
        }

        public string LabelAnimationDelay
        {
            set
            {
                labelAnimationDelay.Text = value;
            }
        }
        public string LabelTextDelay
        {
            set
            {
                labelTextDelay.Text = value;
            }
        }

        public string SelectedPort
        {
            get
            {
                return comboSerialPort.SelectedValue.ToString();
            }
        }

        public string SelectedAnimation
        {
            get
            {
                return comboAnimation.SelectedValue.ToString();
            }
        }

        public string[] PortsList
        {
            set
            {
                comboSerialPort.DataSource = value;
            }
        }
        public string[] AnimationsList
        {
            set
            {
                comboAnimation.DataSource = value;
            }
        }

        public string LabelConnectionText
        {
            set
            {
                labelConnection.Text = value;
            }
        }

        public Color LabelConnectionColor
        {
            set
            {
                labelConnection.ForeColor = value;
            }
        }

        public bool ComboSerialPortEnabled
        {
            set
            {
                comboSerialPort.Enabled = value;
            }
        }

        public bool CheckBoxRandomColors
        {
            get
            {
                return checkBoxRandomColors.Checked;
            }
        }

        public int AxisSelectedIndex
        {
            get
            {
                return comboAxis.SelectedIndex;
            }
        }

        public decimal NumericLayer
        {
            get
            {
                return numericLayer.Value;
            }
        }

        public decimal NumericX
        {
            get
            {
                return numericX.Value;
            }
        }

        public decimal NumericY
        {
            get
            {
                return numericY.Value;
            }
        }

        public decimal NumericZ
        {
            get
            {
                return numericZ.Value;
            }
        }

        private ICubeController controller;

        public Main()
        {
            InitializeComponent();
            SetEnabledPropertyToFalse();
            radioColors_CheckedChanged(null, null);

            controller = new CubeController(this);
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            controller.Connect();
        }


        private void pictureRgbPicker_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            controller.UpdateSelectedColor(e.X, e.Y);
        }

        private void btnRandColor_Click(object sender, EventArgs e)
        {
            controller.RandColor();
        }


        private void sliderAnimationDelay_ValueChanged(object sender, EventArgs e)
        {
            controller.UpdateAnimationDelay();
        }

        private void sliderTextDelay_ValueChanged(object sender, EventArgs e)
        {
            controller.UpdateTextDelay();
        }

        private void comboSerialPort_DropDown(object sender, EventArgs e)
        {
            controller.UpdatePortsList();
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            controller.SendText();
        }

        private void btnSendAnimation_Click(object sender, EventArgs e)
        {
            controller.SendAnimation();
        }

        private void radioAnimation_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabledPropertyToFalse();
            btnSendAnimation.Enabled = true;
            btnSendAnimation.ForeColor = Color.Black;
        }

        private void radioText_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabledPropertyToFalse();
            btnSendText.Enabled = true;
            btnSendText.ForeColor = Color.Black;
        }

        private void radioColors_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabledPropertyToFalse();
            radioUpdateCube.Enabled = true;
            radioUpdateLayer.Enabled = true;
            radioUpdateDiode.Enabled = true;
        }

        private void SetEnabledPropertyToFalse()
        {
            btnSendAnimation.Enabled = false;
            btnSendText.Enabled = false;
            radioUpdateCube.Enabled = false;
            radioUpdateLayer.Enabled = false;
            radioUpdateDiode.Enabled = false;
            btnSendAnimation.ForeColor = Color.LightGray;
            btnSendText.ForeColor = Color.LightGray;
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = textBoxText.SelectionStart;
            textBoxText.Text = Regex.Replace(textBoxText.Text, "[^0-9A-Z ]", "");
            textBoxText.SelectionStart = cursorPosition;
        }
    }
}
