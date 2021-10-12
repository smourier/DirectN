// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(13009,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_EXPORT_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ExportToRename;
        public D3D12_EXPORT_FLAGS Flags;
    }
}
