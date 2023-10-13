using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace DirectN
{
    [TypeConverter(typeof(CursorConverter))]
    public class Cursor : IEquatable<Cursor>
    {
        public Cursor(int id)
        {
            Handle = LoadCursor(IntPtr.Zero, id);
            Id = id;
        }

        public int Id { get; }
        public IntPtr Handle { get; }

        public static readonly Cursor AppStarting = new Cursor(32650);
        public static readonly Cursor Arrow = new Cursor(32512);
        public static readonly Cursor Cross = new Cursor(32515);
        public static readonly Cursor Hand = new Cursor(32649);
        public static readonly Cursor Help = new Cursor(32651);
        public static readonly Cursor IBeam = new Cursor(32513);
        public static readonly Cursor No = new Cursor(32648);
        public static readonly Cursor Size = new Cursor(32640);
        public static readonly Cursor SizeAll = new Cursor(32646);
        public static readonly Cursor SizeNESW = new Cursor(32643);
        public static readonly Cursor SizeNS = new Cursor(32645);
        public static readonly Cursor SizeNWSE = new Cursor(32642);
        public static readonly Cursor SizeWE = new Cursor(32644);
        public static readonly Cursor UpArrow = new Cursor(32516);
        public static readonly Cursor Wait = new Cursor(32514);

        private static void Set(IntPtr handle) => SetCursor(handle);
        public static void Set(Cursor cursor)
        {
            if (cursor == null || cursor.Handle == IntPtr.Zero)
            {
                SetCursor(Arrow.Handle);
            }
            else
            {
                Set(cursor.Handle);
            }
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr GetCursor();

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr SetCursor(IntPtr hcursor);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr LoadCursor(IntPtr hInst, int iconId);

        public override int GetHashCode() => Handle.GetHashCode();
        public override string ToString() => Id + " " + Handle;
        public override bool Equals(object obj) => Equals(obj as Cursor);
        public bool Equals(Cursor other) => other != null && (Id == other.Id || Handle == other.Handle);
    }

    public class CursorConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t) => t == typeof(string);
        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value)
        {
            if (value is string s && s != null && int.TryParse(s, out var i))
                return new Cursor(i);

            return null;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                if (value is Cursor cursor)
                    return cursor.Id.ToString();

                return null;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
