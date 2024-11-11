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

namespace Hexa.NET.OpenGL.NV
{
	public unsafe partial class GLNVXConditionalRender
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BeginConditionalRenderNVXNative(uint id)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(id);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(id);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NVX_conditional_render</remarks>
		public void BeginConditionalRenderNVX(uint id)
		{
			BeginConditionalRenderNVXNative(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EndConditionalRenderNVXNative()
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
		/// <remarks>Used by Extensions:<br/>GL_NVX_conditional_render</remarks>
		public void EndConditionalRenderNVX()
		{
			EndConditionalRenderNVXNative();
		}

	}
}
