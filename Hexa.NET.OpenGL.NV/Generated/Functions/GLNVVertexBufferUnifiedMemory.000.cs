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

namespace Hexa.NET.OpenGL.NV
{
	public static unsafe partial class GLNVVertexBufferUnifiedMemory
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BufferAddressRangeNVNative(GLEnum pname, uint index, ulong address, nint length)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, ulong, nint, void>)funcTable[0])(pname, index, address, length);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, ulong, nint, void>)funcTable[0])(pname, index, address, length);
			#endif
		}

		public static void BufferAddressRangeNV(GLEnum pname, uint index, ulong address, nint length)
		{
			BufferAddressRangeNVNative(pname, index, address, length);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ColorFormatNVNative(int size, GLColorPointerType type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLColorPointerType, int, void>)funcTable[1])(size, type, stride);
			#else
			((delegate* unmanaged[Cdecl]<int, GLColorPointerType, int, void>)funcTable[1])(size, type, stride);
			#endif
		}

		public static void ColorFormatNV(int size, GLColorPointerType type, int stride)
		{
			ColorFormatNVNative(size, type, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EdgeFlagFormatNVNative(int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, void>)funcTable[2])(stride);
			#else
			((delegate* unmanaged[Cdecl]<int, void>)funcTable[2])(stride);
			#endif
		}

		public static void EdgeFlagFormatNV(int stride)
		{
			EdgeFlagFormatNVNative(stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FogCoordFormatNVNative(GLEnum type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[3])(type, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[3])(type, stride);
			#endif
		}

		public static void FogCoordFormatNV(GLEnum type, int stride)
		{
			FogCoordFormatNVNative(type, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetIntegerui64i_vNVNative(GLEnum value, uint index, ulong* result)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, ulong*, void>)funcTable[4])(value, index, result);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, nint, void>)funcTable[4])(value, index, (nint)result);
			#endif
		}

		public static void GetIntegerui64i_vNV(GLEnum value, uint index, ulong* result)
		{
			GetIntegerui64i_vNVNative(value, index, result);
		}

		public static void GetIntegerui64i_vNV(GLEnum value, uint index, Span<ulong> result)
		{
			fixed (ulong* presult0 = result)
			{
				GetIntegerui64i_vNVNative(value, index, presult0);
			}
		}

		public static void GetIntegerui64i_vNV(GLEnum value, uint index, ref ulong result)
		{
			fixed (ulong* presult0 = &result)
			{
				GetIntegerui64i_vNVNative(value, index, presult0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void IndexFormatNVNative(GLEnum type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[5])(type, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[5])(type, stride);
			#endif
		}

		public static void IndexFormatNV(GLEnum type, int stride)
		{
			IndexFormatNVNative(type, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NormalFormatNVNative(GLEnum type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[6])(type, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[6])(type, stride);
			#endif
		}

		public static void NormalFormatNV(GLEnum type, int stride)
		{
			NormalFormatNVNative(type, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SecondaryColorFormatNVNative(int size, GLColorPointerType type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLColorPointerType, int, void>)funcTable[7])(size, type, stride);
			#else
			((delegate* unmanaged[Cdecl]<int, GLColorPointerType, int, void>)funcTable[7])(size, type, stride);
			#endif
		}

		public static void SecondaryColorFormatNV(int size, GLColorPointerType type, int stride)
		{
			SecondaryColorFormatNVNative(size, type, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexCoordFormatNVNative(int size, GLEnum type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLEnum, int, void>)funcTable[8])(size, type, stride);
			#else
			((delegate* unmanaged[Cdecl]<int, GLEnum, int, void>)funcTable[8])(size, type, stride);
			#endif
		}

		public static void TexCoordFormatNV(int size, GLEnum type, int stride)
		{
			TexCoordFormatNVNative(size, type, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribFormatNVNative(uint index, int size, GLVertexAttribType type, bool normalized, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribType, byte, int, void>)funcTable[9])(index, size, type, *((byte*)(&normalized)), stride);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribType, byte, int, void>)funcTable[9])(index, size, type, *((byte*)(&normalized)), stride);
			#endif
		}

		public static void VertexAttribFormatNV(uint index, int size, GLVertexAttribType type, bool normalized, int stride)
		{
			VertexAttribFormatNVNative(index, size, type, normalized, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribIFormatNVNative(uint index, int size, GLVertexAttribIType type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribIType, int, void>)funcTable[10])(index, size, type, stride);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribIType, int, void>)funcTable[10])(index, size, type, stride);
			#endif
		}

		public static void VertexAttribIFormatNV(uint index, int size, GLVertexAttribIType type, int stride)
		{
			VertexAttribIFormatNVNative(index, size, type, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexFormatNVNative(int size, GLVertexPointerType type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLVertexPointerType, int, void>)funcTable[11])(size, type, stride);
			#else
			((delegate* unmanaged[Cdecl]<int, GLVertexPointerType, int, void>)funcTable[11])(size, type, stride);
			#endif
		}

		public static void VertexFormatNV(int size, GLVertexPointerType type, int stride)
		{
			VertexFormatNVNative(size, type, stride);
		}

	}
}
