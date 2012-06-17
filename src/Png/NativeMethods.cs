namespace Rpc.Png
{
  using global::System;
  using global::System.Runtime.InteropServices;

#if X64

  using size_t = global::System.UInt64;

#else

  using size_t = global::System.UInt32;

#endif

  internal static class NativeMethods
  {
#if DEBUG

    private const string MSVCRT_Dll = "MSVCRTD.DLL";

#else

    private const string MSVCRT_Dll = "msvcrt.dll";

#endif

    private const string NTDll_Dll = "ntdll.dll";
    private const CallingConvention CDecl = CallingConvention.Cdecl;

    /// <summary>
    ///   Copies bytes between buffers. More secure versions of these functions
    ///   are available; see memcpy_s, wmemcpy_s.
    /// </summary>
    /// <param name="_Dst">
    ///   New buffer.
    /// </param>
    /// <param name="_Src">
    ///   Buffer to copy from.
    /// </param>
    /// <param name="_Size">
    ///   Number of characters to copy.
    /// </param>
    /// <returns>
    ///   The value of _Dst.
    /// </returns>
    /// <remarks>
    ///   <para>
    ///     memcpy copies _Size bytes from _Src to _Dst; wmemcpy copies count
    ///     wide characters (two bytes). If the source and destination overlap,
    ///     the behavior of memcpy is undefined. Use memmove to handle
    ///     overlapping regions.
    ///   </para>
    ///   <para>
    ///     Security Note   Make sure that the destination buffer is the same
    ///     size or larger than the source buffer. For more information, see
    ///     Avoiding Buffer Overruns.
    ///   </para>
    /// </remarks>
    [DllImport(MSVCRT_Dll, CallingConvention = CDecl, SetLastError = false)]
    public static extern IntPtr memcpy(IntPtr _Dst, IntPtr _Src, size_t _Size);

    /// <summary>
    ///   The RtlCopyMemory routine copies the contents of one buffer to
    ///   another.
    /// </summary>
    /// <param name="Destination">
    ///   Pointer to the destination of the move.
    /// </param>
    /// <param name="Source">
    ///   Pointer to the memory to be copied.
    /// </param>
    /// <param name="Length">
    ///   Specifies the number of bytes to be copied.
    /// </param>
    /// <remarks>
    ///   <para>
    ///     RtlCopyMemory runs faster than RtlMoveMemory. However, the ( Source
    ///     + Length) cannot overlap the Destination range passed in to
    ///     RtlCopyMemory.
    ///   </para>
    ///   <para>
    ///     Callers of RtlCopyMemory can be running at any IRQL if both memory
    ///     blocks are resident. Otherwise, the caller must be running at IRQL
    ///     &lt;= APC_LEVEL.
    ///   </para>
    /// </remarks>
    [DllImport(NTDll_Dll, CallingConvention = CDecl, EntryPoint = "memcpy", SetLastError = false)]
    public static extern void RtlCopyMemory([In] IntPtr Destination, [In] IntPtr Source, [In] size_t Length);

    /// <summary>
    ///   Copies a block of memory from one location to another.
    /// </summary>
    /// <param name="Destination">
    ///   A pointer to the starting address of the copied block's destination.
    /// </param>
    /// <param name="Source">
    ///   A pointer to the starting address of the block of memory to copy.
    /// </param>
    /// <param name="Length">
    ///   The size of the block of memory to copy, in bytes.
    /// </param>
    /// <remarks>
    ///   <para>
    ///     This function is defined as the RtlCopyMemory function. Its
    ///     implementation is provided inline. For more information, see
    ///     Winbase.h and Winnt.h.
    ///   </para>
    ///   <para>
    ///     If the source and destination blocks overlap, the results are
    ///     undefined. For overlapped blocks, use the MoveMemory function.
    ///   </para>
    /// </remarks>
    /// <security>
    ///   The first parameter, Destination, must be large enough to hold Length
    ///   bytes of Source; otherwise, a buffer overrun may occur. This may lead
    ///   to a denial of service attack against the application if an access
    ///   violation occurs or, in the worst case, allow an attacker to inject
    ///   executable code into your process. This is especially true if
    ///   Destination is a stack-based buffer. Be aware that the last
    ///   parameter, Length, is the number of bytes to copy into Destination,
    ///   not the size of the Destination.
    /// </security>
    [DllImport(NTDll_Dll, CallingConvention = CDecl, EntryPoint = "memcpy", SetLastError = false)]
    public static extern void CopyMemory([In] IntPtr Destination, [In] IntPtr Source, [In] size_t Length);

    /// <summary>
    ///   The RtlMoveMemory routine moves memory either forward or backward,
    ///   aligned or unaligned, in 4-byte blocks, followed by any remaining
    ///   bytes.
    /// </summary>
    /// <param name="Destination">
    ///   Pointer to the destination of the move.
    /// </param>
    /// <param name="Source">
    ///   Pointer to the memory to be copied.
    /// </param>
    /// <param name="Length">
    ///   Specifies the number of bytes to be copied.
    /// </param>
    /// <remarks>
    ///   <para>
    ///     The ( Source + Length) can overlap the Destination range passed in
    ///     to RtlMoveMemory.
    ///   </para>
    ///   <para>
    ///     Callers of RtlMoveMemory can be running at any IRQL if both memory
    ///     blocks are resident. Otherwise, the caller must be running at IRQL
    ///     &lt;= APC_LEVEL.
    ///   </para>
    /// </remarks>
    [DllImport(NTDll_Dll, CallingConvention = CDecl, SetLastError = false)]
    public static extern void RtlMoveMemory([In] IntPtr Destination, [In] IntPtr Source, [In] size_t Length);

    //[DllImport("zlib.dll", CallingConvention = CDecl, SetLastError = false)]
    //public static extern
  }
}
