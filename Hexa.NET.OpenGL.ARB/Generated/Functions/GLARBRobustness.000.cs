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
	public unsafe partial class GLARBRobustness
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal GLEnum GetGraphicsResetStatusARBNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum>)funcTable[0])();
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLEnum>)funcTable[0])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public GLEnum GetGraphicsResetStatusARB()
		{
			GLEnum ret = GetGraphicsResetStatusARBNative();
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnColorTableARBNative(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, int bufSize, void* table)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[1])(target, format, type, bufSize, table);
			#else
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[1])(target, format, type, bufSize, (nint)table);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnColorTableARB(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, int bufSize, void* table)
		{
			GetnColorTableARBNative(target, format, type, bufSize, table);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnColorTableARB(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, int bufSize, nint table)
		{
			GetnColorTableARBNative(target, format, type, bufSize, (void*)table);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnColorTableARB<TTable>(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, int bufSize, Span<TTable> table) where TTable : unmanaged
		{
			fixed (TTable* ptable0 = table)
			{
				GetnColorTableARBNative(target, format, type, bufSize, ptable0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnCompressedTexImageARBNative(GLTextureTarget target, int lod, int bufSize, void* img)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, void*, void>)funcTable[2])(target, lod, bufSize, img);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, nint, void>)funcTable[2])(target, lod, bufSize, (nint)img);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnCompressedTexImageARB(GLTextureTarget target, int lod, int bufSize, void* img)
		{
			GetnCompressedTexImageARBNative(target, lod, bufSize, img);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnCompressedTexImageARB(GLTextureTarget target, int lod, int bufSize, nint img)
		{
			GetnCompressedTexImageARBNative(target, lod, bufSize, (void*)img);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnCompressedTexImageARB<TImg>(GLTextureTarget target, int lod, int bufSize, Span<TImg> img) where TImg : unmanaged
		{
			fixed (TImg* pimg0 = img)
			{
				GetnCompressedTexImageARBNative(target, lod, bufSize, pimg0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnConvolutionFilterARBNative(GLConvolutionTarget target, GLPixelFormat format, GLPixelType type, int bufSize, void* image)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTarget, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[3])(target, format, type, bufSize, image);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTarget, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[3])(target, format, type, bufSize, (nint)image);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnConvolutionFilterARB(GLConvolutionTarget target, GLPixelFormat format, GLPixelType type, int bufSize, void* image)
		{
			GetnConvolutionFilterARBNative(target, format, type, bufSize, image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnConvolutionFilterARB(GLConvolutionTarget target, GLPixelFormat format, GLPixelType type, int bufSize, nint image)
		{
			GetnConvolutionFilterARBNative(target, format, type, bufSize, (void*)image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnConvolutionFilterARB<TImage>(GLConvolutionTarget target, GLPixelFormat format, GLPixelType type, int bufSize, Span<TImage> image) where TImage : unmanaged
		{
			fixed (TImage* pimage0 = image)
			{
				GetnConvolutionFilterARBNative(target, format, type, bufSize, pimage0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnHistogramARBNative(GLHistogramTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, void* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLHistogramTargetEXT, byte, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[4])(target, *((byte*)(&reset)), format, type, bufSize, values);
			#else
			((delegate* unmanaged[Cdecl]<GLHistogramTargetEXT, byte, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[4])(target, *((byte*)(&reset)), format, type, bufSize, (nint)values);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnHistogramARB(GLHistogramTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, void* values)
		{
			GetnHistogramARBNative(target, reset, format, type, bufSize, values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnHistogramARB(GLHistogramTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, nint values)
		{
			GetnHistogramARBNative(target, reset, format, type, bufSize, (void*)values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnHistogramARB<TValues>(GLHistogramTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, Span<TValues> values) where TValues : unmanaged
		{
			fixed (TValues* pvalues0 = values)
			{
				GetnHistogramARBNative(target, reset, format, type, bufSize, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnMapdvARBNative(GLMapTarget target, GLMapQuery query, int bufSize, double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLMapTarget, GLMapQuery, int, double*, void>)funcTable[5])(target, query, bufSize, v);
			#else
			((delegate* unmanaged[Cdecl]<GLMapTarget, GLMapQuery, int, nint, void>)funcTable[5])(target, query, bufSize, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapdvARB(GLMapTarget target, GLMapQuery query, int bufSize, double* v)
		{
			GetnMapdvARBNative(target, query, bufSize, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapdvARB(GLMapTarget target, GLMapQuery query, int bufSize, Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				GetnMapdvARBNative(target, query, bufSize, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapdvARB(GLMapTarget target, GLMapQuery query, int bufSize, ref double v)
		{
			fixed (double* pv0 = &v)
			{
				GetnMapdvARBNative(target, query, bufSize, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnMapfvARBNative(GLMapTarget target, GLMapQuery query, int bufSize, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLMapTarget, GLMapQuery, int, float*, void>)funcTable[6])(target, query, bufSize, v);
			#else
			((delegate* unmanaged[Cdecl]<GLMapTarget, GLMapQuery, int, nint, void>)funcTable[6])(target, query, bufSize, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapfvARB(GLMapTarget target, GLMapQuery query, int bufSize, float* v)
		{
			GetnMapfvARBNative(target, query, bufSize, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapfvARB(GLMapTarget target, GLMapQuery query, int bufSize, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				GetnMapfvARBNative(target, query, bufSize, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapfvARB(GLMapTarget target, GLMapQuery query, int bufSize, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				GetnMapfvARBNative(target, query, bufSize, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnMapivARBNative(GLMapTarget target, GLMapQuery query, int bufSize, int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLMapTarget, GLMapQuery, int, int*, void>)funcTable[7])(target, query, bufSize, v);
			#else
			((delegate* unmanaged[Cdecl]<GLMapTarget, GLMapQuery, int, nint, void>)funcTable[7])(target, query, bufSize, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapivARB(GLMapTarget target, GLMapQuery query, int bufSize, int* v)
		{
			GetnMapivARBNative(target, query, bufSize, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapivARB(GLMapTarget target, GLMapQuery query, int bufSize, Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				GetnMapivARBNative(target, query, bufSize, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMapivARB(GLMapTarget target, GLMapQuery query, int bufSize, ref int v)
		{
			fixed (int* pv0 = &v)
			{
				GetnMapivARBNative(target, query, bufSize, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnMinmaxARBNative(GLMinmaxTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, void* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLMinmaxTargetEXT, byte, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[8])(target, *((byte*)(&reset)), format, type, bufSize, values);
			#else
			((delegate* unmanaged[Cdecl]<GLMinmaxTargetEXT, byte, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[8])(target, *((byte*)(&reset)), format, type, bufSize, (nint)values);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMinmaxARB(GLMinmaxTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, void* values)
		{
			GetnMinmaxARBNative(target, reset, format, type, bufSize, values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMinmaxARB(GLMinmaxTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, nint values)
		{
			GetnMinmaxARBNative(target, reset, format, type, bufSize, (void*)values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnMinmaxARB<TValues>(GLMinmaxTargetEXT target, bool reset, GLPixelFormat format, GLPixelType type, int bufSize, Span<TValues> values) where TValues : unmanaged
		{
			fixed (TValues* pvalues0 = values)
			{
				GetnMinmaxARBNative(target, reset, format, type, bufSize, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnPixelMapfvARBNative(GLPixelMap map, int bufSize, float* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelMap, int, float*, void>)funcTable[9])(map, bufSize, values);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelMap, int, nint, void>)funcTable[9])(map, bufSize, (nint)values);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapfvARB(GLPixelMap map, int bufSize, float* values)
		{
			GetnPixelMapfvARBNative(map, bufSize, values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapfvARB(GLPixelMap map, int bufSize, Span<float> values)
		{
			fixed (float* pvalues0 = values)
			{
				GetnPixelMapfvARBNative(map, bufSize, pvalues0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapfvARB(GLPixelMap map, int bufSize, ref float values)
		{
			fixed (float* pvalues0 = &values)
			{
				GetnPixelMapfvARBNative(map, bufSize, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnPixelMapuivARBNative(GLPixelMap map, int bufSize, uint* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelMap, int, uint*, void>)funcTable[10])(map, bufSize, values);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelMap, int, nint, void>)funcTable[10])(map, bufSize, (nint)values);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapuivARB(GLPixelMap map, int bufSize, uint* values)
		{
			GetnPixelMapuivARBNative(map, bufSize, values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapuivARB(GLPixelMap map, int bufSize, Span<uint> values)
		{
			fixed (uint* pvalues0 = values)
			{
				GetnPixelMapuivARBNative(map, bufSize, pvalues0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapuivARB(GLPixelMap map, int bufSize, ref uint values)
		{
			fixed (uint* pvalues0 = &values)
			{
				GetnPixelMapuivARBNative(map, bufSize, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnPixelMapusvARBNative(GLPixelMap map, int bufSize, ushort* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelMap, int, ushort*, void>)funcTable[11])(map, bufSize, values);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelMap, int, nint, void>)funcTable[11])(map, bufSize, (nint)values);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapusvARB(GLPixelMap map, int bufSize, ushort* values)
		{
			GetnPixelMapusvARBNative(map, bufSize, values);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapusvARB(GLPixelMap map, int bufSize, Span<ushort> values)
		{
			fixed (ushort* pvalues0 = values)
			{
				GetnPixelMapusvARBNative(map, bufSize, pvalues0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPixelMapusvARB(GLPixelMap map, int bufSize, ref ushort values)
		{
			fixed (ushort* pvalues0 = &values)
			{
				GetnPixelMapusvARBNative(map, bufSize, pvalues0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnPolygonStippleARBNative(int bufSize, byte* pattern)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, void>)funcTable[12])(bufSize, pattern);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[12])(bufSize, (nint)pattern);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPolygonStippleARB(int bufSize, byte* pattern)
		{
			GetnPolygonStippleARBNative(bufSize, pattern);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPolygonStippleARB(int bufSize, string pattern)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (pattern != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(pattern);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(pattern, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetnPolygonStippleARBNative(bufSize, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPolygonStippleARB(int bufSize, Span<byte> pattern)
		{
			fixed (byte* ppattern0 = pattern)
			{
				GetnPolygonStippleARBNative(bufSize, ppattern0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnPolygonStippleARB(int bufSize, ref byte pattern)
		{
			fixed (byte* ppattern0 = &pattern)
			{
				GetnPolygonStippleARBNative(bufSize, ppattern0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnSeparableFilterARBNative(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, void* column, void* span)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSeparableTargetEXT, GLPixelFormat, GLPixelType, int, void*, int, void*, void*, void>)funcTable[13])(target, format, type, rowBufSize, row, columnBufSize, column, span);
			#else
			((delegate* unmanaged[Cdecl]<GLSeparableTargetEXT, GLPixelFormat, GLPixelType, int, nint, int, nint, nint, void>)funcTable[13])(target, format, type, rowBufSize, (nint)row, columnBufSize, (nint)column, (nint)span);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, void* column, void* span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, row, columnBufSize, column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, nint row, int columnBufSize, void* column, void* span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, (void*)row, columnBufSize, column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB<TRow>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, Span<TRow> row, int columnBufSize, void* column, void* span) where TRow : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				GetnSeparableFilterARBNative(target, format, type, rowBufSize, prow0, columnBufSize, column, span);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, nint column, void* span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, row, columnBufSize, (void*)column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB<TColumn>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, Span<TColumn> column, void* span) where TColumn : unmanaged
		{
			fixed (TColumn* pcolumn0 = column)
			{
				GetnSeparableFilterARBNative(target, format, type, rowBufSize, row, columnBufSize, pcolumn0, span);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, nint row, int columnBufSize, nint column, void* span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, (void*)row, columnBufSize, (void*)column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB<TRow, TColumn>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, Span<TRow> row, int columnBufSize, Span<TColumn> column, void* span) where TRow : unmanaged where TColumn : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				fixed (TColumn* pcolumn1 = column)
				{
					GetnSeparableFilterARBNative(target, format, type, rowBufSize, prow0, columnBufSize, pcolumn1, span);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, void* column, nint span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, row, columnBufSize, column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB<TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, void* column, Span<TSpan> span) where TSpan : unmanaged
		{
			fixed (TSpan* pspan0 = span)
			{
				GetnSeparableFilterARBNative(target, format, type, rowBufSize, row, columnBufSize, column, pspan0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, nint row, int columnBufSize, void* column, nint span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, (void*)row, columnBufSize, column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB<TRow, TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, Span<TRow> row, int columnBufSize, void* column, Span<TSpan> span) where TRow : unmanaged where TSpan : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				fixed (TSpan* pspan1 = span)
				{
					GetnSeparableFilterARBNative(target, format, type, rowBufSize, prow0, columnBufSize, column, pspan1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, nint column, nint span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, row, columnBufSize, (void*)column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB<TColumn, TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, void* row, int columnBufSize, Span<TColumn> column, Span<TSpan> span) where TColumn : unmanaged where TSpan : unmanaged
		{
			fixed (TColumn* pcolumn0 = column)
			{
				fixed (TSpan* pspan1 = span)
				{
					GetnSeparableFilterARBNative(target, format, type, rowBufSize, row, columnBufSize, pcolumn0, pspan1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, nint row, int columnBufSize, nint column, nint span)
		{
			GetnSeparableFilterARBNative(target, format, type, rowBufSize, (void*)row, columnBufSize, (void*)column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnSeparableFilterARB<TRow, TColumn, TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, int rowBufSize, Span<TRow> row, int columnBufSize, Span<TColumn> column, Span<TSpan> span) where TRow : unmanaged where TColumn : unmanaged where TSpan : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				fixed (TColumn* pcolumn1 = column)
				{
					fixed (TSpan* pspan2 = span)
					{
						GetnSeparableFilterARBNative(target, format, type, rowBufSize, prow0, columnBufSize, pcolumn1, pspan2);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnTexImageARBNative(GLTextureTarget target, int level, GLPixelFormat format, GLPixelType type, int bufSize, void* img)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[14])(target, level, format, type, bufSize, img);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[14])(target, level, format, type, bufSize, (nint)img);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnTexImageARB(GLTextureTarget target, int level, GLPixelFormat format, GLPixelType type, int bufSize, void* img)
		{
			GetnTexImageARBNative(target, level, format, type, bufSize, img);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnTexImageARB(GLTextureTarget target, int level, GLPixelFormat format, GLPixelType type, int bufSize, nint img)
		{
			GetnTexImageARBNative(target, level, format, type, bufSize, (void*)img);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnTexImageARB<TImg>(GLTextureTarget target, int level, GLPixelFormat format, GLPixelType type, int bufSize, Span<TImg> img) where TImg : unmanaged
		{
			fixed (TImg* pimg0 = img)
			{
				GetnTexImageARBNative(target, level, format, type, bufSize, pimg0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnUniformdvARBNative(uint program, int location, int bufSize, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, double*, void>)funcTable[15])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[15])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformdvARB(uint program, int location, int bufSize, double* @params)
		{
			GetnUniformdvARBNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformdvARB(uint program, int location, int bufSize, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				GetnUniformdvARBNative(program, location, bufSize, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformdvARB(uint program, int location, int bufSize, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				GetnUniformdvARBNative(program, location, bufSize, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnUniformfvARBNative(uint program, int location, int bufSize, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, float*, void>)funcTable[16])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[16])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformfvARB(uint program, int location, int bufSize, float* @params)
		{
			GetnUniformfvARBNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformfvARB(uint program, int location, int bufSize, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				GetnUniformfvARBNative(program, location, bufSize, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformfvARB(uint program, int location, int bufSize, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetnUniformfvARBNative(program, location, bufSize, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnUniformivARBNative(uint program, int location, int bufSize, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int*, void>)funcTable[17])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[17])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformivARB(uint program, int location, int bufSize, int* @params)
		{
			GetnUniformivARBNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformivARB(uint program, int location, int bufSize, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetnUniformivARBNative(program, location, bufSize, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformivARB(uint program, int location, int bufSize, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetnUniformivARBNative(program, location, bufSize, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetnUniformuivARBNative(uint program, int location, int bufSize, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, uint*, void>)funcTable[18])(program, location, bufSize, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, nint, void>)funcTable[18])(program, location, bufSize, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformuivARB(uint program, int location, int bufSize, uint* @params)
		{
			GetnUniformuivARBNative(program, location, bufSize, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformuivARB(uint program, int location, int bufSize, Span<uint> @params)
		{
			fixed (uint* pparams0 = @params)
			{
				GetnUniformuivARBNative(program, location, bufSize, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void GetnUniformuivARB(uint program, int location, int bufSize, ref uint @params)
		{
			fixed (uint* pparams0 = &@params)
			{
				GetnUniformuivARBNative(program, location, bufSize, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ReadnPixelsARBNative(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, GLPixelFormat, GLPixelType, int, void*, void>)funcTable[19])(x, y, width, height, format, type, bufSize, data);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, GLPixelFormat, GLPixelType, int, nint, void>)funcTable[19])(x, y, width, height, format, type, bufSize, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void ReadnPixelsARB(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, void* data)
		{
			ReadnPixelsARBNative(x, y, width, height, format, type, bufSize, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void ReadnPixelsARB(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, nint data)
		{
			ReadnPixelsARBNative(x, y, width, height, format, type, bufSize, (void*)data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_robustness</remarks>
		public void ReadnPixelsARB<TData>(int x, int y, int width, int height, GLPixelFormat format, GLPixelType type, int bufSize, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				ReadnPixelsARBNative(x, y, width, height, format, type, bufSize, pdata0);
			}
		}

	}
}
