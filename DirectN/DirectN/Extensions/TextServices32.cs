using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    internal class TextServices32
    {
        private readonly ITextServicesVTable _vtable;
        private readonly TxSetTextFn _setText;
        private readonly OnTxInPlaceActivateFn _inPlaceActivate;
        private readonly OnTxUIActivateFn _uIActivate;
        private readonly OnTxPropertyBitsChangeFn _onTxPropertyBitsChange;
        private readonly TxSendMessageFn _txSendMessage;
        private readonly TxDrawD2DFn _txDrawD2D;
        private readonly TxGetNaturalSize2Fn _txGetNaturalSize2;
        private readonly IntPtr _unk;

        public TextServices32(ITextServices services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            _vtable = new ITextServicesVTable();
            _unk = Marshal.GetIUnknownForObject(services);
            var vtablePtr = Marshal.ReadIntPtr(_unk);
            Marshal.PtrToStructure(vtablePtr, _vtable);
            _setText = Marshal.GetDelegateForFunctionPointer<TxSetTextFn>(_vtable.TxSetText);
            _inPlaceActivate = Marshal.GetDelegateForFunctionPointer<OnTxInPlaceActivateFn>(_vtable.OnTxInPlaceActivate);
            _uIActivate = Marshal.GetDelegateForFunctionPointer<OnTxUIActivateFn>(_vtable.OnTxUIActivate);
            _onTxPropertyBitsChange = Marshal.GetDelegateForFunctionPointer<OnTxPropertyBitsChangeFn>(_vtable.OnTxPropertyBitsChange);
            _txSendMessage = Marshal.GetDelegateForFunctionPointer<TxSendMessageFn>(_vtable.TxSendMessage);
            _txDrawD2D = Marshal.GetDelegateForFunctionPointer<TxDrawD2DFn>(_vtable.TxDrawD2D);
            _txGetNaturalSize2 = Marshal.GetDelegateForFunctionPointer<TxGetNaturalSize2Fn>(_vtable.TxGetNaturalSize2);
        }

        public HRESULT TxSetText(string text) => _setText(_unk, text);
        public HRESULT OnTxInPlaceActivate(ref tagRECT rect) => _inPlaceActivate(_unk, ref rect);
        public HRESULT OnTxUIActivate() => _uIActivate(_unk);
        public HRESULT OnTxPropertyBitsChange(TXTBIT dwMask, TXTBIT dwBits) => _onTxPropertyBitsChange(_unk, dwMask, dwBits);
        public HRESULT TxSendMessage(int msg, IntPtr wparam, IntPtr lparam, out IntPtr plresult) => _txSendMessage(_unk, msg, wparam, lparam, out plresult);
        public HRESULT TxDrawD2D(ID2D1RenderTarget pRenderTarget, ref tagRECT lprcBounds, IntPtr lprcUpdate, TXTVIEW lViewId) => _txDrawD2D(_unk, pRenderTarget, ref lprcBounds, lprcUpdate, lViewId);
        public HRESULT TxGetNaturalSize2(
            DVASPECT dwAspect,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            IntPtr ptd,
            TXTNATURALSIZE dwMode,
            ref tagSIZE psizelExtent,
            ref int pwidth,
            ref int pheight,
            out int pascent) => _txGetNaturalSize2(_unk, dwAspect, hdcDraw, hicTargetDev, ptd, dwMode, ref psizelExtent, ref pwidth, ref pheight, out pascent);

        // ITextServices
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxSendMessageFn(IntPtr pThis, int msg, IntPtr wparam, IntPtr lparam, out IntPtr plresult);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxDrawFn(IntPtr pThis,
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

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetHScrollFn(IntPtr pThis, out int plMin, out int plMax, out int plPos, out int plPage, out bool pfEnabled);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetVScrollFn(IntPtr pThis, out int plMin, out int plMax, out int plPos, out int plPage, out bool pfEnabled);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxSetCursorFn(IntPtr pThis,
            DVASPECT dwDrawAspect,
            int lindex,
            IntPtr pvAspect,
            IntPtr ptd,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            ref tagRECT lprcClient,
            int x,
            int y);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxQueryHitPointFn(IntPtr pThis,
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

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxInPlaceActivateFn(IntPtr pThis, ref tagRECT prcClient);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxInPlaceDeactivateFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxUIActivateFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxUIDeactivateFn(IntPtr pThis);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetTextFn(IntPtr pThis, [MarshalAs(UnmanagedType.BStr)] out string pbstrText);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxSetTextFn(IntPtr pThis, [MarshalAs(UnmanagedType.LPWStr)] string pszText);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetCurTargetXFn(IntPtr pThis, out int x);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetBaseLinePosFn(IntPtr pThis, out int pos);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetNaturalSizeFn(IntPtr pThis,
            DVASPECT dwAspect,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            IntPtr ptd,
            TXTNATURALSIZE dwMode,
            IntPtr psizelExtent,
            ref int pwidth,
            ref int pheight);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetDropTargetFn(IntPtr pThis, out object /*IDropTarget*/ ppDropTarget);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT OnTxPropertyBitsChangeFn(IntPtr pThis, TXTBIT dwMask, TXTBIT dwBits);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetCachedSizeFn(IntPtr pThis, out int pdwWidth, out int pdwHeight);

        // ITextServices2
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxGetNaturalSize2Fn(IntPtr pThis,
            DVASPECT dwAspect,
            IntPtr hdcDraw,
            IntPtr hicTargetDev,
            IntPtr ptd,
            TXTNATURALSIZE dwMode,
            ref tagSIZE psizelExtent,
            ref int pwidth,
            ref int pheight,
            out int pascent);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate HRESULT TxDrawD2DFn(IntPtr pThis, ID2D1RenderTarget pRenderTarget, ref tagRECT lprcBounds, IntPtr lprcUpdate, TXTVIEW lViewId);

        [StructLayout(LayoutKind.Sequential)]
        private class ITextServicesVTable
        {
            // IUnknown
            public IntPtr QueryInterface;
            public IntPtr AddRef;
            public IntPtr Release;

            // ITextServices
            public IntPtr TxSendMessage;
            public IntPtr TxDraw;
            public IntPtr TxGetHScroll;
            public IntPtr TxGetVScroll;
            public IntPtr OnTxSetCursor;
            public IntPtr TxQueryHitPoint;
            public IntPtr OnTxInPlaceActivate;
            public IntPtr OnTxInPlaceDeactivate;
            public IntPtr OnTxUIActivate;
            public IntPtr OnTxUIDeactivate;
            public IntPtr TxGetText;
            public IntPtr TxSetText;
            public IntPtr TxGetCurTargetX;
            public IntPtr TxGetBaseLinePos;
            public IntPtr TxGetNaturalSize;
            public IntPtr TxGetDropTarget;
            public IntPtr OnTxPropertyBitsChange;
            public IntPtr TxGetCachedSize;

            // ITextServices2
            public IntPtr TxGetNaturalSize2;
            public IntPtr TxDrawD2D;
        }
    }
}
