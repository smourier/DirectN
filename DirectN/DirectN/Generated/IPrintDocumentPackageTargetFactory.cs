﻿// generated from <Windows SDK Path>\um\documenttarget.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("d2959bf7-b31b-4a3d-9600-712eb1335ba4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPrintDocumentPackageTargetFactory
    {
        [PreserveSig]
        HRESULT CreateDocumentPackageTargetForPrintJob(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string printerName, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string jobName, /* [in] __RPC__in_opt */ IStream jobOutputStream, /* [in] __RPC__in_opt */ IStream jobPrintTicketStream, /* [out] __RPC__deref_out_opt */ out IPrintDocumentPackageTarget docPackageTarget);
    }
}
