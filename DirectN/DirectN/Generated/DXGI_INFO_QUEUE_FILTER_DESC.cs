using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_INFO_QUEUE_FILTER_DESC
    {
        public int NumCategories;
        public IntPtr pCategoryList;
        public int NumSeverities;
        public IntPtr pSeverityList;
        public int NumIDs;
        public IntPtr pIDList;
    }
}
