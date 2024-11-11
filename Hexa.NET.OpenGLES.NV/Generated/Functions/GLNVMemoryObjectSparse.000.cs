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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVMemoryObjectSparse
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BufferPageCommitmentMemNVNative(GLBufferStorageTarget target, nint offset, nint size, uint memory, ulong memOffset, bool commit)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferStorageTarget, nint, nint, uint, ulong, byte, void>)funcTable[0])(target, offset, size, memory, memOffset, *((byte*)(&commit)));
			#else
			((delegate* unmanaged[Cdecl]<GLBufferStorageTarget, nint, nint, uint, ulong, byte, void>)funcTable[0])(target, offset, size, memory, memOffset, *((byte*)(&commit)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_object_sparse</remarks>
		public void BufferPageCommitmentMemNV(GLBufferStorageTarget target, nint offset, nint size, uint memory, ulong memOffset, bool commit)
		{
			BufferPageCommitmentMemNVNative(target, offset, size, memory, memOffset, commit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void NamedBufferPageCommitmentMemNVNative(uint buffer, nint offset, nint size, uint memory, ulong memOffset, bool commit)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, nint, nint, uint, ulong, byte, void>)funcTable[1])(buffer, offset, size, memory, memOffset, *((byte*)(&commit)));
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, nint, uint, ulong, byte, void>)funcTable[1])(buffer, offset, size, memory, memOffset, *((byte*)(&commit)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_object_sparse</remarks>
		public void NamedBufferPageCommitmentMemNV(uint buffer, nint offset, nint size, uint memory, ulong memOffset, bool commit)
		{
			NamedBufferPageCommitmentMemNVNative(buffer, offset, size, memory, memOffset, commit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexPageCommitmentMemNVNative(GLTextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, int, uint, ulong, byte, void>)funcTable[2])(target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, *((byte*)(&commit)));
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, int, int, int, int, int, int, int, int, uint, ulong, byte, void>)funcTable[2])(target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, *((byte*)(&commit)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_object_sparse</remarks>
		public void TexPageCommitmentMemNV(GLTextureTarget target, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit)
		{
			TexPageCommitmentMemNVNative(target, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TexturePageCommitmentMemNVNative(uint texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, int, int, int, int, uint, ulong, byte, void>)funcTable[3])(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, *((byte*)(&commit)));
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, int, int, int, int, uint, ulong, byte, void>)funcTable[3])(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, *((byte*)(&commit)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_object_sparse</remarks>
		public void TexturePageCommitmentMemNV(uint texture, int layer, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint memory, ulong offset, bool commit)
		{
			TexturePageCommitmentMemNVNative(texture, layer, level, xoffset, yoffset, zoffset, width, height, depth, memory, offset, commit);
		}

	}
}
