// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(7933,9)
using System.Runtime.InteropServices;
using AUDIOPOSTURE_PANEL_POWER = DirectN.AUDIOPOSTURE_PANEL_POWER_O;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIOPOSTURE_PANEL_STATE
    {
        public AUDIOPOSTURE_PANEL_POWER Power;
        public AUDIOPOSTURE_PANEL_ORIENTATION Orientation;
    }
}
