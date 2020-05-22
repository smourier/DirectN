// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1984,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public partial struct _DXGK_NODEMETADATA
    {
        public DXGK_ENGINE_TYPE EngineType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string FriendlyName;
        public _DXGK_NODEMETADATA_FLAGS Flags;
        public byte GpuMmuSupported;
        public byte IoMmuSupported;
    }
}
