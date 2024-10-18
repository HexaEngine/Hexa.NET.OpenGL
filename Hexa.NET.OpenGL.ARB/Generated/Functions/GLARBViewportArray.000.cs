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
	public static unsafe partial class GLARBViewportArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DepthRangeArraydvNVNative(uint first, int count, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, double*, void>)funcTable[0])(first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[0])(first, count, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeArraydvNV(uint first, int count, double* v)
		{
			DepthRangeArraydvNVNative(first, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeArraydvNV(uint first, int count, Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				DepthRangeArraydvNVNative(first, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeArraydvNV(uint first, int count, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				DepthRangeArraydvNVNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DepthRangeArrayvNative(uint first, int count, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, double*, void>)funcTable[1])(first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[1])(first, count, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeArrayv(uint first, int count, double* v)
		{
			DepthRangeArrayvNative(first, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeArrayv(uint first, int count, Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				DepthRangeArrayvNative(first, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeArrayv(uint first, int count, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				DepthRangeArrayvNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DepthRangeIndexedNative(uint index, double n, double f)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[2])(index, n, f);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[2])(index, n, f);
			#endif
		}

		/// <summary>
		/// Specify mapping of depth values from normalized device coordinates to window coordinates for a specified viewport
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeIndexed(uint index, double n, double f)
		{
			DepthRangeIndexedNative(index, n, f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DepthRangeIndexeddNVNative(uint index, double n, double f)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[3])(index, n, f);
			#else
			((delegate* unmanaged[Cdecl]<uint, double, double, void>)funcTable[3])(index, n, f);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void DepthRangeIndexeddNV(uint index, double n, double f)
		{
			DepthRangeIndexeddNVNative(index, n, f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetDoublei_vNative(GLGetPName target, uint index, double* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, double*, void>)funcTable[4])(target, index, data);
			#else
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, nint, void>)funcTable[4])(target, index, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void GetDoublei_v(GLGetPName target, uint index, double* data)
		{
			GetDoublei_vNative(target, index, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void GetDoublei_v(GLGetPName target, uint index, Span<double> data)
		{
			fixed (double* pdata0 = data)
			{
				GetDoublei_vNative(target, index, pdata0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void GetDoublei_v(GLGetPName target, uint index, ref double data)
		{
			fixed (double* pdata0 = &data)
			{
				GetDoublei_vNative(target, index, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetFloati_vNative(GLGetPName target, uint index, float* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, float*, void>)funcTable[5])(target, index, data);
			#else
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, nint, void>)funcTable[5])(target, index, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void GetFloati_v(GLGetPName target, uint index, float* data)
		{
			GetFloati_vNative(target, index, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void GetFloati_v(GLGetPName target, uint index, Span<float> data)
		{
			fixed (float* pdata0 = data)
			{
				GetFloati_vNative(target, index, pdata0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void GetFloati_v(GLGetPName target, uint index, ref float data)
		{
			fixed (float* pdata0 = &data)
			{
				GetFloati_vNative(target, index, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ScissorArrayvNative(uint first, int count, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, void>)funcTable[6])(first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[6])(first, count, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ScissorArrayv(uint first, int count, int* v)
		{
			ScissorArrayvNative(first, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ScissorArrayv(uint first, int count, Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				ScissorArrayvNative(first, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ScissorArrayv(uint first, int count, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				ScissorArrayvNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ScissorIndexedNative(uint index, int left, int bottom, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[7])(index, left, bottom, width, height);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[7])(index, left, bottom, width, height);
			#endif
		}

		/// <summary>
		/// Define the scissor box for a specific viewport
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			ScissorIndexedNative(index, left, bottom, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ScissorIndexedvNative(uint index, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int*, void>)funcTable[8])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[8])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ScissorIndexedv(uint index, int* v)
		{
			ScissorIndexedvNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ScissorIndexedv(uint index, Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				ScissorIndexedvNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ScissorIndexedv(uint index, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				ScissorIndexedvNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ViewportArrayvNative(uint first, int count, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float*, void>)funcTable[9])(first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[9])(first, count, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ViewportArrayv(uint first, int count, float* v)
		{
			ViewportArrayvNative(first, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ViewportArrayv(uint first, int count, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				ViewportArrayvNative(first, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
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
			((delegate* unmanaged[Cdecl]<uint, float, float, float, float, void>)funcTable[10])(index, x, y, w, h);
			#else
			((delegate* unmanaged[Cdecl]<uint, float, float, float, float, void>)funcTable[10])(index, x, y, w, h);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			ViewportIndexedfNative(index, x, y, w, h);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ViewportIndexedfvNative(uint index, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, float*, void>)funcTable[11])(index, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, void>)funcTable[11])(index, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ViewportIndexedfv(uint index, float* v)
		{
			ViewportIndexedfvNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ViewportIndexedfv(uint index, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				ViewportIndexedfvNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.1 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_viewport_array</remarks>
		public static void ViewportIndexedfv(uint index, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				ViewportIndexedfvNative(index, pv0);
			}
		}

	}
}
