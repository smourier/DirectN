using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID3D10BlobExtensions
    {
        public static IntPtr GetBufferPointer(this IComObject<ID3D10Blob> blob) => GetBufferPointer(blob?.Object);
        public static IntPtr GetBufferPointer(this ID3D10Blob blob)
        {
            if (blob == null)
                throw new ArgumentNullException(nameof(blob));

            return blob.GetBufferPointer();
        }

        public static int GetBufferSize32(this IComObject<ID3D10Blob> blob) => GetBufferSize32(blob?.Object);
        public static int GetBufferSize32(this ID3D10Blob blob)
        {
            if (blob == null)
                throw new ArgumentNullException(nameof(blob));

            return blob.GetBufferSize().ToInt32();
        }

        public static long GetBufferSize64(this IComObject<ID3D10Blob> blob) => GetBufferSize64(blob?.Object);
        public static long GetBufferSize64(this ID3D10Blob blob)
        {
            if (blob == null)
                throw new ArgumentNullException(nameof(blob));

            return blob.GetBufferSize().ToInt64();
        }

        public static IntPtr GetBufferSize(this IComObject<ID3D10Blob> blob) => GetBufferSize(blob?.Object);
        public static IntPtr GetBufferSize(this ID3D10Blob blob)
        {
            if (blob == null)
                throw new ArgumentNullException(nameof(blob));

            return blob.GetBufferSize();
        }

        public static string GetAnsiStringFromBlob(this IComObject<ID3D10Blob> blob) => GetAnsiStringFromBlob(blob?.Object);
        public static string GetAnsiStringFromBlob(this ID3D10Blob blob)
        {
            string str = null;
            if (blob != null)
            {
                var ptr = blob.GetBufferPointer();
                var len = blob.GetBufferSize().ToInt32();
                if (ptr != IntPtr.Zero && len > 0)
                {
                    str = Marshal.PtrToStringAnsi(ptr, len).Nullify();
                }
                Marshal.ReleaseComObject(blob);
            }
            return str;
        }

        public static D3D12_SHADER_BYTECODE ToD3D12_SHADER_BYTECODE(this IComObject<ID3D10Blob> blob) => ToD3D12_SHADER_BYTECODE(blob?.Object);
        public static D3D12_SHADER_BYTECODE ToD3D12_SHADER_BYTECODE(this ID3D10Blob blob)
        {
            var bc = new D3D12_SHADER_BYTECODE();
            if (blob != null)
            {
                bc.pShaderBytecode = blob.GetBufferPointer();
                bc.BytecodeLength = blob.GetBufferSize();
            }
            return bc;
        }
    }
}
