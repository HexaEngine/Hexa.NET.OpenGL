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
	public static unsafe partial class GLEXTTextureStorageCompression
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexStorageAttribs2DEXTNative(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height, GLTexStorageAttribs attribList)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, GLTexStorageAttribs, void>)funcTable[0])(target, levels, internalformat, width, height, attribList);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, GLTexStorageAttribs, void>)funcTable[0])(target, levels, internalformat, width, height, attribList);
			#endif
		}

		public static void TexStorageAttribs2DEXT(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height, GLTexStorageAttribs attribList)
		{
			TexStorageAttribs2DEXTNative(target, levels, internalformat, width, height, attribList);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexStorageAttribs3DEXTNative(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height, int depth, GLTexStorageAttribs attribList)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, GLTexStorageAttribs, void>)funcTable[1])(target, levels, internalformat, width, height, depth, attribList);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, GLSizedInternalFormat, int, int, int, GLTexStorageAttribs, void>)funcTable[1])(target, levels, internalformat, width, height, depth, attribList);
			#endif
		}

		public static void TexStorageAttribs3DEXT(GLTextureTarget target, int levels, GLSizedInternalFormat internalformat, int width, int height, int depth, GLTexStorageAttribs attribList)
		{
			TexStorageAttribs3DEXTNative(target, levels, internalformat, width, height, depth, attribList);
		}

	}
}