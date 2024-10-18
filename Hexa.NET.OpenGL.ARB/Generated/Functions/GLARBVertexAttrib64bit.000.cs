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
	public static unsafe partial class GLARBVertexAttrib64bit
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetVertexAttribLdvNative(uint index, GLVertexAttribEnum pname, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribEnum, double*, void>)funcTable[0])(index, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLVertexAttribEnum, nint, void>)funcTable[0])(index, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void GetVertexAttribLdv(uint index, GLVertexAttribEnum pname, double* @params)
		{
			GetVertexAttribLdvNative(index, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void GetVertexAttribLdv(uint index, GLVertexAttribEnum pname, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				GetVertexAttribLdvNative(index, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void GetVertexAttribLdv(uint index, GLVertexAttribEnum pname, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				GetVertexAttribLdvNative(index, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1dNative(uint index, double x)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double, void>)funcTable[1])(index, x);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, void>)funcTable[1])(index, x);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL1d(uint index, double x)
		{
			VertexAttribL1dNative(index, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL1dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[2])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[2])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL1dv(uint index, double* v)
		{
			VertexAttribL1dvNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL1dv(uint index, Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				VertexAttribL1dvNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
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
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[3])(index, x, y);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[3])(index, x, y);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL2d(uint index, double x, double y)
		{
			VertexAttribL2dNative(index, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL2dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[4])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[4])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL2dv(uint index, double* v)
		{
			VertexAttribL2dvNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL2dv(uint index, Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				VertexAttribL2dvNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
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
			((delegate* unmanaged[Cdecl]<uint, double, double, double, void>)funcTable[5])(index, x, y, z);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, double, void>)funcTable[5])(index, x, y, z);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL3d(uint index, double x, double y, double z)
		{
			VertexAttribL3dNative(index, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL3dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[6])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[6])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL3dv(uint index, double* v)
		{
			VertexAttribL3dvNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL3dv(uint index, Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				VertexAttribL3dvNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
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
			((delegate* unmanaged[Cdecl]<uint, double, double, double, double, void>)funcTable[7])(index, x, y, z, w);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, double, double, void>)funcTable[7])(index, x, y, z, w);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			VertexAttribL4dNative(index, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribL4dvNative(uint index, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double*, void>)funcTable[8])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[8])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL4dv(uint index, double* v)
		{
			VertexAttribL4dvNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL4dv(uint index, Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				VertexAttribL4dvNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribL4dv(uint index, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				VertexAttribL4dvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribLPointerNative(uint index, int size, GLVertexAttribLType type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, int, void*, void>)funcTable[9])(index, size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLVertexAttribLType, int, nint, void>)funcTable[9])(index, size, type, stride, (nint)pointer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribLPointer(uint index, int size, GLVertexAttribLType type, int stride, void* pointer)
		{
			VertexAttribLPointerNative(index, size, type, stride, pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribLPointer(uint index, int size, GLVertexAttribLType type, int stride, nint pointer)
		{
			VertexAttribLPointerNative(index, size, type, stride, (void*)pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_vertex_attrib_64bit</remarks>
		public static void VertexAttribLPointer<TPointer>(uint index, int size, GLVertexAttribLType type, int stride, Span<TPointer> pointer) where TPointer : unmanaged
		{
			fixed (TPointer* ppointer0 = pointer)
			{
				VertexAttribLPointerNative(index, size, type, stride, ppointer0);
			}
		}

	}
}
