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
	public static unsafe partial class GLNVConditionalRender
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BeginConditionalRenderNVNative(uint id, GLConditionalRenderMode mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLConditionalRenderMode, void>)funcTable[0])(id, mode);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLConditionalRenderMode, void>)funcTable[0])(id, mode);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_conditional_render</remarks>
		public static void BeginConditionalRenderNV(uint id, GLConditionalRenderMode mode)
		{
			BeginConditionalRenderNVNative(id, mode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EndConditionalRenderNVNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_conditional_render</remarks>
		public static void EndConditionalRenderNV()
		{
			EndConditionalRenderNVNative();
		}

	}
}
