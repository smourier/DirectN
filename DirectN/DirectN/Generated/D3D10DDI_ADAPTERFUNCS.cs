// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(7180,9)
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
