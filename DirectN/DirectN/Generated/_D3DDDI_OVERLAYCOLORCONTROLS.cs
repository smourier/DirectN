// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1448,9)
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
