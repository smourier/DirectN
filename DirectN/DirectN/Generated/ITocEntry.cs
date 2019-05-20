// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmcodecdsp.h(3875,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f22f5e06-585c-4def-8523-6555cfbc0cb3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITocEntry
    {
        [PreserveSig]
        HRESULT SetTitle(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszTitle);
        
        [PreserveSig]
        HRESULT GetTitle(/* [out][in] */ ref ushort pwTitleSize, /* [annotation][size_is][out] _Out_writes_opt_(*pwTitleSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszTitle);
        
        [PreserveSig]
        HRESULT SetDescriptor(/* [in] */ ref _TOC_ENTRY_DESCRIPTOR pDescriptor);
        
        [PreserveSig]
        HRESULT GetDescriptor(/* [out] */ out _TOC_ENTRY_DESCRIPTOR pDescriptor);
        
        [PreserveSig]
        HRESULT SetSubEntries(/* [in] */ uint dwNumSubEntries, /* [in] */ ref ushort pwSubEntryIndices);
        
        [PreserveSig]
        HRESULT GetSubEntries(/* [out][in] */ ref uint pdwNumSubEntries, /* [out] */ out ushort pwSubEntryIndices);
        
        [PreserveSig]
        HRESULT SetDescriptionData(/* [in] */ uint dwDescriptionDataSize, /* [in] */ ref byte pbtDescriptionData, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidType);
        
        [PreserveSig]
        HRESULT GetDescriptionData(/* [out][in] */ ref uint pdwDescriptionDataSize, /* [out] */ out byte pbtDescriptionData, /* [out] */ out Guid pGuidType);
    }
}
