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

namespace Hexa.NET.OpenGL.EXT
{
	public unsafe partial class GLEXTCoordinateFrame
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3bEXTNative(sbyte bx, sbyte by, sbyte bz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)funcTable[0])(bx, by, bz);
			#else
			((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)funcTable[0])(bx, by, bz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3bEXT(sbyte bx, sbyte by, sbyte bz)
		{
			Binormal3bEXTNative(bx, by, bz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3bvEXTNative(sbyte* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<sbyte*, void>)funcTable[1])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[1])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3bvEXT(sbyte* v)
		{
			Binormal3bvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3bvEXT(Span<sbyte> v)
		{
			fixed (sbyte* pv0 = v)
			{
				Binormal3bvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3bvEXT(ref sbyte v)
		{
			fixed (sbyte* pv0 = &v)
			{
				Binormal3bvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3dEXTNative(double bx, double by, double bz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[2])(bx, by, bz);
			#else
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[2])(bx, by, bz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3dEXT(double bx, double by, double bz)
		{
			Binormal3dEXTNative(bx, by, bz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3dvEXTNative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[3])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[3])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3dvEXT(double* v)
		{
			Binormal3dvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3dvEXT(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				Binormal3dvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3dvEXT(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				Binormal3dvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3fEXTNative(float bx, float by, float bz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[4])(bx, by, bz);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[4])(bx, by, bz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3fEXT(float bx, float by, float bz)
		{
			Binormal3fEXTNative(bx, by, bz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3fvEXTNative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[5])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[5])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3fvEXT(float* v)
		{
			Binormal3fvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3fvEXT(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				Binormal3fvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3fvEXT(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				Binormal3fvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3iEXTNative(int bx, int by, int bz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[6])(bx, by, bz);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[6])(bx, by, bz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3iEXT(int bx, int by, int bz)
		{
			Binormal3iEXTNative(bx, by, bz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3ivEXTNative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[7])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[7])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3ivEXT(int* v)
		{
			Binormal3ivEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3ivEXT(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				Binormal3ivEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3ivEXT(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				Binormal3ivEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3sEXTNative(short bx, short by, short bz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[8])(bx, by, bz);
			#else
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[8])(bx, by, bz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3sEXT(short bx, short by, short bz)
		{
			Binormal3sEXTNative(bx, by, bz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Binormal3svEXTNative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[9])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[9])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3svEXT(short* v)
		{
			Binormal3svEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3svEXT(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				Binormal3svEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Binormal3svEXT(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				Binormal3svEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BinormalPointerEXTNative(GLBinormalPointerTypeEXT type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBinormalPointerTypeEXT, int, void*, void>)funcTable[10])(type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLBinormalPointerTypeEXT, int, nint, void>)funcTable[10])(type, stride, (nint)pointer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void BinormalPointerEXT(GLBinormalPointerTypeEXT type, int stride, void* pointer)
		{
			BinormalPointerEXTNative(type, stride, pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void BinormalPointerEXT(GLBinormalPointerTypeEXT type, int stride, nint pointer)
		{
			BinormalPointerEXTNative(type, stride, (void*)pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void BinormalPointerEXT<TPointer>(GLBinormalPointerTypeEXT type, int stride, Span<TPointer> pointer) where TPointer : unmanaged
		{
			fixed (TPointer* ppointer0 = pointer)
			{
				BinormalPointerEXTNative(type, stride, ppointer0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3bEXTNative(sbyte tx, sbyte ty, sbyte tz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)funcTable[11])(tx, ty, tz);
			#else
			((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)funcTable[11])(tx, ty, tz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3bEXT(sbyte tx, sbyte ty, sbyte tz)
		{
			Tangent3bEXTNative(tx, ty, tz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3bvEXTNative(sbyte* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<sbyte*, void>)funcTable[12])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[12])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3bvEXT(sbyte* v)
		{
			Tangent3bvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3bvEXT(Span<sbyte> v)
		{
			fixed (sbyte* pv0 = v)
			{
				Tangent3bvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3bvEXT(ref sbyte v)
		{
			fixed (sbyte* pv0 = &v)
			{
				Tangent3bvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3dEXTNative(double tx, double ty, double tz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[13])(tx, ty, tz);
			#else
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[13])(tx, ty, tz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3dEXT(double tx, double ty, double tz)
		{
			Tangent3dEXTNative(tx, ty, tz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3dvEXTNative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[14])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[14])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3dvEXT(double* v)
		{
			Tangent3dvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3dvEXT(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				Tangent3dvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3dvEXT(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				Tangent3dvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3fEXTNative(float tx, float ty, float tz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[15])(tx, ty, tz);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[15])(tx, ty, tz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3fEXT(float tx, float ty, float tz)
		{
			Tangent3fEXTNative(tx, ty, tz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3fvEXTNative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[16])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[16])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3fvEXT(float* v)
		{
			Tangent3fvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3fvEXT(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				Tangent3fvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3fvEXT(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				Tangent3fvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3iEXTNative(int tx, int ty, int tz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[17])(tx, ty, tz);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[17])(tx, ty, tz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3iEXT(int tx, int ty, int tz)
		{
			Tangent3iEXTNative(tx, ty, tz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3ivEXTNative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[18])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[18])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3ivEXT(int* v)
		{
			Tangent3ivEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3ivEXT(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				Tangent3ivEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3ivEXT(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				Tangent3ivEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3sEXTNative(short tx, short ty, short tz)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[19])(tx, ty, tz);
			#else
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[19])(tx, ty, tz);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3sEXT(short tx, short ty, short tz)
		{
			Tangent3sEXTNative(tx, ty, tz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Tangent3svEXTNative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[20])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[20])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3svEXT(short* v)
		{
			Tangent3svEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3svEXT(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				Tangent3svEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void Tangent3svEXT(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				Tangent3svEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TangentPointerEXTNative(GLTangentPointerTypeEXT type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTangentPointerTypeEXT, int, void*, void>)funcTable[21])(type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLTangentPointerTypeEXT, int, nint, void>)funcTable[21])(type, stride, (nint)pointer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void TangentPointerEXT(GLTangentPointerTypeEXT type, int stride, void* pointer)
		{
			TangentPointerEXTNative(type, stride, pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void TangentPointerEXT(GLTangentPointerTypeEXT type, int stride, nint pointer)
		{
			TangentPointerEXTNative(type, stride, (void*)pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_coordinate_frame</remarks>
		public void TangentPointerEXT<TPointer>(GLTangentPointerTypeEXT type, int stride, Span<TPointer> pointer) where TPointer : unmanaged
		{
			fixed (TPointer* ppointer0 = pointer)
			{
				TangentPointerEXTNative(type, stride, ppointer0);
			}
		}

	}
}
