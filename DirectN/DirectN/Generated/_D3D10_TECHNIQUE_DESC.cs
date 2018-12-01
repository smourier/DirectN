// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10effect.h(1244,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_TECHNIQUE_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public uint Passes;
        public uint Annotations;
    }
}
