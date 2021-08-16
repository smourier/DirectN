using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("8d33f741-cf58-11ce-a89d-00aa006cadc5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITextServices2 : ITextServices
    {
        // ITextServices
        [PreserveSig]
        new HRESULT TxSendMessage(int msg, IntPtr wparam, IntPtr lparam, out IntPtr plresult);

        [PreserveSig]
        new HRESULT TxDraw(
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
        new HRESULT TxGetHScroll(out int plMin, out int plMax, out int plPos, out int plPage, out bool pfEnabled);

        [PreserveSig]
        new HRESULT TxGetVScroll(out int plMin, out int plMax, out int plPos, out int plPage, out bool pfEnabled);

        [PreserveSig]
        new HRESULT OnTxSetCursor(
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
        new HRESULT TxQueryHitPoint(
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
        new HRESULT OnTxInPlaceActivate(ref tagRECT prcClient);

        [PreserveSig]
        new HRESULT OnTxInPlaceDeactivate();

        [PreserveSig]
        new HRESULT OnTxUIActivate();

        [PreserveSig]
        new HRESULT OnTxUIDeactivate();

        [PreserveSig]
        new HRESULT TxGetText([MarshalAs(UnmanagedType.BStr)] out string pbstrText);

        [PreserveSig]
        new HRESULT TxSetText([MarshalAs(UnmanagedType.LPWStr)] string pszText);

        [PreserveSig]
        new HRESULT TxGetCurTargetX(out int x);

        [PreserveSig]
        new HRESULT TxGetBaseLinePos(out int pos);

        [PreserveSig]
        new HRESULT TxGetNaturalSize(
            DVASPECT dwAspect,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            IntPtr ptd,
            TXTNATURALSIZE dwMode,
            ref tagSIZE psizelExtent,
            ref int pwidth,
            ref int pheight);

        [PreserveSig]
        new HRESULT TxGetDropTarget(out object /*IDropTarget*/ ppDropTarget);

        [PreserveSig]
        new HRESULT OnTxPropertyBitsChange(TXTBIT dwMask, TXTBIT dwBits);

        [PreserveSig]
        new HRESULT TxGetCachedSize(out int pdwWidth, out int pdwHeight);

        // ITextServices2
        [PreserveSig]
        HRESULT TxGetNaturalSize2(
            DVASPECT dwAspect,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            IntPtr ptd,
            TXTNATURALSIZE dwMode,
            ref tagSIZE psizelExtent,
            ref int pwidth,
            ref int pheight,
            out int pascent);

        [PreserveSig]
        HRESULT TxDrawD2D(ID2D1RenderTarget pRenderTarget, ref tagRECT lprcBounds, IntPtr lprcUpdate, TXTVIEW lViewId);
    }
}
