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

namespace Hexa.NET.OpenGL.AMD
{
	public unsafe partial class GLAMDDrawBuffersBlend
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendEquationIndexedAMDNative(uint buf, GLBlendEquationModeEXT mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, void>)funcTable[0])(buf, mode);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, void>)funcTable[0])(buf, mode);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_draw_buffers_blend</remarks>
		public void BlendEquationIndexedAMD(uint buf, GLBlendEquationModeEXT mode)
		{
			BlendEquationIndexedAMDNative(buf, mode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendEquationSeparateIndexedAMDNative(uint buf, GLBlendEquationModeEXT modeRGB, GLBlendEquationModeEXT modeAlpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, GLBlendEquationModeEXT, void>)funcTable[1])(buf, modeRGB, modeAlpha);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBlendEquationModeEXT, GLBlendEquationModeEXT, void>)funcTable[1])(buf, modeRGB, modeAlpha);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_draw_buffers_blend</remarks>
		public void BlendEquationSeparateIndexedAMD(uint buf, GLBlendEquationModeEXT modeRGB, GLBlendEquationModeEXT modeAlpha)
		{
			BlendEquationSeparateIndexedAMDNative(buf, modeRGB, modeAlpha);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendFuncIndexedAMDNative(uint buf, GLEnum src, GLEnum dst)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, GLEnum, void>)funcTable[2])(buf, src, dst);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, GLEnum, void>)funcTable[2])(buf, src, dst);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_draw_buffers_blend</remarks>
		public void BlendFuncIndexedAMD(uint buf, GLEnum src, GLEnum dst)
		{
			BlendFuncIndexedAMDNative(buf, src, dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendFuncSeparateIndexedAMDNative(uint buf, GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[3])(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[3])(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_draw_buffers_blend</remarks>
		public void BlendFuncSeparateIndexedAMD(uint buf, GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
		{
			BlendFuncSeparateIndexedAMDNative(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

	}
}
