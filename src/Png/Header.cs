namespace Rpc.Png
{
  using global::System.Runtime.InteropServices;

  [StructLayout(LayoutKind.Sequential)]
  public struct Header
  {
    public long Width;
    public long Height;
    public byte BitDepth;
    public byte ColorType;
    public byte Compression;
    public byte Filter;
    public byte Interlacing;
  }
}
