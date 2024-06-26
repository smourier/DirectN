﻿// generated from <Windows SDK Path>\um\d2d1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c9b664e5-74a1-4378-9ac2-eefc37a3f4d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ImageSource : ID2D1Image
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Image
        
        // ID2D1ImageSource
        [PreserveSig]
        HRESULT OfferResources();
        
        [PreserveSig]
        HRESULT TryReclaimResources(/* _Out_ */ out bool resourcesDiscarded);
    }
}
