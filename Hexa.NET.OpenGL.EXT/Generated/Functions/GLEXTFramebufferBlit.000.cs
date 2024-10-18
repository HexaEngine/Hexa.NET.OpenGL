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
	public static unsafe partial class GLEXTFramebufferBlit
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BlitFramebufferEXTNative(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, GLClearBufferMask mask, GLBlitFramebufferFilter filter)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, int, int, GLClearBufferMask, GLBlitFramebufferFilter, void>)funcTable[0])(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, int, int, int, int, int, GLClearBufferMask, GLBlitFramebufferFilter, void>)funcTable[0])(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_framebuffer_blit</remarks>
		public static void BlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, GLClearBufferMask mask, GLBlitFramebufferFilter filter)
		{
			BlitFramebufferEXTNative(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

	}
}
