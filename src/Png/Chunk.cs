namespace Rpc.Png
{
  using global::System.Runtime.InteropServices;

  [StructLayout(LayoutKind.Sequential)]
  public struct Chunk
  {
    public long Length;
    public string Type;
    public byte[] Data;
    public long Crc;
  }
}
