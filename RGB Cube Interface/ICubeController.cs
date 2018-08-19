using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Cube_Interface
{
    public interface ICubeController
    {
        void Connect();
        void UpdateSelectedColor(int x, int y);
        void RandColor();
        void UpdateAnimationDelay();
        void UpdateTextDelay();
        void UpdatePortsList();
        void SendText();
        void SendAnimation();
    }
}
