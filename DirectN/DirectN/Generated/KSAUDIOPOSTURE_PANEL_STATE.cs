// generated from <Windows SDK Path>\shared\ksmedia.h
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
