// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("de5072ee-dbe3-46dc-8a87-b6f631194751"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorActivitiesReportCallback
    {
        [PreserveSig]
        HRESULT OnActivitiesReport(/* [annotation][in] _In_ */ IMFSensorActivitiesReport sensorActivitiesReport);
    }
}
