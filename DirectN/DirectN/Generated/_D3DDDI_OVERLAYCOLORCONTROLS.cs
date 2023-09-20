// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_OVERLAYCOLORCONTROLS
    {
        public int BrightnessSetting;
        public int ContrastSetting;
        public int HueSetting;
        public int SaturationSetting;
        public int SharpnessSetting;
        public int GammaSetting;
        public int ColorEnableSetting;
        public _D3DDDI_OVERLAYCOLORCONTROLSFLAGS Flags;
    }
}
