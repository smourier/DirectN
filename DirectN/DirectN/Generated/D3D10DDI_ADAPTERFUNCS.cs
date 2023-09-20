// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D10DDI_CALCPRIVATEDEVICESIZE = System.IntPtr;
using PFND3D10DDI_CLOSEADAPTER = System.IntPtr;
using PFND3D10DDI_CREATEDEVICE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDI_ADAPTERFUNCS
    {
        public IntPtr pfnCalcPrivateDeviceSize;
        public IntPtr pfnCreateDevice;
        public IntPtr pfnCloseAdapter;
    }
}
