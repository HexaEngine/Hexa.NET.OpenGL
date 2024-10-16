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
	public static unsafe partial class GLEXTCopyTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyTexImage1DEXTNative(GLTextureTarget target, int level, GLInternalFormat internalformat, int x, int y, int width, int border)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, void>)funcTable[0])(target, level, internalformat, x, y, width, border);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, void>)funcTable[0])(target, level, internalformat, x, y, width, border);
			#endif
		}

		public static void CopyTexImage1DEXT(GLTextureTarget target, int level, GLInternalFormat internalformat, int x, int y, int width, int border)
		{
			CopyTexImage1DEXTNative(target, level, internalformat, x, y, width, border);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyTexImage2DEXTNative(GLTextureTarget target, int level, GLInternalFormat internalformat, int x, int y, int width, int height, int border)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, int, void>)funcTable[1])(target, level, internalformat, x, y, width, height, border);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLInternalFormat, int, int, int, int, int, void>)funcTable[1])(target, level, internalformat, x, y, width, height, border);
			#endif
		}

		public static void CopyTexImage2DEXT(GLTextureTarget target, int level, GLInternalFormat internalformat, int x, int y, int width, int height, int border)
		{
			CopyTexImage2DEXTNative(target, level, internalformat, x, y, width, height, border);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyTexSubImage1DEXTNative(GLTextureTarget target, int level, int xoffset, int x, int y, int width)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, void>)funcTable[2])(target, level, xoffset, x, y, width);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, void>)funcTable[2])(target, level, xoffset, x, y, width);
			#endif
		}

		public static void CopyTexSubImage1DEXT(GLTextureTarget target, int level, int xoffset, int x, int y, int width)
		{
			CopyTexSubImage1DEXTNative(target, level, xoffset, x, y, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyTexSubImage2DEXTNative(GLTextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, void>)funcTable[3])(target, level, xoffset, yoffset, x, y, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, void>)funcTable[3])(target, level, xoffset, yoffset, x, y, width, height);
			#endif
		}

		public static void CopyTexSubImage2DEXT(GLTextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			CopyTexSubImage2DEXTNative(target, level, xoffset, yoffset, x, y, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyTexSubImage3DEXTNative(GLTextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, int, void>)funcTable[4])(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, int, void>)funcTable[4])(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			#endif
		}

		public static void CopyTexSubImage3DEXT(GLTextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			CopyTexSubImage3DEXTNative(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

	}
}