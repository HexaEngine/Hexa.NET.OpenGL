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
	public static unsafe partial class GLEXTLightTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ApplyTextureEXTNative(GLLightTextureModeEXT mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLLightTextureModeEXT, void>)funcTable[0])(mode);
			#else
			((delegate* unmanaged[Cdecl]<GLLightTextureModeEXT, void>)funcTable[0])(mode);
			#endif
		}

		public static void ApplyTextureEXT(GLLightTextureModeEXT mode)
		{
			ApplyTextureEXTNative(mode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureLightEXTNative(GLLightTexturePNameEXT pname)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLLightTexturePNameEXT, void>)funcTable[1])(pname);
			#else
			((delegate* unmanaged[Cdecl]<GLLightTexturePNameEXT, void>)funcTable[1])(pname);
			#endif
		}

		public static void TextureLightEXT(GLLightTexturePNameEXT pname)
		{
			TextureLightEXTNative(pname);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureMaterialEXTNative(GLTriangleFace face, GLMaterialParameter mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTriangleFace, GLMaterialParameter, void>)funcTable[2])(face, mode);
			#else
			((delegate* unmanaged[Cdecl]<GLTriangleFace, GLMaterialParameter, void>)funcTable[2])(face, mode);
			#endif
		}

		public static void TextureMaterialEXT(GLTriangleFace face, GLMaterialParameter mode)
		{
			TextureMaterialEXTNative(face, mode);
		}

	}
}