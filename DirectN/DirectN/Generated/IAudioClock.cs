// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclient.h(1308,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cd63314f-3fba-4a1b-812c-ef96358728e7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioClock
    {
        [PreserveSig]
        HRESULT GetFrequency(/* [annotation][out] _Out_ */ out ulong pu64Frequency);
        
        [PreserveSig]
        HRESULT GetPosition(/* [annotation][out] _Out_ */ out ulong pu64Position, /* optional(UINT64) */ IntPtr pu64QPCPosition);
        
        [PreserveSig]
        HRESULT GetCharacteristics(/* [annotation][out] _Out_ */ out uint pdwCharacteristics);
    }
}
