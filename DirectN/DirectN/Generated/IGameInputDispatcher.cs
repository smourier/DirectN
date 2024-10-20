// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("415eed2e-98cb-42c2-8f28-b94601074e31"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameInputDispatcher
    {
        [PreserveSig]
        void Dispatch(/* THIS_ _In_ */ ulong quotaInMicroseconds);
        
        [PreserveSig]
        HRESULT OpenWaitHandle(/* THIS_ _Outptr_result_nullonfailure_ */ out IntPtr waitHandle);
    }
}
