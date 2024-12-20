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
	public unsafe partial class GLEXTTextureArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferTextureLayerEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int level, int layer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, int, void>)funcTable[0])(target, attachment, texture, level, layer);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, int, void>)funcTable[0])(target, attachment, texture, level, layer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture_array<br/>GL_NV_geometry_program4</remarks>
		public void FramebufferTextureLayerEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int level, int layer)
		{
			FramebufferTextureLayerEXTNative(target, attachment, texture, level, layer);
		}

	}
}
