// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DKMT_QUERY_ADAPTER_UNIQUE_GUID
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)] 
        public string AdapterUniqueGUID;
    }
}
