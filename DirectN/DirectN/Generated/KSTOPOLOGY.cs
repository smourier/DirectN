// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(915,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSTOPOLOGY
    {
        public uint CategoriesCount;
        public IntPtr Categories;
        public uint TopologyNodesCount;
        public IntPtr TopologyNodes;
        public uint TopologyConnectionsCount;
        public IntPtr TopologyConnections;
        public IntPtr TopologyNodesNames;
        public uint Reserved;
    }
}
