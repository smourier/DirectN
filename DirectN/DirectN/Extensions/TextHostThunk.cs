using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace DirectN
{
    internal class TextHostThunk : IDisposable
    {
        // https://devblogs.microsoft.com/oldnewthing/20040205-00/?p=40733
        private IntPtr _vtablePointer;
        private IntPtr _unk;
        private ITextHost2VTable _table;
        private readonly TextHost _host;
        private bool _disposedValue;
        private static readonly ConcurrentDictionary<IntPtr, TextHostThunk> _hosts = new ConcurrentDictionary<IntPtr, TextHostThunk>();

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int QueryInterfaceFn(IntPtr pThis, ref Guid riid, ref IntPtr ppInterface);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int AddRefFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int ReleaseFn(IntPtr pThis);

        // see comments here: https://stackoverflow.com/questions/55416805/how-to-use-createtextservices-itexthost-correctly-in-c
        // All ITextHost and ITextServices are using thiscall...
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr TxGetDCFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate int TxReleaseDCFn(IntPtr pThis, IntPtr hdc);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxShowScrollBarFn(IntPtr pThis, SB fnBar, bool fShow);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxEnableScrollBarFn(IntPtr pThis, SB fuSBFlags, ESB fuArrowflags);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxSetScrollRangeFn(IntPtr pThis, SB fnBar, int nMinPos, int nMaxPos, bool fRedraw);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxSetScrollPosFn(IntPtr pThis, int fnBar, int nPos, bool fRedraw);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxInvalidateRectFn(IntPtr pThis, IntPtr prc, bool fMode);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxViewChangeFn(IntPtr pThis, bool fUpdate);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxCreateCaretFn(IntPtr pThis, IntPtr hbmp, int xWidth, int yHeight);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxShowCaretFn(IntPtr pThis, bool fShow);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxSetCaretPosFn(IntPtr pThis, int x, int y);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxSetTimerFn(IntPtr pThis, int idTimer, int uTimeout);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxKillTimerFn(IntPtr pThis, int idTimer);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxScrollWindowExFn(IntPtr pThis,
            int dx,
            int dy,
            IntPtr lprcScroll,
            IntPtr lprcClip,
            IntPtr hrgnUpdate,
            IntPtr lprcUpdate,
            TSW fuScroll);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxSetCaptureFn(IntPtr pThis, bool fCapture);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxSetFocusFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxSetCursorFn(IntPtr pThis, IntPtr hcur, bool fText);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxScreenToClientFn(IntPtr pThis, ref tagPOINT lppt);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxClientToScreenFn(IntPtr pThis, ref tagPOINT lppt);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxActivateFn(IntPtr pThis, IntPtr plOldState);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxDeactivateFn(IntPtr pThis, int lNewState);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetClientRectFn(IntPtr pThis, ref tagRECT prc);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetViewInsetFn(IntPtr pThis, ref tagRECT prc);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetCharFormatFn(IntPtr pThis, out IntPtr ppCF);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetParaFormatFn(IntPtr pThis, out IntPtr ppPF);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate int TxGetSysColorFn(IntPtr pThis, COLOR nIndex);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetBackStyleFn(IntPtr pThis, out TXTBACKSTYLE pstyle);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetMaxLengthFn(IntPtr pThis, ref int plength);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetScrollBarsFn(IntPtr pThis, out SBOUT pdwScrollBar);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetPasswordCharFn(IntPtr pThis, ref char pch);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetAcceleratorPosFn(IntPtr pThis, out int pcp);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetExtentFn(IntPtr pThis, out tagSIZE lpExtent);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxCharFormatChangeFn(IntPtr pThis, ref CHARFORMAT2W pCF);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxParaFormatChangeFn(IntPtr pThis, ref PARAFORMAT2 pPF);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetPropertyBitsFn(IntPtr pThis, TXTBIT dwMask, ref TXTBIT pdwBits);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxNotifyFn(IntPtr pThis, int iNotify, IntPtr pv);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate int TxImmGetContextFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxImmReleaseContextFn(IntPtr pThis, int himc);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetSelectionBarWidthFn(IntPtr pThis, ref int lSelBarWidth);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate bool TxIsDoubleClickPendingFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetWindowFn(IntPtr pThis, out IntPtr phwnd);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxSetForegroundWindowFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr TxGetPaletteFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetEastAsianFlagsFn(IntPtr pThis, out ES pFlags);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr TxSetCursor2Fn(IntPtr pThis, IntPtr hcur, bool bText);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void TxFreeTextServicesNotificationFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetEditStyleFn(IntPtr pThis, TXES dwItem, out TXES pdwData);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetWindowStylesFn(IntPtr pThis, out WS pdwStyle, out WS_EX pdwExStyle);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxShowDropCaretFn(IntPtr pThis, bool fShow, IntPtr hdc, IntPtr prc);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxDestroyCaretFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetHorzExtentFn(IntPtr pThis, out int plHorzExtent);

#pragma warning disable IDE1006 // Naming Styles
        private static readonly Guid IID_IUnknown = new Guid("00000000-0000-0000-c000-000000000046");
#pragma warning restore IDE1006 // Naming Styles

        // this is to avoid GC
        private static readonly QueryInterfaceFn _queryInterface = QueryInterface;
        private static readonly AddRefFn _addRef = AddRef;
        private static readonly ReleaseFn _release = Release;
        private static readonly TxGetDCFn _txGetDC = TxGetDC;
        private static readonly TxReleaseDCFn _txReleaseDC = TxReleaseDC;
        private static readonly TxShowScrollBarFn _txShowScrollBar = TxShowScrollBar;
        private static readonly TxEnableScrollBarFn _txEnableScrollBar = TxEnableScrollBar;
        private static readonly TxSetScrollRangeFn _txSetScrollRange = TxSetScrollRange;
        private static readonly TxSetScrollPosFn _txSetScrollPos = TxSetScrollPos;
        private static readonly TxInvalidateRectFn _txInvalidateRect = TxInvalidateRect;
        private static readonly TxViewChangeFn _txViewChange = TxViewChange;
        private static readonly TxCreateCaretFn _txCreateCaret = TxCreateCaret;
        private static readonly TxShowCaretFn _txShowCaret = TxShowCaret;
        private static readonly TxSetCaretPosFn _txSetCaretPos = TxSetCaretPos;
        private static readonly TxSetTimerFn _txSetTimer = TxSetTimer;
        private static readonly TxKillTimerFn _txKillTimer = TxKillTimer;
        private static readonly TxScrollWindowExFn _txScrollWindowEx = TxScrollWindowEx;
        private static readonly TxSetCaptureFn _txSetCapture = TxSetCapture;
        private static readonly TxSetFocusFn _txSetFocus = TxSetFocus;
        private static readonly TxSetCursorFn _txSetCursor = TxSetCursor;
        private static readonly TxScreenToClientFn _txScreenToClient = TxScreenToClient;
        private static readonly TxClientToScreenFn _txClientToScreen = TxClientToScreen;
        private static readonly TxActivateFn _txActivate = TxActivate;
        private static readonly TxDeactivateFn _txDeactivate = TxDeactivate;
        private static readonly TxGetClientRectFn _txGetClientRect = TxGetClientRect;
        private static readonly TxGetViewInsetFn _txGetViewInset = TxGetViewInset;
        private static readonly TxGetCharFormatFn _txGetCharFormat = TxGetCharFormat;
        private static readonly TxGetParaFormatFn _txGetParaFormat = TxGetParaFormat;
        private static readonly TxGetSysColorFn _txGetSysColor = TxGetSysColor;
        private static readonly TxGetBackStyleFn _txGetBackStyle = TxGetBackStyle;
        private static readonly TxGetMaxLengthFn _txGetMaxLength = TxGetMaxLength;
        private static readonly TxGetScrollBarsFn _txGetScrollBars = TxGetScrollBars;
        private static readonly TxGetPasswordCharFn _txGetPasswordChar = TxGetPasswordChar;
        private static readonly TxGetAcceleratorPosFn _txGetAcceleratorPos = TxGetAcceleratorPos;
        private static readonly TxGetExtentFn _txGetExtent = TxGetExtent;
        private static readonly OnTxCharFormatChangeFn _onTxCharFormatChange = OnTxCharFormatChange;
        private static readonly OnTxParaFormatChangeFn _onTxParaFormatChange = OnTxParaFormatChange;
        private static readonly TxGetPropertyBitsFn _txGetPropertyBits = TxGetPropertyBits;
        private static readonly TxNotifyFn _txNotify = TxNotify;
        private static readonly TxImmGetContextFn _txImmGetContext = TxImmGetContext;
        private static readonly TxImmReleaseContextFn _txImmReleaseContext = TxImmReleaseContext;
        private static readonly TxGetSelectionBarWidthFn _txGetSelectionBarWidth = TxGetSelectionBarWidth;
        private static readonly TxIsDoubleClickPendingFn _txIsDoubleClickPending = TxIsDoubleClickPending;
        private static readonly TxGetWindowFn _txGetWindow = TxGetWindow;
        private static readonly TxSetForegroundWindowFn _txSetForegroundWindow = TxSetForegroundWindow;
        private static readonly TxGetPaletteFn _txGetPalette = TxGetPalette;
        private static readonly TxGetEastAsianFlagsFn _txGetEastAsianFlags = TxGetEastAsianFlags;
        private static readonly TxSetCursor2Fn _txSetCursor2 = TxSetCursor2;
        private static readonly TxFreeTextServicesNotificationFn _txFreeTextServicesNotification = TxFreeTextServicesNotification;
        private static readonly TxGetEditStyleFn _txGetEditStyle = TxGetEditStyle;
        private static readonly TxGetWindowStylesFn _txGetWindowStyles = TxGetWindowStyles;
        private static readonly TxShowDropCaretFn _txShowDropCaret = TxShowDropCaret;
        private static readonly TxDestroyCaretFn _txDestroyCaret = TxDestroyCaret;
        private static readonly TxGetHorzExtentFn _txGetHorzExtent = TxGetHorzExtent;

        public TextHostThunk(TextHost host)
        {
            if (host == null)
                throw new ArgumentNullException(nameof(host));

            _host = host;
            _table = new ITextHost2VTable();
            _table.QueryInterface = Marshal.GetFunctionPointerForDelegate(_queryInterface);
            _table.AddRef = Marshal.GetFunctionPointerForDelegate(_addRef);
            _table.Release = Marshal.GetFunctionPointerForDelegate(_release);
            _table.TxGetDC = Marshal.GetFunctionPointerForDelegate(_txGetDC);
            _table.TxReleaseDC = Marshal.GetFunctionPointerForDelegate(_txReleaseDC);
            _table.TxShowScrollBar = Marshal.GetFunctionPointerForDelegate(_txShowScrollBar);
            _table.TxEnableScrollBar = Marshal.GetFunctionPointerForDelegate(_txEnableScrollBar);
            _table.TxSetScrollRange = Marshal.GetFunctionPointerForDelegate(_txSetScrollRange);
            _table.TxSetScrollPos = Marshal.GetFunctionPointerForDelegate(_txSetScrollPos);
            _table.TxInvalidateRect = Marshal.GetFunctionPointerForDelegate(_txInvalidateRect);
            _table.TxViewChange = Marshal.GetFunctionPointerForDelegate(_txViewChange);
            _table.TxCreateCaret = Marshal.GetFunctionPointerForDelegate(_txCreateCaret);
            _table.TxShowCaret = Marshal.GetFunctionPointerForDelegate(_txShowCaret);
            _table.TxSetCaretPos = Marshal.GetFunctionPointerForDelegate(_txSetCaretPos);
            _table.TxSetTimer = Marshal.GetFunctionPointerForDelegate(_txSetTimer);
            _table.TxKillTimer = Marshal.GetFunctionPointerForDelegate(_txKillTimer);
            _table.TxScrollWindowEx = Marshal.GetFunctionPointerForDelegate(_txScrollWindowEx);
            _table.TxSetCapture = Marshal.GetFunctionPointerForDelegate(_txSetCapture);
            _table.TxSetFocus = Marshal.GetFunctionPointerForDelegate(_txSetFocus);
            _table.TxSetCursor = Marshal.GetFunctionPointerForDelegate(_txSetCursor);
            _table.TxScreenToClient = Marshal.GetFunctionPointerForDelegate(_txScreenToClient);
            _table.TxClientToScreen = Marshal.GetFunctionPointerForDelegate(_txClientToScreen);
            _table.TxActivate = Marshal.GetFunctionPointerForDelegate(_txActivate);
            _table.TxDeactivate = Marshal.GetFunctionPointerForDelegate(_txDeactivate);
            _table.TxGetClientRect = Marshal.GetFunctionPointerForDelegate(_txGetClientRect);
            _table.TxGetViewInset = Marshal.GetFunctionPointerForDelegate(_txGetViewInset);
            _table.TxGetCharFormat = Marshal.GetFunctionPointerForDelegate(_txGetCharFormat);
            _table.TxGetParaFormat = Marshal.GetFunctionPointerForDelegate(_txGetParaFormat);
            _table.TxGetSysColor = Marshal.GetFunctionPointerForDelegate(_txGetSysColor);
            _table.TxGetBackStyle = Marshal.GetFunctionPointerForDelegate(_txGetBackStyle);
            _table.TxGetMaxLength = Marshal.GetFunctionPointerForDelegate(_txGetMaxLength);
            _table.TxGetScrollBars = Marshal.GetFunctionPointerForDelegate(_txGetScrollBars);
            _table.TxGetPasswordChar = Marshal.GetFunctionPointerForDelegate(_txGetPasswordChar);
            _table.TxGetAcceleratorPos = Marshal.GetFunctionPointerForDelegate(_txGetAcceleratorPos);
            _table.TxGetExtent = Marshal.GetFunctionPointerForDelegate(_txGetExtent);
            _table.OnTxCharFormatChange = Marshal.GetFunctionPointerForDelegate(_onTxCharFormatChange);
            _table.OnTxParaFormatChange = Marshal.GetFunctionPointerForDelegate(_onTxParaFormatChange);
            _table.TxGetPropertyBits = Marshal.GetFunctionPointerForDelegate(_txGetPropertyBits);
            _table.TxNotify = Marshal.GetFunctionPointerForDelegate(_txNotify);
            _table.TxImmGetContext = Marshal.GetFunctionPointerForDelegate(_txImmGetContext);
            _table.TxImmReleaseContext = Marshal.GetFunctionPointerForDelegate(_txImmReleaseContext);
            _table.TxGetSelectionBarWidth = Marshal.GetFunctionPointerForDelegate(_txGetSelectionBarWidth);
            _table.TxIsDoubleClickPending = Marshal.GetFunctionPointerForDelegate(_txIsDoubleClickPending);
            _table.TxGetWindow = Marshal.GetFunctionPointerForDelegate(_txGetWindow);
            _table.TxSetForegroundWindow = Marshal.GetFunctionPointerForDelegate(_txSetForegroundWindow);
            _table.TxGetPalette = Marshal.GetFunctionPointerForDelegate(_txGetPalette);
            _table.TxGetEastAsianFlags = Marshal.GetFunctionPointerForDelegate(_txGetEastAsianFlags);
            _table.TxSetCursor2 = Marshal.GetFunctionPointerForDelegate(_txSetCursor2);
            _table.TxFreeTextServicesNotification = Marshal.GetFunctionPointerForDelegate(_txFreeTextServicesNotification);
            _table.TxGetEditStyle = Marshal.GetFunctionPointerForDelegate(_txGetEditStyle);
            _table.TxGetWindowStyles = Marshal.GetFunctionPointerForDelegate(_txGetWindowStyles);
            _table.TxShowDropCaret = Marshal.GetFunctionPointerForDelegate(_txShowDropCaret);
            _table.TxDestroyCaret = Marshal.GetFunctionPointerForDelegate(_txDestroyCaret);
            _table.TxGetHorzExtent = Marshal.GetFunctionPointerForDelegate(_txGetHorzExtent);

            _vtablePointer = ComMemory.AllocAndCopy(_table);
            _unk = ComMemory.AllocAndCopy(_vtablePointer);
            _hosts[_unk] = this;
        }

        public IntPtr Pointer => _unk;

        // IUnknown
        private static int QueryInterface(IntPtr pThis, ref Guid riid, ref IntPtr ppInterface)
        {
            // note this works because ITextHost and ITextHost2 are over IUnknown
            // we just return the original COM pointer
            if (riid == IID_IUnknown)
            {
                ppInterface = pThis;
                return 0;
            }

            if (riid == typeof(ITextHost).GUID || riid == typeof(ITextHost2).GUID)
            {
                ppInterface = pThis;
                return 0;
            }

#if DEBUG
            TextHost.Logger?.Log(System.Diagnostics.TraceLevel.Warning, "IID:" + riid, nameof(TextHostThunk) + ":QueryInterface");
#endif
            return (int)HRESULTS.E_NOINTERFACE;
        }

        private static int AddRef(IntPtr pThis) => 1;
        private static int Release(IntPtr pThis) => 1;

        // ITextHost
        private static IntPtr TxGetDC(IntPtr pThis) => GetHost(pThis).TxGetDC();
        private static int TxReleaseDC(IntPtr pThis, IntPtr hdc) => GetHost(pThis).TxReleaseDC(hdc);
        private static bool TxShowScrollBar(IntPtr pThis, SB fnBar, bool fShow) => GetHost(pThis).TxShowScrollBar(fnBar, fShow);
        private static bool TxEnableScrollBar(IntPtr pThis, SB fuSBFlags, ESB fuArrowflags) => GetHost(pThis).TxEnableScrollBar(fuSBFlags, fuArrowflags);
        private static bool TxSetScrollRange(IntPtr pThis, SB fnBar, int nMinPos, int nMaxPos, bool fRedraw) => GetHost(pThis).TxSetScrollRange(fnBar, nMinPos, nMaxPos, fRedraw);
        private static bool TxSetScrollPos(IntPtr pThis, int fnBar, int nPos, bool fRedraw) => GetHost(pThis).TxSetScrollPos(fnBar, nPos, fRedraw);
        private static void TxInvalidateRect(IntPtr pThis, IntPtr prc, bool fMode) => GetHost(pThis).TxInvalidateRect(prc, fMode);
        private static void TxViewChange(IntPtr pThis, bool fUpdate) => GetHost(pThis).TxViewChange(fUpdate);
        private static bool TxCreateCaret(IntPtr pThis, IntPtr hbmp, int xWidth, int yHeight) => GetHost(pThis).TxCreateCaret(hbmp, xWidth, yHeight);
        private static bool TxShowCaret(IntPtr pThis, bool fShow) => GetHost(pThis).TxShowCaret(fShow);
        private static bool TxSetCaretPos(IntPtr pThis, int x, int y) => GetHost(pThis).TxSetCaretPos(x, y);
        private static bool TxSetTimer(IntPtr pThis, int idTimer, int uTimeout) => GetHost(pThis).TxSetTimer(idTimer, uTimeout);
        private static void TxKillTimer(IntPtr pThis, int idTimer) => GetHost(pThis).TxKillTimer(idTimer);
        private static void TxScrollWindowEx(IntPtr pThis, int dx, int dy, IntPtr lprcScroll, IntPtr lprcClip, IntPtr hrgnUpdate, IntPtr lprcUpdate, TSW fuScroll) => GetHost(pThis).TxScrollWindowEx(dx, dy, lprcScroll, lprcClip, hrgnUpdate, lprcUpdate, fuScroll);
        private static void TxSetCapture(IntPtr pThis, bool fCapture) => GetHost(pThis).TxSetCapture(fCapture);
        private static void TxSetFocus(IntPtr pThis) => GetHost(pThis).TxSetFocus();
        private static void TxSetCursor(IntPtr pThis, IntPtr hcur, bool fText) => GetHost(pThis).TxSetCursor(hcur, fText);
        private static bool TxScreenToClient(IntPtr pThis, ref tagPOINT lppt) => GetHost(pThis).TxScreenToClient(ref lppt);
        private static bool TxClientToScreen(IntPtr pThis, ref tagPOINT lppt) => GetHost(pThis).TxClientToScreen(ref lppt);
        private static HRESULT TxActivate(IntPtr pThis, IntPtr plOldState) => GetHost(pThis).TxActivate(plOldState);
        private static HRESULT TxDeactivate(IntPtr pThis, int lNewState) => GetHost(pThis).TxDeactivate(lNewState);
        private static HRESULT TxGetClientRect(IntPtr pThis, ref tagRECT prc) => GetHost(pThis).TxGetClientRect(ref prc);
        private static HRESULT TxGetViewInset(IntPtr pThis, ref tagRECT prc) => GetHost(pThis).TxGetViewInset(ref prc);
        private static HRESULT TxGetCharFormat(IntPtr pThis, out IntPtr ppCF) => GetHost(pThis).TxGetCharFormat(out ppCF);
        private static HRESULT TxGetParaFormat(IntPtr pThis, out IntPtr ppPF) => GetHost(pThis).TxGetParaFormat(out ppPF);
        private static int TxGetSysColor(IntPtr pThis, COLOR nIndex) => GetHost(pThis).TxGetSysColor(nIndex);
        private static HRESULT TxGetBackStyle(IntPtr pThis, out TXTBACKSTYLE pstyle) => GetHost(pThis).TxGetBackStyle(out pstyle);
        private static HRESULT TxGetMaxLength(IntPtr pThis, ref int plength) => GetHost(pThis).TxGetMaxLength(ref plength);
        private static HRESULT TxGetScrollBars(IntPtr pThis, out SBOUT pdwScrollBar) => GetHost(pThis).TxGetScrollBars(out pdwScrollBar);
        private static HRESULT TxGetPasswordChar(IntPtr pThis, ref char pch) => GetHost(pThis).TxGetPasswordChar(ref pch);
        private static HRESULT TxGetAcceleratorPos(IntPtr pThis, out int pcp) => GetHost(pThis).TxGetAcceleratorPos(out pcp);
        private static HRESULT TxGetExtent(IntPtr pThis, out tagSIZE lpExtent) => GetHost(pThis).TxGetExtent(out lpExtent);
        private static HRESULT OnTxCharFormatChange(IntPtr pThis, ref CHARFORMAT2W pCF) => GetHost(pThis).OnTxCharFormatChange(ref pCF);
        private static HRESULT OnTxParaFormatChange(IntPtr pThis, ref PARAFORMAT2 pPF) => GetHost(pThis).OnTxParaFormatChange(ref pPF);
        private static HRESULT TxGetPropertyBits(IntPtr pThis, TXTBIT dwMask, ref TXTBIT pdwBits) => GetHost(pThis).TxGetPropertyBits(dwMask, ref pdwBits);
        private static HRESULT TxNotify(IntPtr pThis, int iNotify, IntPtr pv) => GetHost(pThis).TxNotify(iNotify, pv);
        private static int TxImmGetContext(IntPtr pThis) => GetHost(pThis).TxImmGetContext();
        private static void TxImmReleaseContext(IntPtr pThis, int himc) => GetHost(pThis).TxImmReleaseContext(himc);
        private static HRESULT TxGetSelectionBarWidth(IntPtr pThis, ref int lSelBarWidth) => GetHost(pThis).TxGetSelectionBarWidth(ref lSelBarWidth);

        // ITextHost2
        private static bool TxIsDoubleClickPending(IntPtr pThis) => GetHost(pThis).TxIsDoubleClickPending();
        private static HRESULT TxGetWindow(IntPtr pThis, out IntPtr phwnd) => GetHost(pThis).TxGetWindow(out phwnd);
        private static HRESULT TxSetForegroundWindow(IntPtr pThis) => GetHost(pThis).TxSetForegroundWindow();
        private static IntPtr TxGetPalette(IntPtr pThis) => GetHost(pThis).TxGetPalette();
        private static HRESULT TxGetEastAsianFlags(IntPtr pThis, out ES pFlags) => GetHost(pThis).TxGetEastAsianFlags(out pFlags);
        private static IntPtr TxSetCursor2(IntPtr pThis, IntPtr hcur, bool bText) => GetHost(pThis).TxSetCursor2(hcur, bText);
        private static void TxFreeTextServicesNotification(IntPtr pThis) => GetHost(pThis).TxFreeTextServicesNotification();
        private static HRESULT TxGetEditStyle(IntPtr pThis, TXES dwItem, out TXES pdwData) => GetHost(pThis).TxGetEditStyle(dwItem, out pdwData);
        private static HRESULT TxGetWindowStyles(IntPtr pThis, out WS pdwStyle, out WS_EX pdwExStyle) => GetHost(pThis).TxGetWindowStyles(out pdwStyle, out pdwExStyle);
        private static HRESULT TxShowDropCaret(IntPtr pThis, bool fShow, IntPtr hdc, IntPtr prc) => GetHost(pThis).TxShowDropCaret(fShow, hdc, prc);
        private static HRESULT TxDestroyCaret(IntPtr pThis) => GetHost(pThis).TxDestroyCaret();
        private static HRESULT TxGetHorzExtent(IntPtr pThis, out int plHorzExtent) => GetHost(pThis).TxGetHorzExtent(out plHorzExtent);

        private static TextHost GetHost(IntPtr pThis)
        {
            _hosts.TryGetValue(pThis, out var host);
            return host._host;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                ComMemory.Free(ref _vtablePointer);
                ComMemory.Free(ref _unk);
                _disposedValue = true;
            }
        }

        ~TextHostThunk() { Dispose(false); }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }

        [StructLayout(LayoutKind.Sequential)]
        private struct ITextHost2VTable
        {
            // IUnknown
            public IntPtr QueryInterface;
            public IntPtr AddRef;
            public IntPtr Release;

            // ITextHost
            public IntPtr TxGetDC;
            public IntPtr TxReleaseDC;
            public IntPtr TxShowScrollBar;
            public IntPtr TxEnableScrollBar;
            public IntPtr TxSetScrollRange;
            public IntPtr TxSetScrollPos;
            public IntPtr TxInvalidateRect;
            public IntPtr TxViewChange;
            public IntPtr TxCreateCaret;
            public IntPtr TxShowCaret;
            public IntPtr TxSetCaretPos;
            public IntPtr TxSetTimer;
            public IntPtr TxKillTimer;
            public IntPtr TxScrollWindowEx;
            public IntPtr TxSetCapture;
            public IntPtr TxSetFocus;
            public IntPtr TxSetCursor;
            public IntPtr TxScreenToClient;
            public IntPtr TxClientToScreen;
            public IntPtr TxActivate;
            public IntPtr TxDeactivate;
            public IntPtr TxGetClientRect;
            public IntPtr TxGetViewInset;
            public IntPtr TxGetCharFormat;
            public IntPtr TxGetParaFormat;
            public IntPtr TxGetSysColor;
            public IntPtr TxGetBackStyle;
            public IntPtr TxGetMaxLength;
            public IntPtr TxGetScrollBars;
            public IntPtr TxGetPasswordChar;
            public IntPtr TxGetAcceleratorPos;
            public IntPtr TxGetExtent;
            public IntPtr OnTxCharFormatChange;
            public IntPtr OnTxParaFormatChange;
            public IntPtr TxGetPropertyBits;
            public IntPtr TxNotify;
            public IntPtr TxImmGetContext;
            public IntPtr TxImmReleaseContext;
            public IntPtr TxGetSelectionBarWidth;

            // ITextHost2
            public IntPtr TxIsDoubleClickPending;
            public IntPtr TxGetWindow;
            public IntPtr TxSetForegroundWindow;
            public IntPtr TxGetPalette;
            public IntPtr TxGetEastAsianFlags;
            public IntPtr TxSetCursor2;
            public IntPtr TxFreeTextServicesNotification;
            public IntPtr TxGetEditStyle;
            public IntPtr TxGetWindowStyles;
            public IntPtr TxShowDropCaret;
            public IntPtr TxDestroyCaret;
            public IntPtr TxGetHorzExtent;
        }
    }
}
