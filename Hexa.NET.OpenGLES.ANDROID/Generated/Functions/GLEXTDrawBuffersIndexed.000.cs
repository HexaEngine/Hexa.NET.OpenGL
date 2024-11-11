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

namespace Hexa.NET.OpenGLES.ANDROID
{
	public unsafe partial class GLEXTDrawBuffersIndexed
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendEquationSeparateiEXTNative(uint buf, GLBlendEquationModeEXT modeRGB, GLBlendEquationModeEXT modeAlpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, GLBlendEquationModeEXT, void>)funcTable[0])(buf, modeRGB, modeAlpha);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, GLBlendEquationModeEXT, void>)funcTable[0])(buf, modeRGB, modeAlpha);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public void BlendEquationSeparateiEXT(uint buf, GLBlendEquationModeEXT modeRGB, GLBlendEquationModeEXT modeAlpha)
		{
			BlendEquationSeparateiEXTNative(buf, modeRGB, modeAlpha);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendEquationiEXTNative(uint buf, GLBlendEquationModeEXT mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, void>)funcTable[1])(buf, mode);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, void>)funcTable[1])(buf, mode);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public void BlendEquationiEXT(uint buf, GLBlendEquationModeEXT mode)
		{
			BlendEquationiEXTNative(buf, mode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendFuncSeparateiEXTNative(uint buf, GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[2])(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[2])(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public void BlendFuncSeparateiEXT(uint buf, GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
		{
			BlendFuncSeparateiEXTNative(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendFunciEXTNative(uint buf, GLBlendingFactor src, GLBlendingFactor dst)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBlendingFactor, GLBlendingFactor, void>)funcTable[3])(buf, src, dst);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBlendingFactor, GLBlendingFactor, void>)funcTable[3])(buf, src, dst);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public void BlendFunciEXT(uint buf, GLBlendingFactor src, GLBlendingFactor dst)
		{
			BlendFunciEXTNative(buf, src, dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ColorMaskiEXTNative(uint index, bool r, bool g, bool b, bool a)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, byte, byte, byte, byte, void>)funcTable[4])(index, *((byte*)(&r)), *((byte*)(&g)), *((byte*)(&b)), *((byte*)(&a)));
			#else
			((delegate* unmanaged[Cdecl]<uint, byte, byte, byte, byte, void>)funcTable[4])(index, *((byte*)(&r)), *((byte*)(&g)), *((byte*)(&b)), *((byte*)(&a)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public void ColorMaskiEXT(uint index, bool r, bool g, bool b, bool a)
		{
			ColorMaskiEXTNative(index, r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DisableiEXTNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[5])(target, index);
			#else
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[5])(target, index);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public void DisableiEXT(GLEnableCap target, uint index)
		{
			DisableiEXTNative(target, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EnableiEXTNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[6])(target, index);
			#else
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[6])(target, index);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public void EnableiEXT(GLEnableCap target, uint index)
		{
			EnableiEXTNative(target, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsEnablediEXTNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnableCap, uint, byte>)funcTable[7])(target, index);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<GLEnableCap, uint, byte>)funcTable[7])(target, index);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_draw_buffers_indexed</remarks>
		public bool IsEnablediEXT(GLEnableCap target, uint index)
		{
			byte ret = IsEnablediEXTNative(target, index);
			return ret != 0;
		}

	}
}
