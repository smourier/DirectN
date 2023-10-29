using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class MessageBox
    {
        public static DialogResult Show(string text, string caption = null, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, MessageBoxOptions options = MessageBoxOptions.ApplicationModal) => Show(IntPtr.Zero, text, caption, buttons, icon, defaultButton, options);
        public static DialogResult Show(IntPtr hwnd, string text, string caption = null, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, MessageBoxOptions options = MessageBoxOptions.ApplicationModal)
        {
            var type = (int)buttons | (int)icon | (int)defaultButton | (int)options;
            return (DialogResult)MessageBoxW(hwnd, text, caption, type);
        }

        [DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int MessageBoxW(IntPtr hwnd, string text, string caption, int type);
    }
}
