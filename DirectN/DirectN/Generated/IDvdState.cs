// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("86303d6d-1c4a-4087-ab42-f711167048ef"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdState
    {
        [PreserveSig]
        HRESULT GetDiscID(/* [annotation][out] _Out_ */ out ulong pullUniqueID);
        
        [PreserveSig]
        HRESULT GetParentalLevel(/* [annotation][out] _Out_ */ out uint pulParentalLevel);
    }
}
