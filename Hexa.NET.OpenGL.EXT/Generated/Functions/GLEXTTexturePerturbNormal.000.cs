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
	public unsafe partial class GLEXTTexturePerturbNormal
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TextureNormalEXTNative(GLTextureNormalModeEXT mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureNormalModeEXT, void>)funcTable[0])(mode);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureNormalModeEXT, void>)funcTable[0])(mode);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_texture_perturb_normal</remarks>
		public void TextureNormalEXT(GLTextureNormalModeEXT mode)
		{
			TextureNormalEXTNative(mode);
		}

	}
}
