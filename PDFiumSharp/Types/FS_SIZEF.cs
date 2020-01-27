using System.Runtime.InteropServices;

namespace PDFiumSharp.Types
{
    /// <summary>
    /// Rectangle size. Coordinate system agnostic.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FS_SIZEF
    {
        public float Width { get; }
        public float Height { get; }

        public FS_SIZEF(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
