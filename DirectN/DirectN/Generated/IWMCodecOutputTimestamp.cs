// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("b72adf95-7adc-4a72-bc05-577d8ea6bf68"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecOutputTimestamp
    {
        [PreserveSig]
        HRESULT GetNextOutputTime(/* [out] */ out REFERENCE_TIME prtTime);
    }
}
