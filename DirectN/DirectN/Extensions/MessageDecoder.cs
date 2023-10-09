using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DirectN
{
    public static class MessageDecoder
    {
        private static readonly Lazy<ConcurrentDictionary<int, string[]>> _messagesNames = new Lazy<ConcurrentDictionary<int, string[]>>(GetMessageNames, true);

        public static int Machin;

        private static ConcurrentDictionary<int, string[]> GetMessageNames()
        {
            var dic = new Dictionary<int, List<string>>();
            foreach (var msg in typeof(MessageDecoder).GetFields(BindingFlags.Static | BindingFlags.Public).Where(m => m.IsLiteral && m.Attributes.HasFlag(FieldAttributes.HasDefault) && m.FieldType == typeof(int)))
            {
                var key = (int)msg.GetValue(null);
                if (!dic.TryGetValue(key, out var list))
                {
                    list = new List<string>();
                    dic.Add(key, list);
                }
                list.Add(msg.Name);
            }

            return new ConcurrentDictionary<int, string[]>(dic.Select(kv => new KeyValuePair<int, string[]>(kv.Key, kv.Value.ToArray())));
        }

        public static string Decode(this MSG msg) => Decode(msg.hwnd, msg.message, msg.wParam, msg.lParam);
        public static string Decode(IntPtr handle, int msg, IntPtr wParam, IntPtr lParam, IntPtr? lResult = null)
        {
            var id = Parenthesize(MsgToString(msg));
            var description = string.Empty;
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

        public static bool IsMouseButtonMessage(int msg) =>
                msg == WM_LBUTTONDOWN || msg == WM_LBUTTONUP || msg == WM_LBUTTONDBLCLK ||
                msg == WM_RBUTTONDOWN || msg == WM_RBUTTONUP || msg == WM_RBUTTONDBLCLK ||
                msg == WM_MBUTTONDOWN || msg == WM_MBUTTONUP || msg == WM_MBUTTONDBLCLK ||
                msg == WM_XBUTTONDOWN || msg == WM_XBUTTONUP || msg == WM_XBUTTONDBLCLK;

        private static int LOWORD(int n) => n & 0xffff;
        private static int LOWORD(IntPtr n) => LOWORD((int)(long)n);
        private static string Parenthesize(string input)
        {
            if (input == null)
                return string.Empty;

            return " (" + input + ")";
        }

        public static string MsgToString(int msg)
        {
            if (_messagesNames.Value.TryGetValue(msg, out var list))
                return string.Join("|", list); // there can be more than one text per message

            if ((msg & WM_REFLECT) == WM_REFLECT)
            {
                var subtext = MsgToString(msg - WM_REFLECT);
                subtext = subtext ?? "???";
                return "WM_REFLECT + " + subtext;
            }
            return null;
        }

        public const int
            WM_NULL = 0x0000,
            WM_CREATE = 0x0001,
            WM_DELETEITEM = 0x002D,
            WM_DESTROY = 0x0002,
            WM_MOVE = 0x0003,
            WM_SIZE = 0x0005,
            WM_ACTIVATE = 0x0006,
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
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_CHAR = 0x0102,
            WM_DEADCHAR = 0x0103,
            WM_CTLCOLOR = 0x0019,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSKEYUP = 0x0105,
            WM_SYSCHAR = 0x0106,
            WM_SYSDEADCHAR = 0x0107,
            WM_IME_STARTCOMPOSITION = 0x010D,
            WM_IME_ENDCOMPOSITION = 0x010E,
            WM_IME_COMPOSITION = 0x010F,
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
            WM_MOUSEHWHEEL = 0x020E;

        public const int
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
            WM_POINTERDEVICECHANGE = 0x238,
            WM_POINTERDEVICEINRANGE = 0x239,
            WM_POINTERDEVICEOUTOFRANGE = 0x23A,
            WM_NCPOINTERUPDATE = 0x0241,
            WM_NCPOINTERDOWN = 0x0242,
            WM_NCPOINTERUP = 0x0243,
            WM_POINTERUPDATE = 0x0245,
            WM_POINTERDOWN = 0x0246,
            WM_POINTERUP = 0x0247,
            WM_POINTERENTER = 0x0249,
            WM_POINTERLEAVE = 0x024A,
            WM_POINTERACTIVATE = 0x024B,
            WM_POINTERCAPTURECHANGED = 0x024C,
            WM_TOUCHHITTESTING = 0x024D,
            WM_POINTERWHEEL = 0x024E,
            WM_POINTERHWHEEL = 0x024F,
            DM_POINTERHITTEST = 0x0250,
            WM_POINTERROUTEDTO = 0x0251,
            WM_POINTERROUTEDAWAY = 0x0252,
            WM_POINTERROUTEDRELEASED = 0x0253,
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
