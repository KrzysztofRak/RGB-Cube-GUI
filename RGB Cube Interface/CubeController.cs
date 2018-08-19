using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Cube_Interface
{
    class CubeController : ICubeController
    {
        private string[] animationsList = {
            "None",
            "Rainbow",
            "Expanding cube",
            "Random cube colors",
            "Waving",
            "Multi colors",
            "Rain",
            "Falling",
            "Moving cubes",
            "Gradient",
            "Moving panels"
        };


        private IMainView view;
        private CubeSerialPort cubePort;

        public CubeController(IMainView view)
        {
            this.view = view;
            view.AnimationsList = animationsList;
            cubePort = new CubeSerialPort();
            UpdatePortsList();
        }

        public void Connect()
        {
            if (view.BtnConnectText == "Odłącz")
            {
                cubePort.Disconnect();
                view.BtnConnectText = "Połącz";
                view.LabelConnectionColor = Color.Gold;
                view.LabelConnectionText = "Nie połączono";
                view.ComboSerialPortEnabled = true;
            }
            else
            {
                if (!cubePort.SelectSerialPort(view.SelectedPort))
                {
                    view.LabelConnectionColor = Color.Green;
                    view.LabelConnectionText = "Połączono z " + view.SelectedPort;
                    view.BtnConnectText = "Odłącz";
                    view.ComboSerialPortEnabled = false;
                }
                else
                {
                    view.LabelConnectionColor = Color.Red;
                    view.LabelConnectionText = "Nie można połączyć z " + view.SelectedPort;
                }
            }
        }

        public void UpdatePortsList()
        {
            view.PortsList = cubePort.GetSerialPorts();
        }

        private void SetAnimationsList()
        {
            view.AnimationsList = animationsList;
        }

        private string GetDelayFromSliderValue(int sliderValue)
        {
            return (50 + sliderValue * 10).ToString();
        }

        private int GetColorAsInt()
        {
            Color color = view.SelectedColor;
            string hexColor = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            int intColor = int.Parse(hexColor, System.Globalization.NumberStyles.HexNumber);
            return intColor;
        }

        private void TryToUpdateCubeColors()
        {
            if (view.RadioSetColor)
            {
                if (view.RadioUpdateCube)
                {
                    string data = "command=cube_color&color=" + GetColorAsInt();
                    cubePort.SendData(data);
                }
                else if (view.RadioUpdateLayer)
                {
                    string data = "command=layer_color&axis=" + (view.AxisSelectedIndex + 1) + "&layer=" + view.NumericLayer + "&color=" + GetColorAsInt();
                    cubePort.SendData(data);
                }
                else if (view.RadioUpdateDiodes)
                {
                    string data = "command=diode_color&x=" + view.NumericX + "&y=" + view.NumericY + "&z=" + view.NumericZ + "&color=" + GetColorAsInt();
                    cubePort.SendData(data);
                }
            }
        }

        public void UpdateSelectedColor(int x, int y)
        {
            try
            {
                Bitmap bmp = new Bitmap(view.ColorPicker);
                Color color = bmp.GetPixel(x, y);
                view.SelectedColor = color;
                TryToUpdateCubeColors();
            }
            catch { }
        }


        public void RandColor()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Color randColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            view.SelectedColor = randColor;
            TryToUpdateCubeColors();
        }

        public void UpdateAnimationDelay()
        {
            view.LabelAnimationDelay = GetDelayFromSliderValue(view.AnimationDelay) + " ms";
        }

        public void UpdateTextDelay()
        {
            view.LabelTextDelay = GetDelayFromSliderValue(view.TextDelay) + " ms";
        }

        public void SendAnimation()
        {
            if (view.RadioSendAnimation)
            {
                string randColors = "0";
                if (view.CheckBoxRandomColors)
                    randColors = "1";
                string data = "command=" + view.SelectedAnimation.Replace(' ', '_').ToLower() + "&randomColors=" + randColors + "&color=" + GetColorAsInt() + "&delay=" + GetDelayFromSliderValue(view.AnimationDelay);
                Debug.WriteLine(data);
                cubePort.SendData(data);
            }
        }

        public void SendText()
        {
            if (view.RadioSendText)
            {
                string data = "command=text&text=" + view.TextToSend.ToUpper() + "&color=" + GetColorAsInt() + "&delay=" + GetDelayFromSliderValue(view.TextDelay);
                cubePort.SendData(data);
            }
        }
    }
}
