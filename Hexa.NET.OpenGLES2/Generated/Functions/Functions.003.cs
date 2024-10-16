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

namespace Hexa.NET.OpenGLES
{
	public static unsafe partial class GL
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI1uivNative(uint index, uint* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint*, void>)funcTable[693])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[693])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI1uiv(uint index, uint* v)
		{
			VertexAttribI1uivNative(index, v);
		}

		public static void VertexAttribI1uiv(uint index, ref uint v)
		{
			fixed (uint* pv0 = &v)
			{
				VertexAttribI1uivNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI2iNative(uint index, int x, int y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, void>)funcTable[694])(index, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, void>)funcTable[694])(index, x, y);
			#endif
		}

		public static void VertexAttribI2i(uint index, int x, int y)
		{
			VertexAttribI2iNative(index, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI2ivNative(uint index, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int*, void>)funcTable[695])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[695])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI2iv(uint index, int* v)
		{
			VertexAttribI2ivNative(index, v);
		}

		public static void VertexAttribI2iv(uint index, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				VertexAttribI2ivNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI2uiNative(uint index, uint x, uint y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, void>)funcTable[696])(index, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, void>)funcTable[696])(index, x, y);
			#endif
		}

		public static void VertexAttribI2ui(uint index, uint x, uint y)
		{
			VertexAttribI2uiNative(index, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI2uivNative(uint index, uint* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint*, void>)funcTable[697])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[697])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI2uiv(uint index, uint* v)
		{
			VertexAttribI2uivNative(index, v);
		}

		public static void VertexAttribI2uiv(uint index, ref uint v)
		{
			fixed (uint* pv0 = &v)
			{
				VertexAttribI2uivNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI3iNative(uint index, int x, int y, int z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, void>)funcTable[698])(index, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, void>)funcTable[698])(index, x, y, z);
			#endif
		}

		public static void VertexAttribI3i(uint index, int x, int y, int z)
		{
			VertexAttribI3iNative(index, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI3ivNative(uint index, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int*, void>)funcTable[699])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[699])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI3iv(uint index, int* v)
		{
			VertexAttribI3ivNative(index, v);
		}

		public static void VertexAttribI3iv(uint index, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				VertexAttribI3ivNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI3uiNative(uint index, uint x, uint y, uint z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, void>)funcTable[700])(index, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, void>)funcTable[700])(index, x, y, z);
			#endif
		}

		public static void VertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			VertexAttribI3uiNative(index, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI3uivNative(uint index, uint* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint*, void>)funcTable[701])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[701])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI3uiv(uint index, uint* v)
		{
			VertexAttribI3uivNative(index, v);
		}

		public static void VertexAttribI3uiv(uint index, ref uint v)
		{
			fixed (uint* pv0 = &v)
			{
				VertexAttribI3uivNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4bvNative(uint index, sbyte* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, sbyte*, void>)funcTable[702])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[702])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI4bv(uint index, sbyte* v)
		{
			VertexAttribI4bvNative(index, v);
		}

		public static void VertexAttribI4bv(uint index, ref sbyte v)
		{
			fixed (sbyte* pv0 = &v)
			{
				VertexAttribI4bvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4iNative(uint index, int x, int y, int z, int w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[703])(index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[703])(index, x, y, z, w);
			#endif
		}

		public static void VertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			VertexAttribI4iNative(index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4ivNative(uint index, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int*, void>)funcTable[704])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[704])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI4iv(uint index, int* v)
		{
			VertexAttribI4ivNative(index, v);
		}

		public static void VertexAttribI4iv(uint index, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				VertexAttribI4ivNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4svNative(uint index, short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, short*, void>)funcTable[705])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[705])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI4sv(uint index, short* v)
		{
			VertexAttribI4svNative(index, v);
		}

		public static void VertexAttribI4sv(uint index, ref short v)
		{
			fixed (short* pv0 = &v)
			{
				VertexAttribI4svNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4ubvNative(uint index, byte* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, byte*, void>)funcTable[706])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[706])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI4ubv(uint index, byte* v)
		{
			VertexAttribI4ubvNative(index, v);
		}

		public static void VertexAttribI4ubv(uint index, string v)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (v != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(v);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(v, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			VertexAttribI4ubvNative(index, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void VertexAttribI4ubv(uint index, ReadOnlySpan<byte> v)
		{
			fixed (byte* pv0 = v)
			{
				VertexAttribI4ubvNative(index, pv0);
			}
		}

		public static void VertexAttribI4ubv(uint index, ref byte v)
		{
			fixed (byte* pv0 = &v)
			{
				VertexAttribI4ubvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4uiNative(uint index, uint x, uint y, uint z, uint w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, uint, void>)funcTable[707])(index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, uint, void>)funcTable[707])(index, x, y, z, w);
			#endif
		}

		public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			VertexAttribI4uiNative(index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4uivNative(uint index, uint* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint*, void>)funcTable[708])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[708])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI4uiv(uint index, uint* v)
		{
			VertexAttribI4uivNative(index, v);
		}

		public static void VertexAttribI4uiv(uint index, ref uint v)
		{
			fixed (uint* pv0 = &v)
			{
				VertexAttribI4uivNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribI4usvNative(uint index, ushort* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ushort*, void>)funcTable[709])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[709])(index, (nint)v);
			#endif
		}

		public static void VertexAttribI4usv(uint index, ushort* v)
		{
			VertexAttribI4usvNative(index, v);
		}

		public static void VertexAttribI4usv(uint index, ref ushort v)
		{
			fixed (ushort* pv0 = &v)
			{
				VertexAttribI4usvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribIFormatNative(uint attribindex, int size, GLVertexAttribIType type, uint relativeoffset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribIType, uint, void>)funcTable[710])(attribindex, size, type, relativeoffset);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribIType, uint, void>)funcTable[710])(attribindex, size, type, relativeoffset);
			#endif
		}

		public static void VertexAttribIFormat(uint attribindex, int size, GLVertexAttribIType type, uint relativeoffset)
		{
			VertexAttribIFormatNative(attribindex, size, type, relativeoffset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribIPointerNative(uint index, int size, GLVertexAttribIType type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribIType, int, void*, void>)funcTable[711])(index, size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribIType, int, nint, void>)funcTable[711])(index, size, type, stride, (nint)pointer);
			#endif
		}

		public static void VertexAttribIPointer(uint index, int size, GLVertexAttribIType type, int stride, void* pointer)
		{
			VertexAttribIPointerNative(index, size, type, stride, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1dNative(uint index, double x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double, void>)funcTable[712])(index, x);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, void>)funcTable[712])(index, x);
			#endif
		}

		public static void VertexAttribL1d(uint index, double x)
		{
			VertexAttribL1dNative(index, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[713])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[713])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL1dv(uint index, double* v)
		{
			VertexAttribL1dvNative(index, v);
		}

		public static void VertexAttribL1dv(uint index, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				VertexAttribL1dvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL2dNative(uint index, double x, double y)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[714])(index, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[714])(index, x, y);
			#endif
		}

		public static void VertexAttribL2d(uint index, double x, double y)
		{
			VertexAttribL2dNative(index, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL2dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[715])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[715])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL2dv(uint index, double* v)
		{
			VertexAttribL2dvNative(index, v);
		}

		public static void VertexAttribL2dv(uint index, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				VertexAttribL2dvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL3dNative(uint index, double x, double y, double z)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double, double, double, void>)funcTable[716])(index, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, double, void>)funcTable[716])(index, x, y, z);
			#endif
		}

		public static void VertexAttribL3d(uint index, double x, double y, double z)
		{
			VertexAttribL3dNative(index, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL3dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[717])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[717])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL3dv(uint index, double* v)
		{
			VertexAttribL3dvNative(index, v);
		}

		public static void VertexAttribL3dv(uint index, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				VertexAttribL3dvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL4dNative(uint index, double x, double y, double z, double w)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double, double, double, double, void>)funcTable[718])(index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, double, double, void>)funcTable[718])(index, x, y, z, w);
			#endif
		}

		public static void VertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			VertexAttribL4dNative(index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL4dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[719])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[719])(index, (nint)v);
			#endif
		}

		public static void VertexAttribL4dv(uint index, double* v)
		{
			VertexAttribL4dvNative(index, v);
		}

		public static void VertexAttribL4dv(uint index, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				VertexAttribL4dvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribLFormatNative(uint attribindex, int size, GLVertexAttribLType type, uint relativeoffset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, uint, void>)funcTable[720])(attribindex, size, type, relativeoffset);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, uint, void>)funcTable[720])(attribindex, size, type, relativeoffset);
			#endif
		}

		public static void VertexAttribLFormat(uint attribindex, int size, GLVertexAttribLType type, uint relativeoffset)
		{
			VertexAttribLFormatNative(attribindex, size, type, relativeoffset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribLPointerNative(uint index, int size, GLVertexAttribLType type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, int, void*, void>)funcTable[721])(index, size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, int, nint, void>)funcTable[721])(index, size, type, stride, (nint)pointer);
			#endif
		}

		public static void VertexAttribLPointer(uint index, int size, GLVertexAttribLType type, int stride, void* pointer)
		{
			VertexAttribLPointerNative(index, size, type, stride, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP1uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[722])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[722])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP1ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP1uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP1uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[723])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[723])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP1uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP1uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP1uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP1uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP2uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[724])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[724])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP2ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP2uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP2uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[725])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[725])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP2uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP2uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP2uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP2uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP3uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[726])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[726])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP3ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP3uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP3uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[727])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[727])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP3uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP3uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP3uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP3uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP4uiNative(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[728])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint, void>)funcTable[728])(index, type, normalized, value);
			#endif
		}

		public static void VertexAttribP4ui(uint index, GLVertexAttribPointerType type, byte normalized, uint value)
		{
			VertexAttribP4uiNative(index, type, normalized, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribP4uivNative(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, uint*, void>)funcTable[729])(index, type, normalized, value);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribPointerType, byte, nint, void>)funcTable[729])(index, type, normalized, (nint)value);
			#endif
		}

		public static void VertexAttribP4uiv(uint index, GLVertexAttribPointerType type, byte normalized, uint* value)
		{
			VertexAttribP4uivNative(index, type, normalized, value);
		}

		public static void VertexAttribP4uiv(uint index, GLVertexAttribPointerType type, byte normalized, ref uint value)
		{
			fixed (uint* pvalue0 = &value)
			{
				VertexAttribP4uivNative(index, type, normalized, pvalue0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribPointerNative(uint index, int size, GLVertexAttribPointerType type, byte normalized, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribPointerType, byte, int, void*, void>)funcTable[730])(index, size, type, normalized, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribPointerType, byte, int, nint, void>)funcTable[730])(index, size, type, normalized, stride, (nint)pointer);
			#endif
		}

		public static void VertexAttribPointer(uint index, int size, GLVertexAttribPointerType type, byte normalized, int stride, void* pointer)
		{
			VertexAttribPointerNative(index, size, type, normalized, stride, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexBindingDivisorNative(uint bindingindex, uint divisor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[731])(bindingindex, divisor);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[731])(bindingindex, divisor);
			#endif
		}

		public static void VertexBindingDivisor(uint bindingindex, uint divisor)
		{
			VertexBindingDivisorNative(bindingindex, divisor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexPointerNative(int size, GLVertexPointerType type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLVertexPointerType, int, void*, void>)funcTable[732])(size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, GLVertexPointerType, int, nint, void>)funcTable[732])(size, type, stride, (nint)pointer);
			#endif
		}

		public static void VertexPointer(int size, GLVertexPointerType type, int stride, void* pointer)
		{
			VertexPointerNative(size, type, stride, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ViewportNative(int x, int y, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[733])(x, y, width, height);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, void>)funcTable[733])(x, y, width, height);
			#endif
		}

		public static void Viewport(int x, int y, int width, int height)
		{
			ViewportNative(x, y, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ViewportArrayvNative(uint first, int count, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float*, void>)funcTable[734])(first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[734])(first, count, (nint)v);
			#endif
		}

		public static void ViewportArrayv(uint first, int count, float* v)
		{
			ViewportArrayvNative(first, count, v);
		}

		public static void ViewportArrayv(uint first, int count, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				ViewportArrayvNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ViewportIndexedfNative(uint index, float x, float y, float w, float h)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, float, float, float, float, void>)funcTable[735])(index, x, y, w, h);
			#else
			((delegate* unmanaged[Cdecl]<uint, float, float, float, float, void>)funcTable[735])(index, x, y, w, h);
			#endif
		}

		public static void ViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			ViewportIndexedfNative(index, x, y, w, h);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ViewportIndexedfvNative(uint index, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, float*, void>)funcTable[736])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[736])(index, (nint)v);
			#endif
		}

		public static void ViewportIndexedfv(uint index, float* v)
		{
			ViewportIndexedfvNative(index, v);
		}

		public static void ViewportIndexedfv(uint index, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				ViewportIndexedfvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WaitSyncNative(GLSync sync, GLSyncBehaviorFlags flags, ulong timeout)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSync, GLSyncBehaviorFlags, ulong, void>)funcTable[737])(sync, flags, timeout);
			#else
			((delegate* unmanaged[Cdecl]<GLSync, GLSyncBehaviorFlags, ulong, void>)funcTable[737])(sync, flags, timeout);
			#endif
		}

		public static void WaitSync(GLSync sync, GLSyncBehaviorFlags flags, ulong timeout)
		{
			WaitSyncNative(sync, flags, timeout);
		}

	}
}
