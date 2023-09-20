// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DDDI_QUERYREGISTRY_INFO
    {
        public _D3DDDI_QUERYREGISTRY_TYPE QueryType;
        public _D3DDDI_QUERYREGISTRY_FLAGS QueryFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string ValueName;
        public uint ValueType;
        public uint PhysicalAdapterIndex;
        public uint OutputValueSize;
        public _D3DDDI_QUERYREGISTRY_STATUS Status;
        public _D3DDDI_QUERYREGISTRY_INFO__union_0 __union_7;
    }
}
