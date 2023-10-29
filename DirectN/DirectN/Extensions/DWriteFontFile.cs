using System;

namespace DirectN
{
    public abstract class DWriteFontFile
    {
        public virtual long? Length { get; protected set; }
        public virtual DateTime? LastWriteTime { get; protected set; }

        public abstract byte[] ReadFileFragment(long offset, int length, out int read);
    }
}
