using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("8d33f740-cf58-11ce-a89d-00aa006cadc5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITextServices
    {
        [PreserveSig]
        HRESULT TxSendMessage(int msg, IntPtr wparam, IntPtr lparam, out IntPtr plresult);

        [PreserveSig]
        HRESULT TxDraw(
            DVASPECT dwDrawAspect,
            int lindex,
            IntPtr pvAspect,
            IntPtr ptd,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            ref tagRECT lprcBounds,
            ref tagRECT lprcWBounds,
            ref tagRECT lprcUpdate,
            IntPtr pfnContinue,
            int dwContinue,
            TXTVIEW lViewId);

        [PreserveSig]
        HRESULT TxGetHScroll(out int plMin, out int plMax, out int plPos, out int plPage, out bool pfEnabled);

        [PreserveSig]
        HRESULT TxGetVScroll(out int plMin, out int plMax, out int plPos, out int plPage, out bool pfEnabled);

        [PreserveSig]
        HRESULT OnTxSetCursor(
            DVASPECT dwDrawAspect,
            int lindex,
            IntPtr pvAspect,
            IntPtr ptd,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            ref tagRECT lprcClient,
            int x,
            int y);

        [PreserveSig]
        HRESULT TxQueryHitPoint(
            DVASPECT dwDrawAspect,
            int lindex,
            IntPtr pvAspect,
            IntPtr ptd,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            ref tagRECT lprcClient,
            int x,
            int y,
            out TXTHITRESULT pHitResult);

        [PreserveSig]
        HRESULT OnTxInPlaceActivate(ref tagRECT prcClient);

        [PreserveSig]
        HRESULT OnTxInPlaceDeactivate();

        [PreserveSig]
        HRESULT OnTxUIActivate();

        [PreserveSig]
        HRESULT OnTxUIDeactivate();

        [PreserveSig]
        HRESULT TxGetText([MarshalAs(UnmanagedType.BStr)] out string pbstrText);

        [PreserveSig]
        HRESULT TxSetText([MarshalAs(UnmanagedType.LPWStr)] string pszText);

        [PreserveSig]
        HRESULT TxGetCurTargetX(out int x);

        [PreserveSig]
        HRESULT TxGetBaseLinePos(out int pos);

        [PreserveSig]
        HRESULT TxGetNaturalSize(
            DVASPECT dwAspect,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            IntPtr ptd,
            TXTNATURALSIZE dwMode,
            ref tagSIZE psizelExtent,
            ref int pwidth,
            ref int pheight);

        [PreserveSig]
        HRESULT TxGetDropTarget(out object /*IDropTarget*/ ppDropTarget);

        [PreserveSig]
        HRESULT OnTxPropertyBitsChange(TXTBIT dwMask, TXTBIT dwBits);

        [PreserveSig]
        HRESULT TxGetCachedSize(out int pdwWidth, out int pdwHeight);
    }
}
