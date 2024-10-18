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

namespace Hexa.NET.OpenGL.NV
{
	public static unsafe partial class GLNVCopyImage
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyImageSubDataNVNative(uint srcName, GLCopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLCopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLCopyBufferSubDataTarget, int, int, int, int, uint, GLCopyBufferSubDataTarget, int, int, int, int, int, int, int, void>)funcTable[0])(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLCopyBufferSubDataTarget, int, int, int, int, uint, GLCopyBufferSubDataTarget, int, int, int, int, int, int, int, void>)funcTable[0])(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_copy_image</remarks>
		public static void CopyImageSubDataNV(uint srcName, GLCopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLCopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
		{
			CopyImageSubDataNVNative(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
		}

	}
}
