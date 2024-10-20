// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreEngineNamePropertyInput
    {
        public DXCoreAdapterEngineIndex adapterEngineIndex;
        public uint engineNameLength;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public IntPtr engineName;
    }
}
