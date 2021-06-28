// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3727,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_HYBRID_LIST
    {
        public _D3DKMT_GPU_PREFERENCE_QUERY_STATE State;
        public LUID AdapterLuid;
        public bool bUserPreferenceQuery;
        public _D3DKMT_GPU_PREFERENCE_QUERY_TYPE QueryType;
    }
}
