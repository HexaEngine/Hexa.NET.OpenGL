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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVViewportArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DepthRangeArrayfvNVNative(uint first, int count, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, float*, void>)funcTable[0])(first, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, void>)funcTable[0])(first, count, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void DepthRangeArrayfvNV(uint first, int count, float* v)
		{
			DepthRangeArrayfvNVNative(first, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void DepthRangeArrayfvNV(uint first, int count, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				DepthRangeArrayfvNVNative(first, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void DepthRangeArrayfvNV(uint first, int count, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				DepthRangeArrayfvNVNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DepthRangeIndexedfNVNative(uint index, float n, float f)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, float, float, void>)funcTable[1])(index, n, f);
			#else
			((delegate* unmanaged[Cdecl]<uint, float, float, void>)funcTable[1])(index, n, f);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void DepthRangeIndexedfNV(uint index, float n, float f)
		{
			DepthRangeIndexedfNVNative(index, n, f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DisableiNVNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[2])(target, index);
			#else
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[2])(target, index);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void DisableiNV(GLEnableCap target, uint index)
		{
			DisableiNVNative(target, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EnableiNVNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[3])(target, index);
			#else
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[3])(target, index);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void EnableiNV(GLEnableCap target, uint index)
		{
			EnableiNVNative(target, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetFloati_vNVNative(GLGetPName target, uint index, float* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, float*, void>)funcTable[4])(target, index, data);
			#else
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, nint, void>)funcTable[4])(target, index, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void GetFloati_vNV(GLGetPName target, uint index, float* data)
		{
			GetFloati_vNVNative(target, index, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void GetFloati_vNV(GLGetPName target, uint index, Span<float> data)
		{
			fixed (float* pdata0 = data)
			{
				GetFloati_vNVNative(target, index, pdata0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void GetFloati_vNV(GLGetPName target, uint index, ref float data)
		{
			fixed (float* pdata0 = &data)
			{
				GetFloati_vNVNative(target, index, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsEnablediNVNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnableCap, uint, byte>)funcTable[5])(target, index);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<GLEnableCap, uint, byte>)funcTable[5])(target, index);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public bool IsEnablediNV(GLEnableCap target, uint index)
		{
			byte ret = IsEnablediNVNative(target, index);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ScissorArrayvNVNative(uint first, int count, int* v)
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
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ScissorArrayvNV(uint first, int count, int* v)
		{
			ScissorArrayvNVNative(first, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ScissorArrayvNV(uint first, int count, Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				ScissorArrayvNVNative(first, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ScissorArrayvNV(uint first, int count, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				ScissorArrayvNVNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ScissorIndexedNVNative(uint index, int left, int bottom, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[7])(index, left, bottom, width, height);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)funcTable[7])(index, left, bottom, width, height);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ScissorIndexedNV(uint index, int left, int bottom, int width, int height)
		{
			ScissorIndexedNVNative(index, left, bottom, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ScissorIndexedvNVNative(uint index, int* v)
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
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ScissorIndexedvNV(uint index, int* v)
		{
			ScissorIndexedvNVNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ScissorIndexedvNV(uint index, Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				ScissorIndexedvNVNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ScissorIndexedvNV(uint index, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				ScissorIndexedvNVNative(index, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ViewportArrayvNVNative(uint first, int count, float* v)
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
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ViewportArrayvNV(uint first, int count, float* v)
		{
			ViewportArrayvNVNative(first, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ViewportArrayvNV(uint first, int count, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				ViewportArrayvNVNative(first, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ViewportArrayvNV(uint first, int count, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				ViewportArrayvNVNative(first, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ViewportIndexedfNVNative(uint index, float x, float y, float w, float h)
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
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ViewportIndexedfNV(uint index, float x, float y, float w, float h)
		{
			ViewportIndexedfNVNative(index, x, y, w, h);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ViewportIndexedfvNVNative(uint index, float* v)
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
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ViewportIndexedfvNV(uint index, float* v)
		{
			ViewportIndexedfvNVNative(index, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ViewportIndexedfvNV(uint index, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				ViewportIndexedfvNVNative(index, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_viewport_array</remarks>
		public void ViewportIndexedfvNV(uint index, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				ViewportIndexedfvNVNative(index, pv0);
			}
		}

	}
}
