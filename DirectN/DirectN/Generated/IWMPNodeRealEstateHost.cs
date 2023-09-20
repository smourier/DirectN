// generated from <Windows SDK Path>\um\wmprealestate.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1491087d-2c6b-44c8-b019-b3c929d2ada9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPNodeRealEstateHost
    {
        [PreserveSig]
        HRESULT OnDesiredSizeChange(/* [in] */ ref tagSIZE pSize);
        
        [PreserveSig]
        HRESULT OnFullScreenTransition(/* [in] */ bool fFullScreen);
    }
}
