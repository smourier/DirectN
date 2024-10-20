// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ISFEATUREENABLED
    {
        public uint hAdapter;
        public _DXGK_FEATURE_ID FeatureId;
        public _DXGK_ISFEATUREENABLED_RESULT Result;
    }
}
