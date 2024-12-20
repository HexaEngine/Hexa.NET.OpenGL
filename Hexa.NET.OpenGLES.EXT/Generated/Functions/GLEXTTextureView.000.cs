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

namespace Hexa.NET.OpenGLES.EXT
{
	public unsafe partial class GLEXTTextureView
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TextureViewEXTNative(uint texture, GLTextureTarget target, uint origtexture, GLSizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, uint, GLSizedInternalFormat, uint, uint, uint, uint, void>)funcTable[0])(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLTextureTarget, uint, GLSizedInternalFormat, uint, uint, uint, uint, void>)funcTable[0])(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture_view</remarks>
		public void TextureViewEXT(uint texture, GLTextureTarget target, uint origtexture, GLSizedInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			TextureViewEXTNative(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}

	}
}
