using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c5bdd8d0-d26e-11ce-a89e-00aa006cadc5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITextHost
    {
        [PreserveSig]
        IntPtr TxGetDC();

        [PreserveSig]
        int TxReleaseDC(IntPtr hdc);

        [PreserveSig]
        bool TxShowScrollBar(SB fnBar, bool fShow);

        [PreserveSig]
        bool TxEnableScrollBar(SB fuSBFlags, ESB fuArrowflags);

        [PreserveSig]
        bool TxSetScrollRange(SB fnBar, int nMinPos, int nMaxPos, bool fRedraw);

        [PreserveSig]
        bool TxSetScrollPos(int fnBar, int nPos, bool fRedraw);

        [PreserveSig]
        void TxInvalidateRect(IntPtr prc, bool fMode);

        [PreserveSig]
        void TxViewChange(bool fUpdate);

        [PreserveSig]
        bool TxCreateCaret(IntPtr hbmp, int xWidth, int yHeight);

        [PreserveSig]
        bool TxShowCaret(bool fShow);

        [PreserveSig]
        bool TxSetCaretPos(int x, int y);

        [PreserveSig]
        bool TxSetTimer(int idTimer, int uTimeout);

        [PreserveSig]
        void TxKillTimer(int idTimer);

        [PreserveSig]
        void TxScrollWindowEx(
            int dx,
            int dy,
            IntPtr lprcScroll,
            IntPtr lprcClip,
            IntPtr hrgnUpdate,
            IntPtr lprcUpdate,
            TSW fuScroll);

        [PreserveSig]
        void TxSetCapture(bool fCapture);

        [PreserveSig]
        void TxSetFocus();

        [PreserveSig]
        void TxSetCursor(IntPtr hcur, bool fText);

        [PreserveSig]
        bool TxScreenToClient(ref tagPOINT lppt);

        [PreserveSig]
        bool TxClientToScreen(ref tagPOINT lppt);

        [PreserveSig]
        HRESULT TxActivate(IntPtr plOldState);

        [PreserveSig]
        HRESULT TxDeactivate(int lNewState);

        [PreserveSig]
        HRESULT TxGetClientRect(ref tagRECT prc);

        [PreserveSig]
        HRESULT TxGetViewInset(ref tagRECT prc);

        [PreserveSig]
        HRESULT TxGetCharFormat(out IntPtr ppCF);

        [PreserveSig]
        HRESULT TxGetParaFormat(out IntPtr ppPF);

        [PreserveSig]
        int TxGetSysColor(COLOR nIndex);

        [PreserveSig]
        HRESULT TxGetBackStyle(out TXTBACKSTYLE pstyle);

        [PreserveSig]
        HRESULT TxGetMaxLength(ref int plength);

        [PreserveSig]
        HRESULT TxGetScrollBars(out SBOUT pdwScrollBar);

        [PreserveSig]
        HRESULT TxGetPasswordChar(ref char pch);

        [PreserveSig]
        HRESULT TxGetAcceleratorPos(out int pcp);

        [PreserveSig]
        HRESULT TxGetExtent(out tagSIZE lpExtent);

        [PreserveSig]
        HRESULT OnTxCharFormatChange(ref CHARFORMAT2W pCF);

        [PreserveSig]
        HRESULT OnTxParaFormatChange(ref PARAFORMAT2 pPF);

        [PreserveSig]
        HRESULT TxGetPropertyBits(TXTBIT dwMask, ref TXTBIT pdwBits);

        [PreserveSig]
        HRESULT TxNotify(int iNotify, IntPtr pv);

        [PreserveSig]
        int TxImmGetContext();

        [PreserveSig]
        void TxImmReleaseContext(int himc);

        [PreserveSig]
        HRESULT TxGetSelectionBarWidth(ref int lSelBarWidth);
    }
}
