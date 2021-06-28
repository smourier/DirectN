// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(20057,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3e8c4be1-a8c2-4528-90de-2851bde5fead"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorActivityReport
    {
        [PreserveSig]
        HRESULT GetFriendlyName(/* [annotation][size_is][out] _Out_writes_z_(cchFriendlyName) */ [MarshalAs(UnmanagedType.LPWStr)] string FriendlyName, /* [annotation][in] _In_ */ uint cchFriendlyName, /* [annotation][out] _Out_ */ out uint pcchWritten);
        
        [PreserveSig]
        HRESULT GetSymbolicLink(/* [annotation][size_is][out] _Out_writes_z_(cchSymbolicLink) */ [MarshalAs(UnmanagedType.LPWStr)] string SymbolicLink, /* [annotation][in] _In_ */ uint cchSymbolicLink, /* [annotation][out] _Out_ */ out uint pcchWritten);
        
        [PreserveSig]
        HRESULT GetProcessCount(/* [annotation][out] _Out_ */ out uint pcCount);
        
        [PreserveSig]
        HRESULT GetProcessActivity(/* [annotation][in] _In_ */ uint Index, /* [annotation][out] _COM_Outptr_ */ out IMFSensorProcessActivity ppProcessActivity);
    }
}
