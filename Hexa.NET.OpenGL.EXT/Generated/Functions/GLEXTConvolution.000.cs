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
	public unsafe partial class GLEXTConvolution
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ConvolutionFilter1DEXTNative(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, GLPixelFormat format, GLPixelType type, void* image)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, GLPixelFormat, GLPixelType, void*, void>)funcTable[0])(target, internalformat, width, format, type, image);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, GLPixelFormat, GLPixelType, nint, void>)funcTable[0])(target, internalformat, width, format, type, (nint)image);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionFilter1DEXT(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, GLPixelFormat format, GLPixelType type, void* image)
		{
			ConvolutionFilter1DEXTNative(target, internalformat, width, format, type, image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionFilter1DEXT(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, GLPixelFormat format, GLPixelType type, nint image)
		{
			ConvolutionFilter1DEXTNative(target, internalformat, width, format, type, (void*)image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionFilter1DEXT<TImage>(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, GLPixelFormat format, GLPixelType type, Span<TImage> image) where TImage : unmanaged
		{
			fixed (TImage* pimage0 = image)
			{
				ConvolutionFilter1DEXTNative(target, internalformat, width, format, type, pimage0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ConvolutionFilter2DEXTNative(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, void* image)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, int, GLPixelFormat, GLPixelType, void*, void>)funcTable[1])(target, internalformat, width, height, format, type, image);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, int, GLPixelFormat, GLPixelType, nint, void>)funcTable[1])(target, internalformat, width, height, format, type, (nint)image);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionFilter2DEXT(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, void* image)
		{
			ConvolutionFilter2DEXTNative(target, internalformat, width, height, format, type, image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionFilter2DEXT(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, nint image)
		{
			ConvolutionFilter2DEXTNative(target, internalformat, width, height, format, type, (void*)image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionFilter2DEXT<TImage>(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, Span<TImage> image) where TImage : unmanaged
		{
			fixed (TImage* pimage0 = image)
			{
				ConvolutionFilter2DEXTNative(target, internalformat, width, height, format, type, pimage0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ConvolutionParameterfEXTNative(GLConvolutionTargetEXT target, GLConvolutionParameter pname, float @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, float, void>)funcTable[2])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, float, void>)funcTable[2])(target, pname, @params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameterfEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, float @params)
		{
			ConvolutionParameterfEXTNative(target, pname, @params);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ConvolutionParameterfvEXTNative(GLConvolutionTargetEXT target, GLConvolutionParameter pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, float*, void>)funcTable[3])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, nint, void>)funcTable[3])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameterfvEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, float* @params)
		{
			ConvolutionParameterfvEXTNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameterfvEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				ConvolutionParameterfvEXTNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameterfvEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				ConvolutionParameterfvEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ConvolutionParameteriEXTNative(GLConvolutionTargetEXT target, GLConvolutionParameter pname, int @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, int, void>)funcTable[4])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, int, void>)funcTable[4])(target, pname, @params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameteriEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, int @params)
		{
			ConvolutionParameteriEXTNative(target, pname, @params);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ConvolutionParameterivEXTNative(GLConvolutionTargetEXT target, GLConvolutionParameter pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, int*, void>)funcTable[5])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, nint, void>)funcTable[5])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameterivEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, int* @params)
		{
			ConvolutionParameterivEXTNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameterivEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				ConvolutionParameterivEXTNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void ConvolutionParameterivEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				ConvolutionParameterivEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void CopyConvolutionFilter1DEXTNative(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int x, int y, int width)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, int, int, void>)funcTable[6])(target, internalformat, x, y, width);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, int, int, void>)funcTable[6])(target, internalformat, x, y, width);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void CopyConvolutionFilter1DEXT(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int x, int y, int width)
		{
			CopyConvolutionFilter1DEXTNative(target, internalformat, x, y, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void CopyConvolutionFilter2DEXTNative(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int x, int y, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, int, int, int, void>)funcTable[7])(target, internalformat, x, y, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLInternalFormat, int, int, int, int, void>)funcTable[7])(target, internalformat, x, y, width, height);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void CopyConvolutionFilter2DEXT(GLConvolutionTargetEXT target, GLInternalFormat internalformat, int x, int y, int width, int height)
		{
			CopyConvolutionFilter2DEXTNative(target, internalformat, x, y, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetConvolutionFilterEXTNative(GLConvolutionTargetEXT target, GLPixelFormat format, GLPixelType type, void* image)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLPixelFormat, GLPixelType, void*, void>)funcTable[8])(target, format, type, image);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLPixelFormat, GLPixelType, nint, void>)funcTable[8])(target, format, type, (nint)image);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionFilterEXT(GLConvolutionTargetEXT target, GLPixelFormat format, GLPixelType type, void* image)
		{
			GetConvolutionFilterEXTNative(target, format, type, image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionFilterEXT(GLConvolutionTargetEXT target, GLPixelFormat format, GLPixelType type, nint image)
		{
			GetConvolutionFilterEXTNative(target, format, type, (void*)image);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionFilterEXT<TImage>(GLConvolutionTargetEXT target, GLPixelFormat format, GLPixelType type, Span<TImage> image) where TImage : unmanaged
		{
			fixed (TImage* pimage0 = image)
			{
				GetConvolutionFilterEXTNative(target, format, type, pimage0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetConvolutionParameterfvEXTNative(GLConvolutionTargetEXT target, GLConvolutionParameter pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, float*, void>)funcTable[9])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, nint, void>)funcTable[9])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionParameterfvEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, float* @params)
		{
			GetConvolutionParameterfvEXTNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionParameterfvEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				GetConvolutionParameterfvEXTNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionParameterfvEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetConvolutionParameterfvEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetConvolutionParameterivEXTNative(GLConvolutionTargetEXT target, GLConvolutionParameter pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, int*, void>)funcTable[10])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLConvolutionTargetEXT, GLConvolutionParameter, nint, void>)funcTable[10])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionParameterivEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, int* @params)
		{
			GetConvolutionParameterivEXTNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionParameterivEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetConvolutionParameterivEXTNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetConvolutionParameterivEXT(GLConvolutionTargetEXT target, GLConvolutionParameter pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetConvolutionParameterivEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetSeparableFilterEXTNative(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, void* column, void* span)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSeparableTargetEXT, GLPixelFormat, GLPixelType, void*, void*, void*, void>)funcTable[11])(target, format, type, row, column, span);
			#else
			((delegate* unmanaged[Cdecl]<GLSeparableTargetEXT, GLPixelFormat, GLPixelType, nint, nint, nint, void>)funcTable[11])(target, format, type, (nint)row, (nint)column, (nint)span);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, void* column, void* span)
		{
			GetSeparableFilterEXTNative(target, format, type, row, column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, nint row, void* column, void* span)
		{
			GetSeparableFilterEXTNative(target, format, type, (void*)row, column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT<TRow>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, Span<TRow> row, void* column, void* span) where TRow : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				GetSeparableFilterEXTNative(target, format, type, prow0, column, span);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, nint column, void* span)
		{
			GetSeparableFilterEXTNative(target, format, type, row, (void*)column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT<TColumn>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, Span<TColumn> column, void* span) where TColumn : unmanaged
		{
			fixed (TColumn* pcolumn0 = column)
			{
				GetSeparableFilterEXTNative(target, format, type, row, pcolumn0, span);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, nint row, nint column, void* span)
		{
			GetSeparableFilterEXTNative(target, format, type, (void*)row, (void*)column, span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT<TRow, TColumn>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, Span<TRow> row, Span<TColumn> column, void* span) where TRow : unmanaged where TColumn : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				fixed (TColumn* pcolumn1 = column)
				{
					GetSeparableFilterEXTNative(target, format, type, prow0, pcolumn1, span);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, void* column, nint span)
		{
			GetSeparableFilterEXTNative(target, format, type, row, column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT<TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, void* column, Span<TSpan> span) where TSpan : unmanaged
		{
			fixed (TSpan* pspan0 = span)
			{
				GetSeparableFilterEXTNative(target, format, type, row, column, pspan0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, nint row, void* column, nint span)
		{
			GetSeparableFilterEXTNative(target, format, type, (void*)row, column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT<TRow, TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, Span<TRow> row, void* column, Span<TSpan> span) where TRow : unmanaged where TSpan : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				fixed (TSpan* pspan1 = span)
				{
					GetSeparableFilterEXTNative(target, format, type, prow0, column, pspan1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, nint column, nint span)
		{
			GetSeparableFilterEXTNative(target, format, type, row, (void*)column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT<TColumn, TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, void* row, Span<TColumn> column, Span<TSpan> span) where TColumn : unmanaged where TSpan : unmanaged
		{
			fixed (TColumn* pcolumn0 = column)
			{
				fixed (TSpan* pspan1 = span)
				{
					GetSeparableFilterEXTNative(target, format, type, row, pcolumn0, pspan1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, nint row, nint column, nint span)
		{
			GetSeparableFilterEXTNative(target, format, type, (void*)row, (void*)column, (void*)span);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void GetSeparableFilterEXT<TRow, TColumn, TSpan>(GLSeparableTargetEXT target, GLPixelFormat format, GLPixelType type, Span<TRow> row, Span<TColumn> column, Span<TSpan> span) where TRow : unmanaged where TColumn : unmanaged where TSpan : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				fixed (TColumn* pcolumn1 = column)
				{
					fixed (TSpan* pspan2 = span)
					{
						GetSeparableFilterEXTNative(target, format, type, prow0, pcolumn1, pspan2);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SeparableFilter2DEXTNative(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, void* row, void* column)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSeparableTargetEXT, GLInternalFormat, int, int, GLPixelFormat, GLPixelType, void*, void*, void>)funcTable[12])(target, internalformat, width, height, format, type, row, column);
			#else
			((delegate* unmanaged[Cdecl]<GLSeparableTargetEXT, GLInternalFormat, int, int, GLPixelFormat, GLPixelType, nint, nint, void>)funcTable[12])(target, internalformat, width, height, format, type, (nint)row, (nint)column);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void SeparableFilter2DEXT(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, void* row, void* column)
		{
			SeparableFilter2DEXTNative(target, internalformat, width, height, format, type, row, column);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void SeparableFilter2DEXT(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, nint row, void* column)
		{
			SeparableFilter2DEXTNative(target, internalformat, width, height, format, type, (void*)row, column);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void SeparableFilter2DEXT<TRow>(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, Span<TRow> row, void* column) where TRow : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				SeparableFilter2DEXTNative(target, internalformat, width, height, format, type, prow0, column);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void SeparableFilter2DEXT(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, void* row, nint column)
		{
			SeparableFilter2DEXTNative(target, internalformat, width, height, format, type, row, (void*)column);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void SeparableFilter2DEXT<TColumn>(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, void* row, Span<TColumn> column) where TColumn : unmanaged
		{
			fixed (TColumn* pcolumn0 = column)
			{
				SeparableFilter2DEXTNative(target, internalformat, width, height, format, type, row, pcolumn0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void SeparableFilter2DEXT(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, nint row, nint column)
		{
			SeparableFilter2DEXTNative(target, internalformat, width, height, format, type, (void*)row, (void*)column);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_convolution</remarks>
		public void SeparableFilter2DEXT<TRow, TColumn>(GLSeparableTargetEXT target, GLInternalFormat internalformat, int width, int height, GLPixelFormat format, GLPixelType type, Span<TRow> row, Span<TColumn> column) where TRow : unmanaged where TColumn : unmanaged
		{
			fixed (TRow* prow0 = row)
			{
				fixed (TColumn* pcolumn1 = column)
				{
					SeparableFilter2DEXTNative(target, internalformat, width, height, format, type, prow0, pcolumn1);
				}
			}
		}

	}
}
