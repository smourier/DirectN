// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(880,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDI_MULTIPLANE_OVERLAY_PLANE_INFO
    {
        public uint ContextCount;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pContextList;
        public IntPtr pAllocationList;
        public uint DriverPrivateDataSize;
        public IntPtr pDriverPrivateData;
        public bool SyncIntervalOverrideValid;
        public DXGI_DDI_FLIP_INTERVAL_TYPE SyncIntervalOverride;
    }
}
