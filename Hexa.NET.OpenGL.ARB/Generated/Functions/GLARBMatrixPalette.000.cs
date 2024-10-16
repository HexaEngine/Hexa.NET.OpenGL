// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Runtime.CompilerServices;
using System.Numerics;

namespace Hexa.NET.OpenGL.ARB
{
	public static unsafe partial class GLARBMatrixPalette
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CurrentPaletteMatrixARBNative(int index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, void>)funcTable[0])(index);
			#else
			((delegate* unmanaged[Cdecl]<int, void>)funcTable[0])(index);
			#endif
		}

		public static void CurrentPaletteMatrixARB(int index)
		{
			CurrentPaletteMatrixARBNative(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MatrixIndexPointerARBNative(int size, GLMatrixIndexPointerTypeARB type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLMatrixIndexPointerTypeARB, int, void*, void>)funcTable[1])(size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, GLMatrixIndexPointerTypeARB, int, nint, void>)funcTable[1])(size, type, stride, (nint)pointer);
			#endif
		}

		public static void MatrixIndexPointerARB(int size, GLMatrixIndexPointerTypeARB type, int stride, void* pointer)
		{
			MatrixIndexPointerARBNative(size, type, stride, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MatrixIndexubvARBNative(int size, byte* indices)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, void>)funcTable[2])(size, indices);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(size, (nint)indices);
			#endif
		}

		public static void MatrixIndexubvARB(int size, byte* indices)
		{
			MatrixIndexubvARBNative(size, indices);
		}

		public static void MatrixIndexubvARB(int size, string indices)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (indices != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(indices);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(indices, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			MatrixIndexubvARBNative(size, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void MatrixIndexubvARB(int size, ReadOnlySpan<byte> indices)
		{
			fixed (byte* pindices0 = indices)
			{
				MatrixIndexubvARBNative(size, pindices0);
			}
		}

		public static void MatrixIndexubvARB(int size, ref byte indices)
		{
			fixed (byte* pindices0 = &indices)
			{
				MatrixIndexubvARBNative(size, pindices0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MatrixIndexuivARBNative(int size, uint* indices)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[3])(size, indices);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[3])(size, (nint)indices);
			#endif
		}

		public static void MatrixIndexuivARB(int size, uint* indices)
		{
			MatrixIndexuivARBNative(size, indices);
		}

		public static void MatrixIndexuivARB(int size, ref uint indices)
		{
			fixed (uint* pindices0 = &indices)
			{
				MatrixIndexuivARBNative(size, pindices0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MatrixIndexusvARBNative(int size, ushort* indices)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, ushort*, void>)funcTable[4])(size, indices);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[4])(size, (nint)indices);
			#endif
		}

		public static void MatrixIndexusvARB(int size, ushort* indices)
		{
			MatrixIndexusvARBNative(size, indices);
		}

		public static void MatrixIndexusvARB(int size, ref ushort indices)
		{
			fixed (ushort* pindices0 = &indices)
			{
				MatrixIndexusvARBNative(size, pindices0);
			}
		}

	}
}