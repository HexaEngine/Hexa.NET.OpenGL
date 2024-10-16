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
	public static unsafe partial class GLEXTTextureStorage
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexStorage1DEXTNative(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, void>)funcTable[0])(target, levels, internalformat, width);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, void>)funcTable[0])(target, levels, internalformat, width);
			#endif
		}

		public static void TexStorage1DEXT(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width)
		{
			TexStorage1DEXTNative(target, levels, internalformat, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexStorage2DEXTNative(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, void>)funcTable[1])(target, levels, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, void>)funcTable[1])(target, levels, internalformat, width, height);
			#endif
		}

		public static void TexStorage2DEXT(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height)
		{
			TexStorage2DEXTNative(target, levels, internalformat, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexStorage3DEXTNative(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height, int depth)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, void>)funcTable[2])(target, levels, internalformat, width, height, depth);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, void>)funcTable[2])(target, levels, internalformat, width, height, depth);
			#endif
		}

		public static void TexStorage3DEXT(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height, int depth)
		{
			TexStorage3DEXTNative(target, levels, internalformat, width, height, depth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureStorage1DEXTNative(uint texture, GLEnum target, int levels, GLSizedInternalFormat internalformat, int width)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, GLSizedInternalFormat, int, void>)funcTable[3])(texture, target, levels, internalformat, width);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, GLSizedInternalFormat, int, void>)funcTable[3])(texture, target, levels, internalformat, width);
			#endif
		}

		public static void TextureStorage1DEXT(uint texture, GLEnum target, int levels, GLSizedInternalFormat internalformat, int width)
		{
			TextureStorage1DEXTNative(texture, target, levels, internalformat, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureStorage2DEXTNative(uint texture, GLEnum target, int levels, GLSizedInternalFormat internalformat, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, GLSizedInternalFormat, int, int, void>)funcTable[4])(texture, target, levels, internalformat, width, height);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, GLSizedInternalFormat, int, int, void>)funcTable[4])(texture, target, levels, internalformat, width, height);
			#endif
		}

		public static void TextureStorage2DEXT(uint texture, GLEnum target, int levels, GLSizedInternalFormat internalformat, int width, int height)
		{
			TextureStorage2DEXTNative(texture, target, levels, internalformat, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureStorage3DEXTNative(uint texture, GLEnum target, int levels, GLSizedInternalFormat internalformat, int width, int height, int depth)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, GLSizedInternalFormat, int, int, int, void>)funcTable[5])(texture, target, levels, internalformat, width, height, depth);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, GLSizedInternalFormat, int, int, int, void>)funcTable[5])(texture, target, levels, internalformat, width, height, depth);
			#endif
		}

		public static void TextureStorage3DEXT(uint texture, GLEnum target, int levels, GLSizedInternalFormat internalformat, int width, int height, int depth)
		{
			TextureStorage3DEXTNative(texture, target, levels, internalformat, width, height, depth);
		}

	}
}