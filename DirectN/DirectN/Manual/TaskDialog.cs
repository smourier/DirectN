using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public class TaskDialog
    {
        public static readonly IntPtr TD_WARNING_ICON = new IntPtr(unchecked((ushort)-1));
        public static readonly IntPtr TD_ERROR_ICON = new IntPtr(unchecked((ushort)-2));
        public static readonly IntPtr TD_INFORMATION_ICON = new IntPtr(unchecked((ushort)-3));
        public static readonly IntPtr TD_SHIELD_ICON = new IntPtr(unchecked((ushort)-4));

        public virtual TASKDIALOG_FLAGS Flags { get; set; }
        public virtual TASKDIALOG_COMMON_BUTTON_FLAGS CommonButtonFlags { get; set; }
        public virtual string Title { get; set; }
        public virtual string MainInstruction { get; set; }
        public virtual string Content { get; set; }
        public virtual string VerificationText { get; set; }
        public virtual string ExpandedInformation { get; set; }
        public virtual string CollapsedControlText { get; set; }
        public virtual string Footer { get; set; }
        public virtual IntPtr MainIcon { get; set; }
        public virtual IntPtr FooterIcon { get; set; }
        public virtual int Width { get; set; }

        public virtual DialogResult Show(IntPtr hwnd)
        {
            var config = new TASKDIALOGCONFIG();
            config.cbSize = Marshal.SizeOf(config);
            config.hwndParent = hwnd;
            config.dwFlags = Flags;
            config.dwCommonButtons = CommonButtonFlags;
            config.pszWindowTitle = Title;
            config.pszMainInstruction = MainInstruction;
            config.pszContent = Content;
            config.pszVerificationText = VerificationText;
            config.pszExpandedControlText = ExpandedInformation;
            config.pszCollapsedControlText = CollapsedControlText;
            config.pszFooter = Footer;
            if (MainIcon != IntPtr.Zero)
            {
                config.hMainIcon = MainIcon;
                //config.dwFlags |= TASKDIALOG_FLAGS.TDF_USE_HICON_MAIN;
            }

            if (FooterIcon != IntPtr.Zero)
            {
                config.hFooterIcon = FooterIcon;
                //config.dwFlags |= TASKDIALOG_FLAGS.TDF_USE_HICON_FOOTER;
            }

            config.cxWidth = Width;
            try
            {
                TaskDialogIndirect(ref config, out int button, out int radioButton, out bool verificationFlagChecked).ThrowOnError();
                ResultButton = button;
                ResultRadioButton = radioButton;
                ResultVerificationFlagChecked = verificationFlagChecked;
                return (DialogResult)button;
            }
            catch (EntryPointNotFoundException ex)
            {
                MessageBox.Show(hwnd, ex.GetInterestingExceptionMessage() + Environment.NewLine + Environment.NewLine + "Make sure the application's main executable has a manifest that enables visual styles.", "Task Dialog Fatal Error", icon: MessageBoxIcon.Stop);
                return DialogResult.Abort;
            }
            catch(Exception e)
            {
                MessageBox.Show(hwnd, e.GetInterestingExceptionMessage(), "Task Dialog Fatal Error", icon: MessageBoxIcon.Stop);
                return DialogResult.Abort;
            }
        }

        public int ResultButton { get; private set; }
        public int ResultRadioButton { get; private set; }
        public bool ResultVerificationFlagChecked { get; private set; }

        [DllImport("comctl32", SetLastError = true)]
        private static extern HRESULT TaskDialogIndirect(ref TASKDIALOGCONFIG pTaskConfig, out int pnButton, out int pnRadioButton, out bool pfVerificationFlagChecked);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        private struct TASKDIALOGCONFIG
        {
            public int cbSize;
            public IntPtr hwndParent;
            public IntPtr hInstance;
            public TASKDIALOG_FLAGS dwFlags;
            public TASKDIALOG_COMMON_BUTTON_FLAGS dwCommonButtons;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszWindowTitle;
            public IntPtr hMainIcon;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszMainInstruction;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszContent;
            public int cButtons;
            public IntPtr pButtons;
            public int nDefaultButton;
            public int cRadioButtons;
            public IntPtr pRadioButtons;
            public int nDefaultRadioButton;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszVerificationText;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszExpandedInformation;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszExpandedControlText;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszCollapsedControlText;
            public IntPtr hFooterIcon;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszFooter;
            public IntPtr pfCallback;
            public IntPtr lpCallbackData;
            public int cxWidth;
        }
    }
}
