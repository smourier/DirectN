// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(462,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_CREATERESOURCE
    {
        public IntPtr pMipInfoList;
        public IntPtr pInitialDataUP;
        public D3D10DDIRESOURCE_TYPE ResourceDimension;
        public uint Usage;
        public uint BindFlags;
        public uint MapFlags;
        public uint MiscFlags;
        public int Format;
        public int SampleDesc;
        public uint MipLevels;
        public uint ArraySize;
        public IntPtr pPrimaryDesc;
    }
}
