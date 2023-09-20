// generated from <Windows SDK Path>\um\dxgidebug.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_INFO_QUEUE_FILTER_DESC
    {
        public uint NumCategories;
        public IntPtr pCategoryList;
        public uint NumSeverities;
        public IntPtr pSeverityList;
        public uint NumIDs;
        public IntPtr pIDList;
    }
}
