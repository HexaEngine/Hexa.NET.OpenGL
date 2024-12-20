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
	public unsafe partial class GLEXTPalettedTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ColorTableEXTNative(GLColorTableTarget target, GLInternalFormat internalFormat, int width, GLPixelFormat format, GLPixelType type, void* table)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLInternalFormat, int, GLPixelFormat, GLPixelType, void*, void>)funcTable[0])(target, internalFormat, width, format, type, table);
			#else
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLInternalFormat, int, GLPixelFormat, GLPixelType, nint, void>)funcTable[0])(target, internalFormat, width, format, type, (nint)table);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void ColorTableEXT(GLColorTableTarget target, GLInternalFormat internalFormat, int width, GLPixelFormat format, GLPixelType type, void* table)
		{
			ColorTableEXTNative(target, internalFormat, width, format, type, table);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void ColorTableEXT(GLColorTableTarget target, GLInternalFormat internalFormat, int width, GLPixelFormat format, GLPixelType type, nint table)
		{
			ColorTableEXTNative(target, internalFormat, width, format, type, (void*)table);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void ColorTableEXT<TTable>(GLColorTableTarget target, GLInternalFormat internalFormat, int width, GLPixelFormat format, GLPixelType type, Span<TTable> table) where TTable : unmanaged
		{
			fixed (TTable* ptable0 = table)
			{
				ColorTableEXTNative(target, internalFormat, width, format, type, ptable0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetColorTableEXTNative(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLPixelFormat, GLPixelType, void*, void>)funcTable[1])(target, format, type, data);
			#else
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLPixelFormat, GLPixelType, nint, void>)funcTable[1])(target, format, type, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableEXT(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, void* data)
		{
			GetColorTableEXTNative(target, format, type, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableEXT(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, nint data)
		{
			GetColorTableEXTNative(target, format, type, (void*)data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableEXT<TData>(GLColorTableTarget target, GLPixelFormat format, GLPixelType type, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				GetColorTableEXTNative(target, format, type, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetColorTableParameterfvEXTNative(GLColorTableTarget target, GLColorTableParameterPName pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLColorTableParameterPName, float*, void>)funcTable[2])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLColorTableParameterPName, nint, void>)funcTable[2])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableParameterfvEXT(GLColorTableTarget target, GLColorTableParameterPName pname, float* @params)
		{
			GetColorTableParameterfvEXTNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableParameterfvEXT(GLColorTableTarget target, GLColorTableParameterPName pname, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				GetColorTableParameterfvEXTNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableParameterfvEXT(GLColorTableTarget target, GLColorTableParameterPName pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetColorTableParameterfvEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetColorTableParameterivEXTNative(GLColorTableTarget target, GLColorTableParameterPName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLColorTableParameterPName, int*, void>)funcTable[3])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLColorTableTarget, GLColorTableParameterPName, nint, void>)funcTable[3])(target, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableParameterivEXT(GLColorTableTarget target, GLColorTableParameterPName pname, int* @params)
		{
			GetColorTableParameterivEXTNative(target, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableParameterivEXT(GLColorTableTarget target, GLColorTableParameterPName pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetColorTableParameterivEXTNative(target, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_paletted_texture</remarks>
		public void GetColorTableParameterivEXT(GLColorTableTarget target, GLColorTableParameterPName pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetColorTableParameterivEXTNative(target, pname, pparams0);
			}
		}

	}
}
