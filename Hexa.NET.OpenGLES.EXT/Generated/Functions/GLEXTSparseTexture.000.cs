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
	public unsafe partial class GLEXTSparseTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexPageCommitmentEXTNative(GLEnum target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, int, int, int, int, int, int, byte, void>)funcTable[0])(target, level, xoffset, yoffset, zoffset, width, height, depth, *((byte*)(&commit)));
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, int, int, int, int, int, int, byte, void>)funcTable[0])(target, level, xoffset, yoffset, zoffset, width, height, depth, *((byte*)(&commit)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_sparse_texture</remarks>
		public void TexPageCommitmentEXT(GLEnum target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit)
		{
			TexPageCommitmentEXTNative(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);
		}

	}
}
