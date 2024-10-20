// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CALCPRIVATEDEVICESIZE = System.IntPtr;
using PFND3D12DDI_CLOSEADAPTER = System.IntPtr;
using PFND3D12DDI_CREATEDEVICE_0109 = System.IntPtr;
using PFND3D12DDI_DESTROYDEVICE = System.IntPtr;
using PFND3D12DDI_FILLDDITTABLE = System.IntPtr;
using PFND3D12DDI_GETCAPS = System.IntPtr;
using PFND3D12DDI_GETOPTIONALDDITTABLES = System.IntPtr;
using PFND3D12DDI_GETSUPPORTEDVERSIONS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ADAPTERFUNCS_0109
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
