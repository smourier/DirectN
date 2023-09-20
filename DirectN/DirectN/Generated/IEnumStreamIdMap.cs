// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("945c1566-6202-46fc-96c7-d87f289c6534"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumStreamIdMap
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ int cRequest, /* [annotation][size_is][out][in] _Out_writes_to_(cRequest, *pcReceived) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] STREAM_ID_MAP[] pStreamIdMap, /* optional(ULONG) */ IntPtr pcReceived);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cRecords);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IEnumStreamIdMap ppIEnumStreamIdMap);
    }
}
