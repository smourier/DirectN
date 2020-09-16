using System;

namespace DirectN
{
    public static class MessageDecoder
    {
        public static string Decode(this MSG msg) => Decode(msg.hwnd, msg.message, msg.wParam, msg.lParam);
        public static string Decode(IntPtr handle, int msg, IntPtr wParam, IntPtr lParam, IntPtr? lResult = null)
        {
            string id = Parenthesize(MsgToString(msg));
            string description = string.Empty;
            if (msg == WM_PARENTNOTIFY)
            {
                description = Parenthesize(MsgToString(LOWORD(wParam)));
            }

            var s = "msg=0x" + Convert.ToString(msg, 16) + " (" + msg + ")" + id
            + " hwnd=0x" + Convert.ToString((long)handle, 16)
            + " wparam=0x" + Convert.ToString((long)wParam, 16)
            + " lparam=0x" + Convert.ToString((long)lParam, 16) + description;

            if (lResult.HasValue)
            {
                s += " result=0x" + Convert.ToString((long)lResult.Value, 16);
            }
            return s;
        }

        public static bool IsMouseButtonMessage(int msg)
        {
            return msg == WM_LBUTTONDOWN || msg == WM_LBUTTONUP || msg == WM_LBUTTONDBLCLK ||
                msg == WM_RBUTTONDOWN || msg == WM_RBUTTONUP || msg == WM_RBUTTONDBLCLK ||
                msg == WM_MBUTTONDOWN || msg == WM_MBUTTONUP || msg == WM_MBUTTONDBLCLK ||
                msg == WM_XBUTTONDOWN || msg == WM_XBUTTONUP || msg == WM_XBUTTONDBLCLK;
        }

        private static string Parenthesize(string input)
        {
            if (input == null)
                return string.Empty;

            return " (" + input + ")";
        }

        private static int LOWORD(int n) => n & 0xffff;
        private static int LOWORD(IntPtr n) => LOWORD((int)(long)n);
        public static string MsgToString(int msg)
        {
            string text;
            switch (msg)
            {
                case WM_NULL: text = "WM_NULL"; break;
                case WM_CREATE: text = "WM_CREATE"; break;
                case WM_DESTROY: text = "WM_DESTROY"; break;
                case WM_MOVE: text = "WM_MOVE"; break;
                case WM_SIZE: text = "WM_SIZE"; break;
                case WM_ACTIVATE: text = "WM_ACTIVATE"; break;
                case WM_SETFOCUS: text = "WM_SETFOCUS"; break;
                case WM_KILLFOCUS: text = "WM_KILLFOCUS"; break;
                case WM_ENABLE: text = "WM_ENABLE"; break;
                case WM_SETREDRAW: text = "WM_SETREDRAW"; break;
                case WM_SETTEXT: text = "WM_SETTEXT"; break;
                case WM_GETTEXT: text = "WM_GETTEXT"; break;
                case WM_GETTEXTLENGTH: text = "WM_GETTEXTLENGTH"; break;
                case WM_PAINT: text = "WM_PAINT"; break;
                case WM_CLOSE: text = "WM_CLOSE"; break;
                case WM_QUERYENDSESSION: text = "WM_QUERYENDSESSION"; break;
                case WM_QUIT: text = "WM_QUIT"; break;
                case WM_QUERYOPEN: text = "WM_QUERYOPEN"; break;
                case WM_ERASEBKGND: text = "WM_ERASEBKGND"; break;
                case WM_SYSCOLORCHANGE: text = "WM_SYSCOLORCHANGE"; break;
                case WM_ENDSESSION: text = "WM_ENDSESSION"; break;
                case WM_SHOWWINDOW: text = "WM_SHOWWINDOW"; break;
                case WM_WININICHANGE: text = "WM_WININICHANGE"; break;
                case WM_DEVMODECHANGE: text = "WM_DEVMODECHANGE"; break;
                case WM_ACTIVATEAPP: text = "WM_ACTIVATEAPP"; break;
                case WM_FONTCHANGE: text = "WM_FONTCHANGE"; break;
                case WM_TIMECHANGE: text = "WM_TIMECHANGE"; break;
                case WM_CANCELMODE: text = "WM_CANCELMODE"; break;
                case WM_SETCURSOR: text = "WM_SETCURSOR"; break;
                case WM_MOUSEACTIVATE: text = "WM_MOUSEACTIVATE"; break;
                case WM_CHILDACTIVATE: text = "WM_CHILDACTIVATE"; break;
                case WM_QUEUESYNC: text = "WM_QUEUESYNC"; break;
                case WM_GETMINMAXINFO: text = "WM_GETMINMAXINFO"; break;
                case WM_PAINTICON: text = "WM_PAINTICON"; break;
                case WM_ICONERASEBKGND: text = "WM_ICONERASEBKGND"; break;
                case WM_NEXTDLGCTL: text = "WM_NEXTDLGCTL"; break;
                case WM_SPOOLERSTATUS: text = "WM_SPOOLERSTATUS"; break;
                case WM_DRAWITEM: text = "WM_DRAWITEM"; break;
                case WM_MEASUREITEM: text = "WM_MEASUREITEM"; break;
                case WM_DELETEITEM: text = "WM_DELETEITEM"; break;
                case WM_VKEYTOITEM: text = "WM_VKEYTOITEM"; break;
                case WM_CHARTOITEM: text = "WM_CHARTOITEM"; break;
                case WM_SETFONT: text = "WM_SETFONT"; break;
                case WM_GETFONT: text = "WM_GETFONT"; break;
                case WM_SETHOTKEY: text = "WM_SETHOTKEY"; break;
                case WM_GETHOTKEY: text = "WM_GETHOTKEY"; break;
                case WM_QUERYDRAGICON: text = "WM_QUERYDRAGICON"; break;
                case WM_COMPAREITEM: text = "WM_COMPAREITEM"; break;
                case WM_GETOBJECT: text = "WM_GETOBJECT"; break;
                case WM_COMPACTING: text = "WM_COMPACTING"; break;
                case WM_COMMNOTIFY: text = "WM_COMMNOTIFY"; break;
                case WM_WINDOWPOSCHANGING: text = "WM_WINDOWPOSCHANGING"; break;
                case WM_WINDOWPOSCHANGED: text = "WM_WINDOWPOSCHANGED"; break;
                case WM_POWER: text = "WM_POWER"; break;
                case WM_COPYDATA: text = "WM_COPYDATA"; break;
                case WM_CANCELJOURNAL: text = "WM_CANCELJOURNAL"; break;
                case WM_NOTIFY: text = "WM_NOTIFY"; break;
                case WM_INPUTLANGCHANGEREQUEST: text = "WM_INPUTLANGCHANGEREQUEST"; break;
                case WM_INPUTLANGCHANGE: text = "WM_INPUTLANGCHANGE"; break;
                case WM_TCARD: text = "WM_TCARD"; break;
                case WM_HELP: text = "WM_HELP"; break;
                case WM_USERCHANGED: text = "WM_USERCHANGED"; break;
                case WM_NOTIFYFORMAT: text = "WM_NOTIFYFORMAT"; break;
                case WM_CONTEXTMENU: text = "WM_CONTEXTMENU"; break;
                case WM_STYLECHANGING: text = "WM_STYLECHANGING"; break;
                case WM_STYLECHANGED: text = "WM_STYLECHANGED"; break;
                case WM_DISPLAYCHANGE: text = "WM_DISPLAYCHANGE"; break;
                case WM_GETICON: text = "WM_GETICON"; break;
                case WM_SETICON: text = "WM_SETICON"; break;
                case WM_NCCREATE: text = "WM_NCCREATE"; break;
                case WM_NCDESTROY: text = "WM_NCDESTROY"; break;
                case WM_NCCALCSIZE: text = "WM_NCCALCSIZE"; break;
                case WM_NCHITTEST: text = "WM_NCHITTEST"; break;
                case WM_NCPAINT: text = "WM_NCPAINT"; break;
                case WM_NCACTIVATE: text = "WM_NCACTIVATE"; break;
                case WM_GETDLGCODE: text = "WM_GETDLGCODE"; break;
                case WM_NCMOUSEMOVE: text = "WM_NCMOUSEMOVE"; break;
                case WM_NCLBUTTONDOWN: text = "WM_NCLBUTTONDOWN"; break;
                case WM_NCLBUTTONUP: text = "WM_NCLBUTTONUP"; break;
                case WM_NCLBUTTONDBLCLK: text = "WM_NCLBUTTONDBLCLK"; break;
                case WM_NCRBUTTONDOWN: text = "WM_NCRBUTTONDOWN"; break;
                case WM_NCRBUTTONUP: text = "WM_NCRBUTTONUP"; break;
                case WM_NCRBUTTONDBLCLK: text = "WM_NCRBUTTONDBLCLK"; break;
                case WM_NCMBUTTONDOWN: text = "WM_NCMBUTTONDOWN"; break;
                case WM_NCMBUTTONUP: text = "WM_NCMBUTTONUP"; break;
                case WM_NCMBUTTONDBLCLK: text = "WM_NCMBUTTONDBLCLK"; break;
                case WM_KEYDOWN: text = "WM_KEYDOWN"; break;
                case WM_KEYUP: text = "WM_KEYUP"; break;
                case WM_CHAR: text = "WM_CHAR"; break;
                case WM_DEADCHAR: text = "WM_DEADCHAR"; break;
                case WM_SYSKEYDOWN: text = "WM_SYSKEYDOWN"; break;
                case WM_SYSKEYUP: text = "WM_SYSKEYUP"; break;
                case WM_SYSCHAR: text = "WM_SYSCHAR"; break;
                case WM_SYSDEADCHAR: text = "WM_SYSDEADCHAR"; break;
                case WM_KEYLAST: text = "WM_KEYLAST"; break;
                case WM_IME_STARTCOMPOSITION: text = "WM_IME_STARTCOMPOSITION"; break;
                case WM_IME_ENDCOMPOSITION: text = "WM_IME_ENDCOMPOSITION"; break;
                case WM_IME_COMPOSITION: text = "WM_IME_COMPOSITION"; break;
                case WM_INITDIALOG: text = "WM_INITDIALOG"; break;
                case WM_COMMAND: text = "WM_COMMAND"; break;
                case WM_SYSCOMMAND: text = "WM_SYSCOMMAND"; break;
                case WM_TIMER: text = "WM_TIMER"; break;
                case WM_HSCROLL: text = "WM_HSCROLL"; break;
                case WM_VSCROLL: text = "WM_VSCROLL"; break;
                case WM_INITMENU: text = "WM_INITMENU"; break;
                case WM_INITMENUPOPUP: text = "WM_INITMENUPOPUP"; break;
                case WM_MENUSELECT: text = "WM_MENUSELECT"; break;
                case WM_MENUCHAR: text = "WM_MENUCHAR"; break;
                case WM_ENTERIDLE: text = "WM_ENTERIDLE"; break;
                case WM_CTLCOLORMSGBOX: text = "WM_CTLCOLORMSGBOX"; break;
                case WM_CTLCOLOREDIT: text = "WM_CTLCOLOREDIT"; break;
                case WM_CTLCOLORLISTBOX: text = "WM_CTLCOLORLISTBOX"; break;
                case WM_CTLCOLORBTN: text = "WM_CTLCOLORBTN"; break;
                case WM_CTLCOLORDLG: text = "WM_CTLCOLORDLG"; break;
                case WM_CTLCOLORSCROLLBAR: text = "WM_CTLCOLORSCROLLBAR"; break;
                case WM_CTLCOLORSTATIC: text = "WM_CTLCOLORSTATIC"; break;
                case WM_MOUSEMOVE: text = "WM_MOUSEMOVE"; break;
                case WM_LBUTTONDOWN: text = "WM_LBUTTONDOWN"; break;
                case WM_LBUTTONUP: text = "WM_LBUTTONUP"; break;
                case WM_LBUTTONDBLCLK: text = "WM_LBUTTONDBLCLK"; break;
                case WM_RBUTTONDOWN: text = "WM_RBUTTONDOWN"; break;
                case WM_RBUTTONUP: text = "WM_RBUTTONUP"; break;
                case WM_RBUTTONDBLCLK: text = "WM_RBUTTONDBLCLK"; break;
                case WM_MBUTTONDOWN: text = "WM_MBUTTONDOWN"; break;
                case WM_MBUTTONUP: text = "WM_MBUTTONUP"; break;
                case WM_MBUTTONDBLCLK: text = "WM_MBUTTONDBLCLK"; break;
                case WM_MOUSEWHEEL: text = "WM_MOUSEWHEEL"; break;
                case WM_PARENTNOTIFY: text = "WM_PARENTNOTIFY"; break;
                case WM_ENTERMENULOOP: text = "WM_ENTERMENULOOP"; break;
                case WM_EXITMENULOOP: text = "WM_EXITMENULOOP"; break;
                case WM_NEXTMENU: text = "WM_NEXTMENU"; break;
                case WM_SIZING: text = "WM_SIZING"; break;
                case WM_CAPTURECHANGED: text = "WM_CAPTURECHANGED"; break;
                case WM_MOVING: text = "WM_MOVING"; break;
                case WM_POWERBROADCAST: text = "WM_POWERBROADCAST"; break;
                case WM_DEVICECHANGE: text = "WM_DEVICECHANGE"; break;
                case WM_IME_SETCONTEXT: text = "WM_IME_SETCONTEXT"; break;
                case WM_IME_NOTIFY: text = "WM_IME_NOTIFY"; break;
                case WM_IME_CONTROL: text = "WM_IME_CONTROL"; break;
                case WM_IME_COMPOSITIONFULL: text = "WM_IME_COMPOSITIONFULL"; break;
                case WM_IME_SELECT: text = "WM_IME_SELECT"; break;
                case WM_IME_CHAR: text = "WM_IME_CHAR"; break;
                case WM_IME_KEYDOWN: text = "WM_IME_KEYDOWN"; break;
                case WM_IME_KEYUP: text = "WM_IME_KEYUP"; break;
                case WM_MDICREATE: text = "WM_MDICREATE"; break;
                case WM_MDIDESTROY: text = "WM_MDIDESTROY"; break;
                case WM_MDIACTIVATE: text = "WM_MDIACTIVATE"; break;
                case WM_MDIRESTORE: text = "WM_MDIRESTORE"; break;
                case WM_MDINEXT: text = "WM_MDINEXT"; break;
                case WM_MDIMAXIMIZE: text = "WM_MDIMAXIMIZE"; break;
                case WM_MDITILE: text = "WM_MDITILE"; break;
                case WM_MDICASCADE: text = "WM_MDICASCADE"; break;
                case WM_MDIICONARRANGE: text = "WM_MDIICONARRANGE"; break;
                case WM_MDIGETACTIVE: text = "WM_MDIGETACTIVE"; break;
                case WM_MDISETMENU: text = "WM_MDISETMENU"; break;
                case WM_ENTERSIZEMOVE: text = "WM_ENTERSIZEMOVE"; break;
                case WM_EXITSIZEMOVE: text = "WM_EXITSIZEMOVE"; break;
                case WM_DROPFILES: text = "WM_DROPFILES"; break;
                case WM_MDIREFRESHMENU: text = "WM_MDIREFRESHMENU"; break;
                case WM_MOUSEHOVER: text = "WM_MOUSEHOVER"; break;
                case WM_MOUSELEAVE: text = "WM_MOUSELEAVE"; break;
                case WM_CUT: text = "WM_CUT"; break;
                case WM_COPY: text = "WM_COPY"; break;
                case WM_PASTE: text = "WM_PASTE"; break;
                case WM_CLEAR: text = "WM_CLEAR"; break;
                case WM_UNDO: text = "WM_UNDO"; break;
                case WM_RENDERFORMAT: text = "WM_RENDERFORMAT"; break;
                case WM_RENDERALLFORMATS: text = "WM_RENDERALLFORMATS"; break;
                case WM_DESTROYCLIPBOARD: text = "WM_DESTROYCLIPBOARD"; break;
                case WM_DRAWCLIPBOARD: text = "WM_DRAWCLIPBOARD"; break;
                case WM_PAINTCLIPBOARD: text = "WM_PAINTCLIPBOARD"; break;
                case WM_VSCROLLCLIPBOARD: text = "WM_VSCROLLCLIPBOARD"; break;
                case WM_SIZECLIPBOARD: text = "WM_SIZECLIPBOARD"; break;
                case WM_ASKCBFORMATNAME: text = "WM_ASKCBFORMATNAME"; break;
                case WM_CHANGECBCHAIN: text = "WM_CHANGECBCHAIN"; break;
                case WM_HSCROLLCLIPBOARD: text = "WM_HSCROLLCLIPBOARD"; break;
                case WM_QUERYNEWPALETTE: text = "WM_QUERYNEWPALETTE"; break;
                case WM_PALETTEISCHANGING: text = "WM_PALETTEISCHANGING"; break;
                case WM_PALETTECHANGED: text = "WM_PALETTECHANGED"; break;
                case WM_HOTKEY: text = "WM_HOTKEY"; break;
                case WM_PRINT: text = "WM_PRINT"; break;
                case WM_PRINTCLIENT: text = "WM_PRINTCLIENT"; break;
                case WM_HANDHELDFIRST: text = "WM_HANDHELDFIRST"; break;
                case WM_GETTITLEBARINFOEX: text = "WM_GETTITLEBARINFOEX"; break;
                case WM_HANDHELDLAST: text = "WM_HANDHELDLAST"; break;
                case WM_AFXFIRST: text = "WM_AFXFIRST"; break;
                case WM_AFXLAST: text = "WM_AFXLAST"; break;
                case WM_PENWINFIRST: text = "WM_PENWINFIRST"; break;
                case WM_PENWINLAST: text = "WM_PENWINLAST"; break;
                case WM_APP: text = "WM_APP"; break;
                case WM_USER: text = "WM_USER"; break;
                case WM_NCMOUSELEAVE: text = "WM_NCMOUSELEAVE"; break;
                case WM_CTLCOLOR: text = "WM_CTLCOLOR"; break;
                case WM_DWMCOMPOSITIONCHANGED: text = "WM_DWMCOMPOSITIONCHANGED"; break;
                case WM_DWMNCRENDERINGCHANGED: text = "WM_DWMNCRENDERINGCHANGED"; break;
                case WM_DWMCOLORIZATIONCOLORCHANGED: text = "WM_DWMCOLORIZATIONCOLORCHANGED"; break;
                case WM_DWMWINDOWMAXIMIZEDCHANGE: text = "WM_DWMWINDOWMAXIMIZEDCHANGE"; break;
                case WM_DWMSENDICONICTHUMBNAIL: text = "WM_DWMSENDICONICTHUMBNAIL"; break;
                case WM_DWMSENDICONICLIVEPREVIEWBITMAP: text = "WM_DWMSENDICONICLIVEPREVIEWBITMAP"; break;

                // RichEdit messages
                //case WM_CONTEXTMENU: text = "WM_CONTEXTMENU"; break;

                //case WM_PRINTCLIENT: text = "WM_PRINTCLIENT"; break;

                case EM_GETLIMITTEXT: text = "EM_GETLIMITTEXT"; break;

                case EM_POSFROMCHAR: text = "EM_POSFROMCHAR"; break;
                case EM_CHARFROMPOS: text = "EM_CHARFROMPOS"; break;

                case EM_SCROLLCARET: text = "EM_SCROLLCARET"; break;
                case EM_CANPASTE: text = "EM_CANPASTE"; break;
                case EM_DISPLAYBAND: text = "EM_DISPLAYBAND"; break;
                case EM_EXGETSEL: text = "EM_EXGETSEL"; break;
                case EM_EXLIMITTEXT: text = "EM_EXLIMITTEXT"; break;
                case EM_EXLINEFROMCHAR: text = "EM_EXLINEFROMCHAR"; break;
                case EM_EXSETSEL: text = "EM_EXSETSEL"; break;
                case EM_FINDTEXT: text = "EM_FINDTEXT"; break;
                case EM_FORMATRANGE: text = "EM_FORMATRANGE"; break;
                case EM_GETCHARFORMAT: text = "EM_GETCHARFORMAT"; break;
                case EM_GETEVENTMASK: text = "EM_GETEVENTMASK"; break;
                case EM_GETOLEINTERFACE: text = "EM_GETOLEINTERFACE"; break;
                case EM_GETPARAFORMAT: text = "EM_GETPARAFORMAT"; break;
                case EM_GETSELTEXT: text = "EM_GETSELTEXT"; break;
                case EM_HIDESELECTION: text = "EM_HIDESELECTION"; break;
                case EM_PASTESPECIAL: text = "EM_PASTESPECIAL"; break;
                case EM_REQUESTRESIZE: text = "EM_REQUESTRESIZE"; break;
                case EM_SELECTIONTYPE: text = "EM_SELECTIONTYPE"; break;
                case EM_SETBKGNDCOLOR: text = "EM_SETBKGNDCOLOR"; break;
                case EM_SETCHARFORMAT: text = "EM_SETCHARFORMAT"; break;
                case EM_SETEVENTMASK: text = "EM_SETEVENTMASK"; break;
                case EM_SETOLECALLBACK: text = "EM_SETOLECALLBACK"; break;
                case EM_SETPARAFORMAT: text = "EM_SETPARAFORMAT"; break;
                case EM_SETTARGETDEVICE: text = "EM_SETTARGETDEVICE"; break;
                case EM_STREAMIN: text = "EM_STREAMIN"; break;
                case EM_STREAMOUT: text = "EM_STREAMOUT"; break;
                case EM_GETTEXTRANGE: text = "EM_GETTEXTRANGE"; break;
                case EM_FINDWORDBREAK: text = "EM_FINDWORDBREAK"; break;
                case EM_SETOPTIONS: text = "EM_SETOPTIONS"; break;
                case EM_GETOPTIONS: text = "EM_GETOPTIONS"; break;
                case EM_FINDTEXTEX: text = "EM_FINDTEXTEX"; break;
                case EM_GETWORDBREAKPROCEX: text = "EM_GETWORDBREAKPROCEX"; break;
                case EM_SETWORDBREAKPROCEX: text = "EM_SETWORDBREAKPROCEX"; break;

                // Richedit v2.0 messages
                case EM_SETUNDOLIMIT: text = "EM_SETUNDOLIMIT"; break;
                case EM_REDO: text = "EM_REDO"; break;
                case EM_CANREDO: text = "EM_CANREDO"; break;
                case EM_GETUNDONAME: text = "EM_GETUNDONAME"; break;
                case EM_GETREDONAME: text = "EM_GETREDONAME"; break;
                case EM_STOPGROUPTYPING: text = "EM_STOPGROUPTYPING"; break;

                case EM_SETTEXTMODE: text = "EM_SETTEXTMODE"; break;
                case EM_GETTEXTMODE: text = "EM_GETTEXTMODE"; break;

                case EM_AUTOURLDETECT: text = "EM_AUTOURLDETECT"; break;
                case EM_GETAUTOURLDETECT: text = "EM_GETAUTOURLDETECT"; break;
                case EM_SETPALETTE: text = "EM_SETPALETTE"; break;
                case EM_GETTEXTEX: text = "EM_GETTEXTEX"; break;
                case EM_GETTEXTLENGTHEX: text = "EM_GETTEXTLENGTHEX"; break;

                // Asia specific messages
                case EM_SETPUNCTUATION: text = "EM_SETPUNCTUATION"; break;
                case EM_GETPUNCTUATION: text = "EM_GETPUNCTUATION"; break;
                case EM_SETWORDWRAPMODE: text = "EM_SETWORDWRAPMODE"; break;
                case EM_GETWORDWRAPMODE: text = "EM_GETWORDWRAPMODE"; break;
                case EM_SETIMECOLOR: text = "EM_SETIMECOLOR"; break;
                case EM_GETIMECOLOR: text = "EM_GETIMECOLOR"; break;
                case EM_SETIMEOPTIONS: text = "EM_SETIMEOPTIONS"; break;
                case EM_GETIMEOPTIONS: text = "EM_GETIMEOPTIONS"; break;
                case EM_CONVPOSITION: text = "EM_CONVPOSITION"; break;

                case EM_SETLANGOPTIONS: text = "EM_SETLANGOPTIONS"; break;
                case EM_GETLANGOPTIONS: text = "EM_GETLANGOPTIONS"; break;
                case EM_GETIMECOMPMODE: text = "EM_GETIMECOMPMODE"; break;

                case EM_FINDTEXTW: text = "EM_FINDTEXTW"; break;
                case EM_FINDTEXTEXW: text = "EM_FINDTEXTEXW"; break;

                //Rich Edit 3.0 Asia msgs
                case EM_RECONVERSION: text = "EM_RECONVERSION"; break;
                case EM_SETIMEMODEBIAS: text = "EM_SETIMEMODEBIAS"; break;
                case EM_GETIMEMODEBIAS: text = "EM_GETIMEMODEBIAS"; break;

                // BiDi Specific messages
                case EM_SETBIDIOPTIONS: text = "EM_SETBIDIOPTIONS"; break;
                case EM_GETBIDIOPTIONS: text = "EM_GETBIDIOPTIONS"; break;

                case EM_SETTYPOGRAPHYOPTIONS: text = "EM_SETTYPOGRAPHYOPTIONS"; break;
                case EM_GETTYPOGRAPHYOPTIONS: text = "EM_GETTYPOGRAPHYOPTIONS"; break;

                // Extended Edit style specific messages
                case EM_SETEDITSTYLE: text = "EM_SETEDITSTYLE"; break;
                case EM_GETEDITSTYLE: text = "EM_GETEDITSTYLE"; break;

                default: text = null; break;
            }

            if (text == null && (msg & WM_REFLECT) == WM_REFLECT)
            {
                string subtext = MsgToString(msg - WM_REFLECT);
                subtext = subtext ?? "???";
                text = "WM_REFLECT + " + subtext;
            }
            return text;
        }

        public const int WH_JOURNALPLAYBACK = 1,
            WH_GETMESSAGE = 3,
            WH_MOUSE = 7,
            WSF_VISIBLE = 0x0001,
            WM_NULL = 0x0000,
            WM_CREATE = 0x0001,
            WM_DELETEITEM = 0x002D,
            WM_DESTROY = 0x0002,
            WM_MOVE = 0x0003,
            WM_SIZE = 0x0005,
            WM_ACTIVATE = 0x0006,
            WA_INACTIVE = 0,
            WA_ACTIVE = 1,
            WA_CLICKACTIVE = 2,
            WM_SETFOCUS = 0x0007,
            WM_KILLFOCUS = 0x0008,
            WM_ENABLE = 0x000A,
            WM_SETREDRAW = 0x000B,
            WM_SETTEXT = 0x000C,
            WM_GETTEXT = 0x000D,
            WM_GETTEXTLENGTH = 0x000E,
            WM_PAINT = 0x000F,
            WM_CLOSE = 0x0010,
            WM_QUERYENDSESSION = 0x0011,
            WM_QUIT = 0x0012,
            WM_QUERYOPEN = 0x0013,
            WM_ERASEBKGND = 0x0014,
            WM_SYSCOLORCHANGE = 0x0015,
            WM_ENDSESSION = 0x0016,
            WM_SHOWWINDOW = 0x0018,
            WM_WININICHANGE = 0x001A,
            WM_DEVMODECHANGE = 0x001B,
            WM_ACTIVATEAPP = 0x001C,
            WM_FONTCHANGE = 0x001D,
            WM_TIMECHANGE = 0x001E,
            WM_CANCELMODE = 0x001F,
            WM_SETCURSOR = 0x0020,
            WM_MOUSEACTIVATE = 0x0021,
            WM_CHILDACTIVATE = 0x0022,
            WM_QUEUESYNC = 0x0023,
            WM_GETMINMAXINFO = 0x0024,
            WM_PAINTICON = 0x0026,
            WM_ICONERASEBKGND = 0x0027,
            WM_NEXTDLGCTL = 0x0028,
            WM_SPOOLERSTATUS = 0x002A,
            WM_DRAWITEM = 0x002B,
            WM_MEASUREITEM = 0x002C,
            WM_VKEYTOITEM = 0x002E,
            WM_CHARTOITEM = 0x002F,
            WM_SETFONT = 0x0030,
            WM_GETFONT = 0x0031,
            WM_SETHOTKEY = 0x0032,
            WM_GETHOTKEY = 0x0033,
            WM_QUERYDRAGICON = 0x0037,
            WM_COMPAREITEM = 0x0039,
            WM_GETOBJECT = 0x003D,
            WM_COMPACTING = 0x0041,
            WM_COMMNOTIFY = 0x0044,
            WM_WINDOWPOSCHANGING = 0x0046,
            WM_WINDOWPOSCHANGED = 0x0047,
            WM_POWER = 0x0048,
            WM_COPYDATA = 0x004A,
            WM_CANCELJOURNAL = 0x004B,
            WM_NOTIFY = 0x004E,
            WM_INPUTLANGCHANGEREQUEST = 0x0050,
            WM_INPUTLANGCHANGE = 0x0051,
            WM_TCARD = 0x0052,
            WM_HELP = 0x0053,
            WM_USERCHANGED = 0x0054,
            WM_NOTIFYFORMAT = 0x0055,
            WM_CONTEXTMENU = 0x007B,
            WM_STYLECHANGING = 0x007C,
            WM_STYLECHANGED = 0x007D,
            WM_DISPLAYCHANGE = 0x007E,
            WM_GETICON = 0x007F,
            WM_SETICON = 0x0080,
            WM_NCCREATE = 0x0081,
            WM_NCDESTROY = 0x0082,
            WM_NCCALCSIZE = 0x0083,
            WM_NCHITTEST = 0x0084,
            WM_NCPAINT = 0x0085,
            WM_NCACTIVATE = 0x0086,
            WM_GETDLGCODE = 0x0087,
            WM_NCMOUSEMOVE = 0x00A0,
            WM_NCMOUSELEAVE = 0x02A2,
            WM_NCLBUTTONDOWN = 0x00A1,
            WM_NCLBUTTONUP = 0x00A2,
            WM_NCLBUTTONDBLCLK = 0x00A3,
            WM_NCRBUTTONDOWN = 0x00A4,
            WM_NCRBUTTONUP = 0x00A5,
            WM_NCRBUTTONDBLCLK = 0x00A6,
            WM_NCMBUTTONDOWN = 0x00A7,
            WM_NCMBUTTONUP = 0x00A8,
            WM_NCMBUTTONDBLCLK = 0x00A9,
            WM_NCXBUTTONDOWN = 0x00AB,
            WM_NCXBUTTONUP = 0x00AC,
            WM_NCXBUTTONDBLCLK = 0x00AD,
            WM_KEYFIRST = 0x0100,
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_CHAR = 0x0102,
            WM_DEADCHAR = 0x0103,
            WM_CTLCOLOR = 0x0019,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSKEYUP = 0x0105,
            WM_SYSCHAR = 0x0106,
            WM_SYSDEADCHAR = 0x0107,
            WM_KEYLAST = 0x0108,
            WM_IME_STARTCOMPOSITION = 0x010D,
            WM_IME_ENDCOMPOSITION = 0x010E,
            WM_IME_COMPOSITION = 0x010F,
            WM_IME_KEYLAST = 0x010F,
            WM_INITDIALOG = 0x0110,
            WM_COMMAND = 0x0111,
            WM_SYSCOMMAND = 0x0112,
            WM_TIMER = 0x0113,
            WM_HSCROLL = 0x0114,
            WM_VSCROLL = 0x0115,
            WM_INITMENU = 0x0116,
            WM_INITMENUPOPUP = 0x0117,
            WM_MENUSELECT = 0x011F,
            WM_MENUCHAR = 0x0120,
            WM_ENTERIDLE = 0x0121,
            WM_UNINITMENUPOPUP = 0x0125,
            WM_CHANGEUISTATE = 0x0127,
            WM_UPDATEUISTATE = 0x0128,
            WM_QUERYUISTATE = 0x0129,
            WM_CTLCOLORMSGBOX = 0x0132,
            WM_CTLCOLOREDIT = 0x0133,
            WM_CTLCOLORLISTBOX = 0x0134,
            WM_CTLCOLORBTN = 0x0135,
            WM_CTLCOLORDLG = 0x0136,
            WM_CTLCOLORSCROLLBAR = 0x0137,
            WM_CTLCOLORSTATIC = 0x0138,
            WM_MOUSEFIRST = 0x0200,
            WM_MOUSEMOVE = 0x0200,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_LBUTTONDBLCLK = 0x0203,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_RBUTTONDBLCLK = 0x0206,
            WM_MBUTTONDOWN = 0x0207,
            WM_MBUTTONUP = 0x0208,
            WM_MBUTTONDBLCLK = 0x0209,
            WM_XBUTTONDOWN = 0x020B,
            WM_XBUTTONUP = 0x020C,
            WM_XBUTTONDBLCLK = 0x020D,
            WM_MOUSEWHEEL = 0x020A,
            WM_MOUSELAST = 0x020A;

        public const int WHEEL_DELTA = 120,
            WM_PARENTNOTIFY = 0x0210,
            WM_ENTERMENULOOP = 0x0211,
            WM_EXITMENULOOP = 0x0212,
            WM_NEXTMENU = 0x0213,
            WM_SIZING = 0x0214,
            WM_CAPTURECHANGED = 0x0215,
            WM_MOVING = 0x0216,
            WM_POWERBROADCAST = 0x0218,
            WM_DEVICECHANGE = 0x0219,
            WM_IME_SETCONTEXT = 0x0281,
            WM_IME_NOTIFY = 0x0282,
            WM_IME_CONTROL = 0x0283,
            WM_IME_COMPOSITIONFULL = 0x0284,
            WM_IME_SELECT = 0x0285,
            WM_IME_CHAR = 0x0286,
            WM_IME_KEYDOWN = 0x0290,
            WM_IME_KEYUP = 0x0291,
            WM_MDICREATE = 0x0220,
            WM_MDIDESTROY = 0x0221,
            WM_MDIACTIVATE = 0x0222,
            WM_MDIRESTORE = 0x0223,
            WM_MDINEXT = 0x0224,
            WM_MDIMAXIMIZE = 0x0225,
            WM_MDITILE = 0x0226,
            WM_MDICASCADE = 0x0227,
            WM_MDIICONARRANGE = 0x0228,
            WM_MDIGETACTIVE = 0x0229,
            WM_MDISETMENU = 0x0230,
            WM_ENTERSIZEMOVE = 0x0231,
            WM_EXITSIZEMOVE = 0x0232,
            WM_DROPFILES = 0x0233,
            WM_MDIREFRESHMENU = 0x0234,
            WM_POINTERDOWN = 0x246,
            WM_MOUSEHOVER = 0x02A1,
            WM_MOUSELEAVE = 0x02A3,
            WM_DPICHANGED = 0x02E0,
            WM_GETDPISCALEDSIZE = 0x02e1,
            WM_DPICHANGED_BEFOREPARENT = 0x02E2,
            WM_DPICHANGED_AFTERPARENT = 0x02E3,
            WM_CUT = 0x0300,
            WM_COPY = 0x0301,
            WM_PASTE = 0x0302,
            WM_CLEAR = 0x0303,
            WM_UNDO = 0x0304,
            WM_RENDERFORMAT = 0x0305,
            WM_RENDERALLFORMATS = 0x0306,
            WM_DESTROYCLIPBOARD = 0x0307,
            WM_DRAWCLIPBOARD = 0x0308,
            WM_PAINTCLIPBOARD = 0x0309,
            WM_VSCROLLCLIPBOARD = 0x030A,
            WM_SIZECLIPBOARD = 0x030B,
            WM_ASKCBFORMATNAME = 0x030C,
            WM_CHANGECBCHAIN = 0x030D,
            WM_HSCROLLCLIPBOARD = 0x030E,
            WM_QUERYNEWPALETTE = 0x030F,
            WM_PALETTEISCHANGING = 0x0310,
            WM_PALETTECHANGED = 0x0311,
            WM_HOTKEY = 0x0312,
            WM_PRINT = 0x0317,
            WM_PRINTCLIENT = 0x0318,
            WM_THEMECHANGED = 0x031A,
            WM_HANDHELDFIRST = 0x0358,
            WM_GETTITLEBARINFOEX = 0x033F,
            WM_HANDHELDLAST = 0x035F,
            WM_AFXFIRST = 0x0360,
            WM_AFXLAST = 0x037F,
            WM_PENWINFIRST = 0x0380,
            WM_PENWINLAST = 0x038F,
            WM_APP = 0x8000,
            WM_USER = 0x0400,
            WM_REFLECT = WM_USER + 0x1C00,
            WS_OVERLAPPED = 0x00000000,
            WS_POPUP = unchecked((int)0x80000000),
            WS_CHILD = 0x40000000,
            WS_MINIMIZE = 0x20000000,
            WS_VISIBLE = 0x10000000,
            WS_DISABLED = 0x08000000,
            WS_CLIPSIBLINGS = 0x04000000,
            WS_CLIPCHILDREN = 0x02000000,
            WS_MAXIMIZE = 0x01000000,
            WS_CAPTION = 0x00C00000,
            WS_BORDER = 0x00800000,
            WS_DLGFRAME = 0x00400000,
            WS_VSCROLL = 0x00200000,
            WS_HSCROLL = 0x00100000,
            WS_SYSMENU = 0x00080000,
            WS_THICKFRAME = 0x00040000,
            WS_TABSTOP = 0x00010000,
            WS_MINIMIZEBOX = 0x00020000,
            WS_MAXIMIZEBOX = 0x00010000,
            WS_EX_DLGMODALFRAME = 0x00000001,
            WS_EX_MDICHILD = 0x00000040,
            WS_EX_TOOLWINDOW = 0x00000080,
            WS_EX_CLIENTEDGE = 0x00000200,
            WS_EX_CONTEXTHELP = 0x00000400,
            WS_EX_RIGHT = 0x00001000,
            WS_EX_LEFT = 0x00000000,
            WS_EX_RTLREADING = 0x00002000,
            WS_EX_LEFTSCROLLBAR = 0x00004000,
            WS_EX_CONTROLPARENT = 0x00010000,
            WS_EX_STATICEDGE = 0x00020000,
            WS_EX_APPWINDOW = 0x00040000,
            WS_EX_LAYERED = 0x00080000,
            WS_EX_TOPMOST = 0x00000008,
            WS_EX_LAYOUTRTL = 0x00400000,
            WS_EX_NOINHERITLAYOUT = 0x00100000,
            WM_DWMCOMPOSITIONCHANGED = 0x0000031E,
            WM_DWMNCRENDERINGCHANGED = 0x0000031F,
            WM_DWMCOLORIZATIONCOLORCHANGED = 0x00000320,
            WM_DWMWINDOWMAXIMIZEDCHANGE = 0x00000321,
            WM_DWMSENDICONICTHUMBNAIL = 0x00000323,
            WM_DWMSENDICONICLIVEPREVIEWBITMAP = 0x00000326,
            WM_CHOOSEFONT_GETLOGFONT = 0x0400 + 1;

        public const int EM_GETLIMITTEXT = WM_USER + 37;
        public const int EM_POSFROMCHAR = WM_USER + 38;
        public const int EM_CHARFROMPOS = WM_USER + 39;
        public const int EM_SCROLLCARET = WM_USER + 49;
        public const int EM_CANPASTE = WM_USER + 50;
        public const int EM_DISPLAYBAND = WM_USER + 51;
        public const int EM_EXGETSEL = WM_USER + 52;
        public const int EM_EXLIMITTEXT = WM_USER + 53;
        public const int EM_EXLINEFROMCHAR = WM_USER + 54;
        public const int EM_EXSETSEL = WM_USER + 55;
        public const int EM_FINDTEXT = WM_USER + 56;
        public const int EM_FORMATRANGE = WM_USER + 57;
        public const int EM_GETCHARFORMAT = WM_USER + 58;
        public const int EM_GETEVENTMASK = WM_USER + 59;
        public const int EM_GETOLEINTERFACE = WM_USER + 60;
        public const int EM_GETPARAFORMAT = WM_USER + 61;
        public const int EM_GETSELTEXT = WM_USER + 62;
        public const int EM_HIDESELECTION = WM_USER + 63;
        public const int EM_PASTESPECIAL = WM_USER + 64;
        public const int EM_REQUESTRESIZE = WM_USER + 65;
        public const int EM_SELECTIONTYPE = WM_USER + 66;
        public const int EM_SETBKGNDCOLOR = WM_USER + 67;
        public const int EM_SETCHARFORMAT = WM_USER + 68;
        public const int EM_SETEVENTMASK = WM_USER + 69;
        public const int EM_SETOLECALLBACK = WM_USER + 70;
        public const int EM_SETPARAFORMAT = WM_USER + 71;
        public const int EM_SETTARGETDEVICE = WM_USER + 72;
        public const int EM_STREAMIN = WM_USER + 73;
        public const int EM_STREAMOUT = WM_USER + 74;
        public const int EM_GETTEXTRANGE = WM_USER + 75;
        public const int EM_FINDWORDBREAK = WM_USER + 76;
        public const int EM_SETOPTIONS = WM_USER + 77;
        public const int EM_GETOPTIONS = WM_USER + 78;
        public const int EM_FINDTEXTEX = WM_USER + 79;
        public const int EM_GETWORDBREAKPROCEX = WM_USER + 80;
        public const int EM_SETWORDBREAKPROCEX = WM_USER + 81;
        public const int EM_SETUNDOLIMIT = WM_USER + 82;
        public const int EM_REDO = WM_USER + 84;
        public const int EM_CANREDO = WM_USER + 85;
        public const int EM_GETUNDONAME = WM_USER + 86;
        public const int EM_GETREDONAME = WM_USER + 87;
        public const int EM_STOPGROUPTYPING = WM_USER + 88;
        public const int EM_SETTEXTMODE = WM_USER + 89;
        public const int EM_GETTEXTMODE = WM_USER + 90;
        public const int EM_AUTOURLDETECT = WM_USER + 91;
        public const int EM_GETAUTOURLDETECT = WM_USER + 92;
        public const int EM_SETPALETTE = WM_USER + 93;
        public const int EM_GETTEXTEX = WM_USER + 94;
        public const int EM_GETTEXTLENGTHEX = WM_USER + 95;
        public const int EM_SETPUNCTUATION = WM_USER + 100;
        public const int EM_GETPUNCTUATION = WM_USER + 101;
        public const int EM_SETWORDWRAPMODE = WM_USER + 102;
        public const int EM_GETWORDWRAPMODE = WM_USER + 103;
        public const int EM_SETIMECOLOR = WM_USER + 104;
        public const int EM_GETIMECOLOR = WM_USER + 105;
        public const int EM_SETIMEOPTIONS = WM_USER + 106;
        public const int EM_GETIMEOPTIONS = WM_USER + 107;
        public const int EM_CONVPOSITION = WM_USER + 108;
        public const int EM_SETLANGOPTIONS = WM_USER + 120;
        public const int EM_GETLANGOPTIONS = WM_USER + 121;
        public const int EM_GETIMECOMPMODE = WM_USER + 122;
        public const int EM_FINDTEXTW = WM_USER + 123;
        public const int EM_FINDTEXTEXW = WM_USER + 124;
        public const int EM_RECONVERSION = WM_USER + 125;
        public const int EM_SETIMEMODEBIAS = WM_USER + 126;
        public const int EM_GETIMEMODEBIAS = WM_USER + 127;
        public const int EM_SETBIDIOPTIONS = WM_USER + 200;
        public const int EM_GETBIDIOPTIONS = WM_USER + 201;
        public const int EM_SETTYPOGRAPHYOPTIONS = WM_USER + 202;
        public const int EM_GETTYPOGRAPHYOPTIONS = WM_USER + 203;
        public const int EM_SETEDITSTYLE = WM_USER + 204;
        public const int EM_GETEDITSTYLE = WM_USER + 205;
        public const int EM_SETQUERYRTFOBJ = WM_USER + 270;
    }
}
