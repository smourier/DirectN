// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2api.h(606,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_DecodeExtensionData
    {
        public uint Function;
        public IntPtr pPrivateInputData;
        public uint PrivateInputDataSize;
        public IntPtr pPrivateOutputData;
        public uint PrivateOutputDataSize;
    }
}
