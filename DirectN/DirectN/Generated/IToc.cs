// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcodecdsp.h(4306,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d6f05441-a919-423b-91a0-89d5b4a8ab77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IToc
    {
        [PreserveSig]
        HRESULT SetDescriptor(/* [in] */ ref _TOC_DESCRIPTOR pDescriptor);
        
        [PreserveSig]
        HRESULT GetDescriptor(/* [out] */ out _TOC_DESCRIPTOR pDescriptor);
        
        [PreserveSig]
        HRESULT SetDescription(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription);
        
        [PreserveSig]
        HRESULT GetDescription(/* [out][in] */ ref ushort pwDescriptionSize, /* [annotation][size_is][out] _Out_writes_opt_(*pwDescriptionSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription);
        
        [PreserveSig]
        HRESULT SetContext(/* [in] */ uint dwContextSize, /* [in] */ ref byte pbtContext);
        
        [PreserveSig]
        HRESULT GetContext(/* [out][in] */ ref uint pdwContextSize, /* [out] */ out byte pbtContext);
        
        [PreserveSig]
        HRESULT GetEntryListCount(/* [out] */ out ushort pwCount);
        
        [PreserveSig]
        HRESULT GetEntryListByIndex(/* [in] */ ushort wEntryListIndex, /* [out] */ out ITocEntryList ppEntryList);
        
        [PreserveSig]
        HRESULT AddEntryList(/* [in] */ ITocEntryList pEntryList, /* [out] */ out ushort pwEntryListIndex);
        
        [PreserveSig]
        HRESULT AddEntryListByIndex(/* [in] */ ushort wEntryListIndex, /* [in] */ ITocEntryList pEntryList);
        
        [PreserveSig]
        HRESULT RemoveEntryListByIndex(/* [in] */ ushort wEntryListIndex);
    }
}
