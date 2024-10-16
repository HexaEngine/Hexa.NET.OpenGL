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
	public static unsafe partial class GLNVVertexAttribInteger64bit
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetVertexAttribLi64vNVNative(uint index, GLVertexAttribEnum pname, long* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribEnum, long*, void>)funcTable[0])(index, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribEnum, nint, void>)funcTable[0])(index, pname, (nint)@params);
			#endif
		}

		public static void GetVertexAttribLi64vNV(uint index, GLVertexAttribEnum pname, long* @params)
		{
			GetVertexAttribLi64vNVNative(index, pname, @params);
		}

		public static void GetVertexAttribLi64vNV(uint index, GLVertexAttribEnum pname, ref long @params)
		{
			fixed (long* pparams0 = &@params)
			{
				GetVertexAttribLi64vNVNative(index, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetVertexAttribLui64vNVNative(uint index, GLVertexAttribEnum pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribEnum, ulong*, void>)funcTable[1])(index, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribEnum, nint, void>)funcTable[1])(index, pname, (nint)@params);
			#endif
		}

		public static void GetVertexAttribLui64vNV(uint index, GLVertexAttribEnum pname, ulong* @params)
		{
			GetVertexAttribLui64vNVNative(index, pname, @params);
		}

		public static void GetVertexAttribLui64vNV(uint index, GLVertexAttribEnum pname, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				GetVertexAttribLui64vNVNative(index, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1i64NVNative(uint index, long x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long, void>)funcTable[2])(index, x);
			#else
			((delegate* unmanaged[Cdecl]<uint, long, void>)funcTable[2])(index, x);
			#endif
		}

		public static void VertexAttribL1i64NV(uint index, long x)
		{
			VertexAttribL1i64NVNative(index, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1i64vNVNative(uint index, long* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long*, void>)funcTable[3])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[3])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL1i64vNV(uint index, long* v)
		{
			VertexAttribL1i64vNVNative(index, v);
		}

		public static void VertexAttribL1i64vNV(uint index, ref long v)
		{
			fixed (long* pv0 = &v)
			{
				VertexAttribL1i64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1ui64NVNative(uint index, ulong x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong, void>)funcTable[4])(index, x);
			#else
			((delegate* unmanaged[Cdecl]<uint, ulong, void>)funcTable[4])(index, x);
			#endif
		}

		public static void VertexAttribL1ui64NV(uint index, ulong x)
		{
			VertexAttribL1ui64NVNative(index, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1ui64vNVNative(uint index, ulong* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong*, void>)funcTable[5])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[5])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL1ui64vNV(uint index, ulong* v)
		{
			VertexAttribL1ui64vNVNative(index, v);
		}

		public static void VertexAttribL1ui64vNV(uint index, ref ulong v)
		{
			fixed (ulong* pv0 = &v)
			{
				VertexAttribL1ui64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL2i64NVNative(uint index, long x, long y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long, long, void>)funcTable[6])(index, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, long, long, void>)funcTable[6])(index, x, y);
			#endif
		}

		public static void VertexAttribL2i64NV(uint index, long x, long y)
		{
			VertexAttribL2i64NVNative(index, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL2i64vNVNative(uint index, long* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long*, void>)funcTable[7])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[7])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL2i64vNV(uint index, long* v)
		{
			VertexAttribL2i64vNVNative(index, v);
		}

		public static void VertexAttribL2i64vNV(uint index, ref long v)
		{
			fixed (long* pv0 = &v)
			{
				VertexAttribL2i64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL2ui64NVNative(uint index, ulong x, ulong y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong, ulong, void>)funcTable[8])(index, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, ulong, ulong, void>)funcTable[8])(index, x, y);
			#endif
		}

		public static void VertexAttribL2ui64NV(uint index, ulong x, ulong y)
		{
			VertexAttribL2ui64NVNative(index, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL2ui64vNVNative(uint index, ulong* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong*, void>)funcTable[9])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[9])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL2ui64vNV(uint index, ulong* v)
		{
			VertexAttribL2ui64vNVNative(index, v);
		}

		public static void VertexAttribL2ui64vNV(uint index, ref ulong v)
		{
			fixed (ulong* pv0 = &v)
			{
				VertexAttribL2ui64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL3i64NVNative(uint index, long x, long y, long z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long, long, long, void>)funcTable[10])(index, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, long, long, long, void>)funcTable[10])(index, x, y, z);
			#endif
		}

		public static void VertexAttribL3i64NV(uint index, long x, long y, long z)
		{
			VertexAttribL3i64NVNative(index, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL3i64vNVNative(uint index, long* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long*, void>)funcTable[11])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[11])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL3i64vNV(uint index, long* v)
		{
			VertexAttribL3i64vNVNative(index, v);
		}

		public static void VertexAttribL3i64vNV(uint index, ref long v)
		{
			fixed (long* pv0 = &v)
			{
				VertexAttribL3i64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL3ui64NVNative(uint index, ulong x, ulong y, ulong z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong, ulong, ulong, void>)funcTable[12])(index, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, ulong, ulong, ulong, void>)funcTable[12])(index, x, y, z);
			#endif
		}

		public static void VertexAttribL3ui64NV(uint index, ulong x, ulong y, ulong z)
		{
			VertexAttribL3ui64NVNative(index, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL3ui64vNVNative(uint index, ulong* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong*, void>)funcTable[13])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[13])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL3ui64vNV(uint index, ulong* v)
		{
			VertexAttribL3ui64vNVNative(index, v);
		}

		public static void VertexAttribL3ui64vNV(uint index, ref ulong v)
		{
			fixed (ulong* pv0 = &v)
			{
				VertexAttribL3ui64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL4i64NVNative(uint index, long x, long y, long z, long w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long, long, long, long, void>)funcTable[14])(index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, long, long, long, long, void>)funcTable[14])(index, x, y, z, w);
			#endif
		}

		public static void VertexAttribL4i64NV(uint index, long x, long y, long z, long w)
		{
			VertexAttribL4i64NVNative(index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL4i64vNVNative(uint index, long* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, long*, void>)funcTable[15])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[15])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL4i64vNV(uint index, long* v)
		{
			VertexAttribL4i64vNVNative(index, v);
		}

		public static void VertexAttribL4i64vNV(uint index, ref long v)
		{
			fixed (long* pv0 = &v)
			{
				VertexAttribL4i64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL4ui64NVNative(uint index, ulong x, ulong y, ulong z, ulong w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong, ulong, ulong, ulong, void>)funcTable[16])(index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, ulong, ulong, ulong, ulong, void>)funcTable[16])(index, x, y, z, w);
			#endif
		}

		public static void VertexAttribL4ui64NV(uint index, ulong x, ulong y, ulong z, ulong w)
		{
			VertexAttribL4ui64NVNative(index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL4ui64vNVNative(uint index, ulong* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong*, void>)funcTable[17])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[17])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL4ui64vNV(uint index, ulong* v)
		{
			VertexAttribL4ui64vNVNative(index, v);
		}

		public static void VertexAttribL4ui64vNV(uint index, ref ulong v)
		{
			fixed (ulong* pv0 = &v)
			{
				VertexAttribL4ui64vNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribLFormatNVNative(uint index, int size, GLVertexAttribLType type, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, int, void>)funcTable[18])(index, size, type, stride);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, int, void>)funcTable[18])(index, size, type, stride);
			#endif
		}

		public static void VertexAttribLFormatNV(uint index, int size, GLVertexAttribLType type, int stride)
		{
			VertexAttribLFormatNVNative(index, size, type, stride);
		}

	}
}
