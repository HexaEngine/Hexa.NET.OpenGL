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
	public unsafe partial class GLARBShaderImageLoadStore
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindImageTextureNative(uint unit, uint texture, int level, bool layered, int layer, GLBufferAccessARB access, GLInternalFormat format)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, byte, int, GLBufferAccessARB, GLInternalFormat, void>)funcTable[0])(unit, texture, level, *((byte*)(&layered)), layer, access, format);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, byte, int, GLBufferAccessARB, GLInternalFormat, void>)funcTable[0])(unit, texture, level, *((byte*)(&layered)), layer, access, format);
			#endif
		}

		/// <summary>
		/// Bind a level of a texture to an image unit
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_shader_image_load_store</remarks>
		public void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, GLBufferAccessARB access, GLInternalFormat format)
		{
			BindImageTextureNative(unit, texture, level, layered, layer, access, format);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void MemoryBarrierNative(GLMemoryBarrierMask barriers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLMemoryBarrierMask, void>)funcTable[1])(barriers);
			#else
			((delegate* unmanaged[Cdecl]<GLMemoryBarrierMask, void>)funcTable[1])(barriers);
			#endif
		}

		/// <summary>
		/// Defines a barrier ordering memory transactions
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_shader_image_load_store</remarks>
		public void MemoryBarrier(GLMemoryBarrierMask barriers)
		{
			MemoryBarrierNative(barriers);
		}

	}
}
