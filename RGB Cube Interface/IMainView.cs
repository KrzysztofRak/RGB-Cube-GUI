using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Cube_Interface
{
    public interface IMainView
    {
        Color SelectedColor { get; set; }
        string BtnConnectText { get; set; }
        bool RadioSendAnimation { get; }
        bool RadioSendText { get; }
        bool RadioSetColor { get; }
        bool RadioUpdateDiodes { get; }
        bool RadioUpdateLayer { get; }
        bool RadioUpdateCube { get; }
        bool CheckBoxRandomColors { get;  }
        string TextToSend { get; }
        int AnimationDelay { get; }
        int TextDelay { get; }
        string LabelAnimationDelay { set; }
        string LabelTextDelay { set; }
        string SelectedPort { get; }
        string SelectedAnimation { get; }
        string[] PortsList { set; }
        string[] AnimationsList { set; }
        string LabelConnectionText { set; }
        Color LabelConnectionColor { set; }
        bool ComboSerialPortEnabled { set; }
        Image ColorPicker { get; }
        int AxisSelectedIndex { get; }
        decimal NumericLayer { get; }
        decimal NumericX { get; }
        decimal NumericY { get; }
        decimal NumericZ { get; }
    }
}
