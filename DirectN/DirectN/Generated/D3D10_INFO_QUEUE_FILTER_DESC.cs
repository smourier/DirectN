// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10sdklayers.h(890,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_INFO_QUEUE_FILTER_DESC
    {
        public uint NumCategories;
        public IntPtr pCategoryList;
        public uint NumSeverities;
        public IntPtr pSeverityList;
        public uint NumIDs;
        public IntPtr pIDList;
    }
}
