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
	public unsafe partial class GLARBDrawBuffersBlend
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendEquationSeparateiARBNative(uint buf, GLBlendEquationModeEXT modeRGB, GLBlendEquationModeEXT modeAlpha)
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
		/// <remarks>Used by Extensions:<br/>GL_ARB_draw_buffers_blend</remarks>
		public void BlendEquationSeparateiARB(uint buf, GLBlendEquationModeEXT modeRGB, GLBlendEquationModeEXT modeAlpha)
		{
			BlendEquationSeparateiARBNative(buf, modeRGB, modeAlpha);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendEquationiARBNative(uint buf, GLBlendEquationModeEXT mode)
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
		/// <remarks>Used by Extensions:<br/>GL_ARB_draw_buffers_blend</remarks>
		public void BlendEquationiARB(uint buf, GLBlendEquationModeEXT mode)
		{
			BlendEquationiARBNative(buf, mode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendFuncSeparateiARBNative(uint buf, GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
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
		/// <remarks>Used by Extensions:<br/>GL_ARB_draw_buffers_blend</remarks>
		public void BlendFuncSeparateiARB(uint buf, GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
		{
			BlendFuncSeparateiARBNative(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendFunciARBNative(uint buf, GLBlendingFactor src, GLBlendingFactor dst)
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
		/// <remarks>Used by Extensions:<br/>GL_ARB_draw_buffers_blend</remarks>
		public void BlendFunciARB(uint buf, GLBlendingFactor src, GLBlendingFactor dst)
		{
			BlendFunciARBNative(buf, src, dst);
		}

	}
}
