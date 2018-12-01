// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(19619,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c95ea55b-0187-48be-9353-8d2507662351"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorProfileCollection
    {
        [PreserveSig]
        uint GetProfileCount();
        
        [PreserveSig]
        HRESULT GetProfile(/* [annotation][in] _In_ */ uint Index, /* [annotation][out] _COM_Outptr_ */ out IMFSensorProfile ppProfile);
        
        [PreserveSig]
        HRESULT AddProfile(/* [annotation][in] _In_ */ IMFSensorProfile pProfile);
        
        [PreserveSig]
        HRESULT FindProfile(/* [annotation][in] _In_ */ ref __MIDL___MIDL_itf_mfidl_0000_0113_0001 ProfileId, /* [annotation][out] _COM_Outptr_ */ out IMFSensorProfile ppProfile);
        
        [PreserveSig]
        void RemoveProfileByIndex(/* [annotation][in] _In_ */ uint Index);
        
        [PreserveSig]
        void RemoveProfile(/* [annotation][in] _In_ */ ref __MIDL___MIDL_itf_mfidl_0000_0113_0001 ProfileId);
    }
}
