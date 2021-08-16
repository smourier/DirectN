using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("13e670f5-1a5a-11cf-abeb-00aa00b65ea1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITextHost2 : ITextHost
    {
        // ITextHost
        [PreserveSig]
        new IntPtr TxGetDC();

        [PreserveSig]
        new int TxReleaseDC(IntPtr hdc);

        [PreserveSig]
        new bool TxShowScrollBar(SB fnBar, bool fShow);

        [PreserveSig]
        new bool TxEnableScrollBar(SB fuSBFlags, ESB fuArrowflags);

        [PreserveSig]
        new bool TxSetScrollRange(SB fnBar, int nMinPos, int nMaxPos, bool fRedraw);

        [PreserveSig]
        new bool TxSetScrollPos(int fnBar, int nPos, bool fRedraw);

        [PreserveSig]
        new void TxInvalidateRect(IntPtr prc, bool fMode);

        [PreserveSig]
        new void TxViewChange(bool fUpdate);

        [PreserveSig]
        new bool TxCreateCaret(IntPtr hbmp, int xWidth, int yHeight);

        [PreserveSig]
        new bool TxShowCaret(bool fShow);

        [PreserveSig]
        new bool TxSetCaretPos(int x, int y);

        [PreserveSig]
        new bool TxSetTimer(int idTimer, int uTimeout);

        [PreserveSig]
        new void TxKillTimer(int idTimer);

        [PreserveSig]
        new void TxScrollWindowEx(
            int dx,
            int dy,
            IntPtr lprcScroll,
            IntPtr lprcClip,
            IntPtr hrgnUpdate,
            IntPtr lprcUpdate,
            TSW fuScroll);

        [PreserveSig]
        new void TxSetCapture(bool fCapture);

        [PreserveSig]
        new void TxSetFocus();

        [PreserveSig]
        new void TxSetCursor(IntPtr hcur, bool fText);

        [PreserveSig]
        new bool TxScreenToClient(ref tagPOINT lppt);

        [PreserveSig]
        new bool TxClientToScreen(ref tagPOINT lppt);

        [PreserveSig]
        new HRESULT TxActivate(IntPtr plOldState);

        [PreserveSig]
        new HRESULT TxDeactivate(int lNewState);

        [PreserveSig]
        new HRESULT TxGetClientRect(ref tagRECT prc);

        [PreserveSig]
        new HRESULT TxGetViewInset(ref tagRECT prc);

        [PreserveSig]
        new HRESULT TxGetCharFormat(out IntPtr ppCF);

        [PreserveSig]
        new HRESULT TxGetParaFormat(out IntPtr ppPF);

        [PreserveSig]
        new int TxGetSysColor(COLOR nIndex);

        [PreserveSig]
        new HRESULT TxGetBackStyle(out TXTBACKSTYLE pstyle);

        [PreserveSig]
        new HRESULT TxGetMaxLength(ref int plength);

        [PreserveSig]
        new HRESULT TxGetScrollBars(out SBOUT pdwScrollBar);

        [PreserveSig]
        new HRESULT TxGetPasswordChar(ref char pch);

        [PreserveSig]
        new HRESULT TxGetAcceleratorPos(out int pcp);

        [PreserveSig]
        new HRESULT TxGetExtent(out tagSIZE lpExtent);

        [PreserveSig]
        new HRESULT OnTxCharFormatChange(ref CHARFORMAT2W pCF);

        [PreserveSig]
        new HRESULT OnTxParaFormatChange(ref PARAFORMAT2 pPF);

        [PreserveSig]
        new HRESULT TxGetPropertyBits(TXTBIT dwMask, ref TXTBIT pdwBits);

        [PreserveSig]
        new HRESULT TxNotify(int iNotify, IntPtr pv);

        [PreserveSig]
        new int TxImmGetContext();

        [PreserveSig]
        new void TxImmReleaseContext(int himc);

        [PreserveSig]
        new HRESULT TxGetSelectionBarWidth(out int lSelBarWidth);

        // ITextHost2
        [PreserveSig]
        bool TxIsDoubleClickPending();

        [PreserveSig]
        HRESULT TxGetWindow(out IntPtr phwnd);

        [PreserveSig]
        HRESULT TxSetForegroundWindow();

        [PreserveSig]
        IntPtr TxGetPalette();

        [PreserveSig]
        HRESULT TxGetEastAsianFlags(out ES pFlags);

        [PreserveSig]
        IntPtr TxSetCursor2(IntPtr hcur, bool bText);

        [PreserveSig]
        void TxFreeTextServicesNotification();

        [PreserveSig]
        HRESULT TxGetEditStyle(TXES dwItem, out TXES pdwData);

        [PreserveSig]
        HRESULT TxGetWindowStyles(out int pdwStyle, out int pdwExStyle);

        [PreserveSig]
        HRESULT TxShowDropCaret(bool fShow, IntPtr hdc, IntPtr prc);

        [PreserveSig]
        HRESULT TxDestroyCaret();

        [PreserveSig]
        HRESULT TxGetHorzExtent(out int plHorzExtent);
    }
}
