using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace DirectN
{
    [ComVisible(true)]
    public class TextHost : ITextHost2, IDisposable//, ICustomQueryInterface
    {
        private bool _disposedValue;
        private tagRECT _rect;
        private string _faceName;
        private int _height;
        private short _weight;
        private int _textColor;
        private int _backColor;
        private TextHostOptions _options;
        private PFA _aligment;
        private readonly ITextServices2 _services;
        private ComMemory<CHARFORMAT2W> _charFormat;
        private ComMemory<PARAFORMAT2> _paraFormat;
        private readonly TextServices32 _services32;

        public TextHost(TextServicesGenerator generator = TextServicesGenerator.Default)
        {
            _textColor = 0xFFFFFF; // white
            _backColor = 0x00FFFFFF; // transparent
            _options = TextHostOptions.Multiline;
            HostThunk = new TextHostThunk(this);

            _services = this.Create<ITextServices2>(generator);
            if (IntPtr.Size == 4)
            {
                _services32 = new TextServices32(_services);
            }
        }

        internal TextHostThunk HostThunk { get; }

        // ITextDocument(2)
        public dynamic Document
        {
            get
            {
                dynamic doc = _services;
                return doc;
            }
        }

        public virtual string Text
        {
            get
            {
                try
                {
                    GetWholeRange().GetText2(0, out string value);
                    return value;
                }
                catch
                {
                    return string.Empty;
                }
            }
            set
            {
                GetWholeRange().SetText2(0, value);
            }
        }

        public virtual string RtfText
        {
            get
            {
                try
                {
                    GetWholeRange().GetText2(tomConstants.tomConvertRTF | tomConstants.tomGetUtf16, out string value);
                    return value;
                }
                catch
                {
                    return string.Empty;
                }
            }
            set
            {
                GetWholeRange().SetText2(tomConstants.tomConvertRTF, value);
            }
        }

        public virtual string HtmlText
        {
            get
            {
                try
                {
                    GetWholeRange().GetText2(tomConstants.tomConvertHtml | tomConstants.tomGetUtf16, out string value);
                    return value;
                }
                catch
                {
                    return string.Empty;
                }
            }
            set
            {
                // https://devblogs.microsoft.com/math-in-office/richedit-html-support/
                // note this doesn't seem to work right now...
                GetWholeRange().SetText2(tomConstants.tomConvertHtml, value);
            }
        }

        private dynamic GetWholeRange()
        {
            var d = Document;
            var range = d.Range(0, 0);
            range.MoveEnd(tomConstants.tomStory, 1);
            return range;
        }

        public virtual TextHostOptions Options
        {
            get => _options;
            set
            {
                if (_options == value)
                    return;

                var oldValue = _options;
                _options = value;

                var change = (TXTBIT)(oldValue ^ _options);
                ChangeBitNotify(change);
            }
        }

        public virtual int TextColor
        {
            get => _textColor;
            set
            {
                if (_textColor == value)
                    return;

                _textColor = value;
                ResetCharFormat();
            }
        }

        public virtual int BackColor
        {
            get => _backColor;
            set
            {
                if (_backColor == value)
                    return;

                _backColor = value;
                ResetCharFormat();
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                if (_height == value)
                    return;

                _height = value;
                ResetCharFormat();
            }
        }

        public virtual short Weight
        {
            get => _weight;
            set
            {
                if (_weight == value)
                    return;

                _weight = value;
                ResetCharFormat();
            }
        }

        public virtual string FaceName
        {
            get => _faceName;
            set
            {
                if (_faceName == value)
                    return;

                _faceName = value;
                ResetCharFormat();
            }
        }

        public virtual PFA Aligment
        {
            get => _aligment;
            set
            {
                if (_aligment == value)
                    return;

                _aligment = value;
                ResetParaFormat();
            }
        }

#if DEBUG
        public static ILogger Logger { get; set; }
#endif

        public static int ToColor(_D3DCOLORVALUE color)
        {
            int i = color.BR;
            i |= color.BG << 8;
            i |= color.BB << 16;
            i |= color.BA << 24;

            // for some reason, white is not 0xFFFFFFFF
            if (i == -1)
                return 0xFFFFFF;

            return i;
        }

        public static _D3DCOLORVALUE ToColor(int color) => new _D3DCOLORVALUE(color);

        private void ResetCharFormat()
        {
            Interlocked.Exchange(ref _charFormat, null)?.Dispose();
            ChangeBitNotify(TXTBIT.TXTBIT_CHARFORMATCHANGE);
        }

        private void ResetParaFormat()
        {
            Interlocked.Exchange(ref _paraFormat, null)?.Dispose();
            ChangeBitNotify(TXTBIT.TXTBIT_PARAFORMATCHANGE);
        }

        protected virtual void ChangeBitNotify(TXTBIT bit)
        {
            if (bit == 0)
                return;

            if (_services32 != null)
            {
                _services32.OnTxPropertyBitsChange(bit, bit).ThrowOnError();
            }
            else
            {
                _services.OnTxPropertyBitsChange(bit, bit).ThrowOnError();
            }
        }

        public tagSIZE GetNaturalSize(TXTNATURALSIZE mode, D2D_SIZE_F constraint) => GetNaturalSize(mode, constraint, out _);
        public virtual tagSIZE GetNaturalSize(TXTNATURALSIZE mode, D2D_SIZE_F constraint, out int ascent)
        {
            Trace("mode: " + mode + " constraint: " + constraint);
            var width = (int)constraint.width;
            if (Options.HasFlag(TextHostOptions.WordWrap))
            {
                if (width == int.MaxValue)
                {
                    // not sure we should do this or throw some error
                    //Options &= ~TextHostOptions.WordWrap;
                }
            }

            var height = 0; // warning! not sure why this seems to be always good? check vertical mode
            return TxGetNaturalSize2(mode, width, height, null, out ascent);
        }

        protected tagSIZE TxGetNaturalSize2(TXTNATURALSIZE mode, int width, int height, tagSIZE? extent = null) => TxGetNaturalSize2(mode, width, height, extent, out _);
        protected virtual tagSIZE TxGetNaturalSize2(TXTNATURALSIZE mode, int width, int height, tagSIZE? extent, out int ascent)
        {
            if (extent == null)
            {
                // for some reason, -1, -1 avoids the himetric mumbo jumbo computation...
                extent = new tagSIZE { width = uint.MaxValue, height = uint.MaxValue };
            }

            var ext = extent.Value;
            if (_services32 != null)
            {
                _services32.TxGetNaturalSize2(DVASPECT.DVASPECT_CONTENT, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, mode, ref ext, ref width, ref height, out ascent).ThrowOnError();
            }
            else
            {
                _services.TxGetNaturalSize2(DVASPECT.DVASPECT_CONTENT, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, mode, ref ext, ref width, ref height, out ascent).ThrowOnError();
            }
            return new tagSIZE(width, height);
        }

        //CustomQueryInterfaceResult ICustomQueryInterface.GetInterface(ref Guid iid, out IntPtr ppv)
        //{
        //    ppv = IntPtr.Zero;
        //    Trace("iid: " + iid);
        //    return CustomQueryInterfaceResult.NotHandled;
        //}

        [Conditional("DEBUG")]
        private static void Trace(string message = null, [CallerMemberName] string methodName = null) => Trace(TraceLevel.Info, message, methodName);

        [Conditional("DEBUG")]
        private static void Trace(TraceLevel level, string message = null, [CallerMemberName] string methodName = null)
        {
#if DEBUG
            Logger?.Log(level, message, methodName);
#endif
        }

        public virtual void Activate(tagRECT rect)
        {
            _rect = rect;
            if (_services32 != null)
            {
                _services32.OnTxInPlaceActivate(ref rect).ThrowOnError();
                _services32.OnTxUIActivate().ThrowOnError();
            }
            else
            {
                _services.OnTxInPlaceActivate(ref rect).ThrowOnError();
                _services.OnTxUIActivate().ThrowOnError();
            }
        }

        public void Draw(IComObject<ID2D1RenderTarget> target, tagRECT rc) => Draw(target?.Object, rc);
        public virtual void Draw(ID2D1RenderTarget target, tagRECT rc)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            Trace("rc: " + rc);
            rc = rc.PixelToDip();
            if (_services32 != null)
            {
                _services32.TxDrawD2D(target, ref rc, IntPtr.Zero, TXTVIEW.TXTVIEW_ACTIVE).ThrowOnError();
            }
            else
            {
                _services.TxDrawD2D(target, ref rc, IntPtr.Zero, TXTVIEW.TXTVIEW_ACTIVE).ThrowOnError();
            }
        }

        public virtual HRESULT OnTxCharFormatChange(ref CHARFORMAT2W pCF)
        {
            Trace("pCF: " + pCF);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT OnTxParaFormatChange(ref PARAFORMAT2 pPF)
        {
            Trace("pPF: " + pPF);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxActivate(IntPtr plOldState)
        {
            Trace("plOldState: " + plOldState);
            return HRESULTS.S_OK;
        }

        public virtual bool TxClientToScreen(ref tagPOINT lppt)
        {
            Trace("lppt: " + lppt);
            return false;
        }

        public virtual bool TxScreenToClient(ref tagPOINT lppt)
        {
            Trace("lppt: " + lppt);
            return false;
        }

        public virtual bool TxCreateCaret(IntPtr hbmp, int xWidth, int yHeight)
        {
            Trace("hbmp: " + hbmp + " xWidth: " + xWidth + " yHeight: " + yHeight);
            return false;
        }

        public virtual HRESULT TxDeactivate(int lNewState)
        {
            Trace("lNewState: " + lNewState);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxDestroyCaret()
        {
            Trace();
            return HRESULTS.S_OK;
        }

        public virtual bool TxEnableScrollBar(SB fuSBFlags, ESB fuArrowflags)
        {
            Trace("fuSBFlags: " + fuSBFlags + " fuArrowflags: " + fuArrowflags);
            return true;
        }

        public virtual void TxFreeTextServicesNotification()
        {
            Trace();
        }

        public virtual HRESULT TxGetAcceleratorPos(out int pcp)
        {
            pcp = -1;
            Trace("pcp: " + pcp);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetBackStyle(out TXTBACKSTYLE pstyle)
        {
            pstyle = TXTBACKSTYLE.TXTBACK_TRANSPARENT;
            Trace("pstyle: " + pstyle);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetCharFormat(out IntPtr ppCF)
        {
            if (_charFormat == null)
            {
                var format = new CHARFORMAT2W();
                format.cbSize = Marshal.SizeOf<CHARFORMAT2W>();
                format.dwMask = CFM.CFM_COLOR | CFM.CFM_BACKCOLOR;
                format.crTextColor = TextColor;
                format.crBackColor = BackColor;

                format.FaceName = FaceName.Nullify();
                if (!format.szFaceName.IsEmpty())
                {
                    format.dwMask |= CFM.CFM_FACE;
                }

                format.yHeight = (int)D2D1Functions.PointsToTwips(Height);
                if (format.yHeight != 0)
                {
                    format.dwMask |= CFM.CFM_SIZE;
                }

                format.wWeight = Weight;
                if (format.wWeight != 0)
                {
                    format.dwMask |= CFM.CFM_WEIGHT;
                }

                //format.dwEffects = CFE.CFE_AUTOCOLOR;
                //format.dwMask |= CFM.CFM_EFFECTS2;

                _charFormat = new ComMemory<CHARFORMAT2W>(format);
                Trace("fmt: " + format);
            }

            ppCF = _charFormat.Pointer;
            Trace("ppCF: " + ppCF);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetParaFormat(out IntPtr ppPF)
        {
            if (_paraFormat == null)
            {
                var format = new PARAFORMAT2();
                format.cbSize = Marshal.SizeOf<PARAFORMAT2>();
                format.dwMask = PFM.PFM_ALL2;
                format.wBorderWidth = (short)D2D1Functions.PointsToTwips(20);
                format.wAlignment = Aligment;
                _paraFormat = new ComMemory<PARAFORMAT2>(format);
                Trace("fmt: " + format);
            }

            ppPF = _paraFormat.Pointer;
            Trace("ppPF: " + ppPF);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetClientRect(ref tagRECT prc)
        {
            prc = _rect;
            Trace("prc: " + prc);
            return HRESULTS.S_OK;
        }

        public virtual IntPtr TxGetDC()
        {
            Trace();
            return IntPtr.Zero;
        }

        public virtual int TxReleaseDC(IntPtr hdc)
        {
            Trace("hdc: " + hdc);
            return 1;
        }

        public virtual HRESULT TxGetEastAsianFlags(out ES pFlags)
        {
            pFlags = ES.ES_NOIME;
            Trace("pFlags: " + pFlags);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetEditStyle(TXES dwItem, out TXES pdwData)
        {
            pdwData = TXES.TXES_ISDIALOG;
            Trace("dwItem: " + dwItem + " pdwData: " + pdwData);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetExtent(out tagSIZE lpExtent)
        {
            lpExtent = new tagSIZE();
            //lpExtent.width = 400;
            //lpExtent.height = 400;
            //lpExtent = lpExtent.PixelToHiMetric();
            Trace("lpExtent: " + lpExtent);
            //return HRESULTS.S_OK;
            return HRESULTS.E_NOTIMPL;
        }

        public virtual HRESULT TxGetHorzExtent(out int plHorzExtent)
        {
            plHorzExtent = 0;
            Trace("plHorzExtent: " + plHorzExtent);
            return HRESULTS.E_NOTIMPL;
        }

        public virtual HRESULT TxGetMaxLength(ref int plength)
        {
            plength = -1;
            Trace("plength: " + plength);
            return HRESULTS.S_OK;
        }

        public virtual IntPtr TxGetPalette()
        {
            Trace();
            return IntPtr.Zero;
        }

        public virtual HRESULT TxGetPasswordChar(ref char pch)
        {
            Trace("pch: " + pch);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetPropertyBits(TXTBIT dwMask, ref TXTBIT pdwBits)
        {
            //pdwBits = dwMask;
            //pdwBits &= ~TXTBIT.TXTBIT_VERTICAL;
            //pdwBits &= ~TXTBIT.TXTBIT_ALLOWBEEP;
            //pdwBits &= ~TXTBIT.TXTBIT_USEPASSWORD;
            //pdwBits &= ~TXTBIT.TXTBIT_READONLY;

            pdwBits = TXTBIT.TXTBIT_RICHTEXT | TXTBIT.TXTBIT_D2DDWRITE;
            if (_options.HasFlag(TextHostOptions.WordWrap))
            {
                pdwBits |= TXTBIT.TXTBIT_WORDWRAP;
            }

            if (_options.HasFlag(TextHostOptions.Vertical))
            {
                pdwBits |= TXTBIT.TXTBIT_VERTICAL;
            }

            if (_options.HasFlag(TextHostOptions.ReadOnly))
            {
                pdwBits |= TXTBIT.TXTBIT_READONLY;
            }

            if (_options.HasFlag(TextHostOptions.Multiline))
            {
                pdwBits |= TXTBIT.TXTBIT_MULTILINE;
            }

            pdwBits &= dwMask;
            //pdwBits |= TXTBIT.TXTBIT_UNDOCUMENTED2;
            Trace("dwMask: " + dwMask + " pdwBits: " + pdwBits);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetScrollBars(out SBOUT pdwScrollBar)
        {
            //pdwScrollBar = SBOUT.WS_VSCROLL | SBOUT.WS_HSCROLL;
            pdwScrollBar = 0;
            Trace("pdwScrollBar: " + pdwScrollBar);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetSelectionBarWidth(ref int lSelBarWidth)
        {
            lSelBarWidth = 0;
            Trace("lSelBarWidth: " + lSelBarWidth);
            return HRESULTS.S_OK;
        }

        public virtual int TxGetSysColor(COLOR nIndex)
        {
            //if (nIndex == COLOR.COLOR_WINDOW)
            //    return 0xF03050;

            var color = GetSysColor(nIndex);
            Trace("nIndex: " + nIndex + " color:#" + color.ToString("X8"));
            return color;
        }

        public virtual HRESULT TxGetViewInset(ref tagRECT prc)
        {
            Trace("prc: " + prc);
            prc.left = 0;
            prc.top = 0;
            prc.right = 0;
            prc.bottom = 0;
            prc = prc.PixelToHiMetric();
            Trace("prc: " + prc);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetWindow(out IntPtr phwnd)
        {
            phwnd = IntPtr.Zero;
            Trace("phwnd: " + phwnd);
            return HRESULTS.S_OK;
        }

        public virtual HRESULT TxGetWindowStyles(out WS pdwStyle, out WS_EX pdwExStyle)
        {
            pdwStyle = 0;
            pdwExStyle = 0;
            Trace("pdwStyle: " + pdwStyle + " pdwExStyle: " + pdwExStyle);
            return HRESULTS.S_OK;
        }

        public virtual int TxImmGetContext()
        {
            Trace();
            return 0;
        }

        public virtual void TxImmReleaseContext(int himc)
        {
            Trace();
        }

        public virtual void TxInvalidateRect(IntPtr prc, bool fMode)
        {
            Trace("prc: " + prc + " fMode: " + fMode);
        }

        public virtual bool TxIsDoubleClickPending()
        {
            Trace();
            return false;
        }

        public virtual HRESULT TxNotify(int iNotify, IntPtr pv)
        {
            Trace("iNotify: " + iNotify + " pv: " + pv);
            return HRESULTS.S_OK;
        }

        public virtual void TxScrollWindowEx(int dx, int dy, IntPtr lprcScroll, IntPtr lprcClip, IntPtr hrgnUpdate, IntPtr lprcUpdate, TSW fuScroll)
        {
            Trace("dx: " + dx + " dy: " + dy + " lprcScroll: " + lprcScroll + " lprcClip: " + lprcClip + " hrgnUpdate: " + hrgnUpdate + " lprcUpdate: " + lprcUpdate + " fuScroll: " + fuScroll);
        }

        public virtual void TxSetCapture(bool fCapture)
        {
            Trace("fCapture: " + fCapture);
        }

        public virtual bool TxSetCaretPos(int x, int y)
        {
            Trace("x: " + x + " y: " + y);
            return true;
        }

        public virtual void TxSetCursor(IntPtr hcur, bool fText)
        {
            Trace("hcur: " + hcur + " fText: " + fText);
        }

        public virtual IntPtr TxSetCursor2(IntPtr hcur, bool bText)
        {
            Trace("hcur: " + hcur + " bText: " + bText);
            return IntPtr.Zero;
        }

        public virtual void TxSetFocus()
        {
            Trace();
        }

        public virtual HRESULT TxSetForegroundWindow()
        {
            Trace();
            return HRESULTS.S_OK;
        }

        public virtual bool TxSetScrollPos(int fnBar, int nPos, bool fRedraw)
        {
            Trace("fnBar: " + fnBar + " nPos: " + nPos + " fRedraw: " + fRedraw);
            return true;
        }

        public virtual bool TxSetScrollRange(SB fnBar, int nMinPos, int nMaxPos, bool fRedraw)
        {
            Trace("fnBar: " + fnBar + " nMinPos: " + nMinPos + " nMaxPos: " + nMaxPos + " fRedraw: " + fRedraw);
            return true;
        }

        public virtual void TxKillTimer(int idTimer)
        {
            Trace("idTimer: " + idTimer);
        }

        public virtual bool TxSetTimer(int idTimer, int uTimeout)
        {
            Trace("idTimer: " + idTimer + " uTimeout: " + uTimeout);
            return true;
        }

        public virtual bool TxShowCaret(bool fShow)
        {
            Trace("fShow: " + fShow);
            return true;
        }

        public virtual HRESULT TxShowDropCaret(bool fShow, IntPtr hdc, IntPtr prc)
        {
            Trace("fShow: " + fShow + " hdc: " + hdc + " prc: " + prc);
            return HRESULTS.S_OK;
        }

        public virtual bool TxShowScrollBar(SB fnBar, bool fShow)
        {
            Trace("fnBar: " + fnBar + " fShow: " + fShow);
            return fShow;
        }

        public virtual void TxViewChange(bool fUpdate)
        {
            Trace("fUpdate: " + fUpdate);
        }

        [DllImport("user32")]
        private static extern int GetSysColor(COLOR nIndex);

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                TextServicesFunctions.Shutdown(_services, false);
                _charFormat?.Dispose();
                _paraFormat?.Dispose();
                HostThunk?.Dispose();
                _disposedValue = true;
            }
        }

        ~TextHost() { Dispose(false); }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
    }
}
