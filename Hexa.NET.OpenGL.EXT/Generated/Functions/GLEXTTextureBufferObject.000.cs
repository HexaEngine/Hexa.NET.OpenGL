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
	public unsafe partial class GLEXTTextureBufferObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexBufferEXTNative(GLTextureTarget target, GLSizedInternalFormat internalformat, uint buffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLSizedInternalFormat, uint, void>)funcTable[0])(target, internalformat, buffer);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, GLSizedInternalFormat, uint, void>)funcTable[0])(target, internalformat, buffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture_buffer_object<br/>GL_EXT_texture_buffer</remarks>
		public void TexBufferEXT(GLTextureTarget target, GLSizedInternalFormat internalformat, uint buffer)
		{
			TexBufferEXTNative(target, internalformat, buffer);
		}

	}
}
