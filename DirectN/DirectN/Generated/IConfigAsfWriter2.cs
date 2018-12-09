// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dshowasf.h(453,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7989ccaa-53f0-44f0-884a-f3b03f6ae066"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IConfigAsfWriter2 : IConfigAsfWriter
    {
        // IConfigAsfWriter
        [PreserveSig]
        new HRESULT ConfigureFilterUsingProfileId(/* [in] */ uint dwProfileId);
        
        [PreserveSig]
        new HRESULT GetCurrentProfileId(/* [out] __RPC__out */ out uint pdwProfileId);
        
        [PreserveSig]
        new HRESULT ConfigureFilterUsingProfileGuid(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProfile);
        
        [PreserveSig]
        new HRESULT GetCurrentProfileGuid(/* [out] __RPC__out */ out Guid pProfileGuid);
        
        [PreserveSig]
        new HRESULT ConfigureFilterUsingProfile(/* [in] __RPC__in_opt */ IWMProfile pProfile);
        
        [PreserveSig]
        new HRESULT GetCurrentProfile(/* [out] __RPC__deref_out_opt */ out IWMProfile ppProfile);
        
        [PreserveSig]
        new HRESULT SetIndexMode(/* [in] */ bool bIndexFile);
        
        [PreserveSig]
        new HRESULT GetIndexMode(/* [out] __RPC__out */ out bool pbIndexFile);
        
        // IConfigAsfWriter2
        [PreserveSig]
        HRESULT StreamNumFromPin(/* [in] __RPC__in_opt */ IPin pPin, /* [out] __RPC__out */ out ushort pwStreamNum);
        
        [PreserveSig]
        HRESULT SetParam(/* [in] */ uint dwParam, /* [in] */ uint dwParam1, /* [in] */ uint dwParam2);
        
        [PreserveSig]
        HRESULT GetParam(/* [in] */ uint dwParam, /* [out] __RPC__out */ out uint pdwParam1, /* [out] __RPC__out */ out uint pdwParam2);
        
        [PreserveSig]
        HRESULT ResetMultiPassState();
    }
}
