// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2635,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CALCPRIVATEDEVICESIZE = System.IntPtr;
using PFND3D12DDI_CLOSEADAPTER = System.IntPtr;
using PFND3D12DDI_CREATEDEVICE_0003 = System.IntPtr;
using PFND3D12DDI_DESTROYDEVICE = System.IntPtr;
using PFND3D12DDI_FILLDDITTABLE = System.IntPtr;
using PFND3D12DDI_GETCAPS = System.IntPtr;
using PFND3D12DDI_GETOPTIONALDDITTABLES = System.IntPtr;
using PFND3D12DDI_GETSUPPORTEDVERSIONS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ADAPTERFUNCS
    {
        public IntPtr pfnCalcPrivateDeviceSize;
        public IntPtr pfnCreateDevice;
        public IntPtr pfnCloseAdapter;
        public IntPtr pfnGetSupportedVersions;
        public IntPtr pfnGetCaps;
        public IntPtr pfnGetOptionalDDITables;
        public IntPtr pfnFillDDITable;
        public IntPtr pfnDestroyDevice;
    }
}
