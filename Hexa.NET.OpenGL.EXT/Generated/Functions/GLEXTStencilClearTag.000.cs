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
	public unsafe partial class GLEXTStencilClearTag
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void StencilClearTagEXTNative(int stencilTagBits, uint stencilClearTag)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint, void>)funcTable[0])(stencilTagBits, stencilClearTag);
			#else
			((delegate* unmanaged[Cdecl]<int, uint, void>)funcTable[0])(stencilTagBits, stencilClearTag);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_stencil_clear_tag</remarks>
		public void StencilClearTagEXT(int stencilTagBits, uint stencilClearTag)
		{
			StencilClearTagEXTNative(stencilTagBits, stencilClearTag);
		}

	}
}
