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
	public static unsafe partial class GLNVMemoryAttachment
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BufferAttachMemoryNVNative(GLBufferTargetARB target, uint memory, ulong offset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, ulong, void>)funcTable[0])(target, memory, offset);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, ulong, void>)funcTable[0])(target, memory, offset);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void BufferAttachMemoryNV(GLBufferTargetARB target, uint memory, ulong offset)
		{
			BufferAttachMemoryNVNative(target, memory, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetMemoryObjectDetachedResourcesuivNVNative(uint memory, GLEnum pname, int first, int count, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, int, uint*, void>)funcTable[1])(memory, pname, first, count, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, int, nint, void>)funcTable[1])(memory, pname, first, count, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, GLEnum pname, int first, int count, uint* @params)
		{
			GetMemoryObjectDetachedResourcesuivNVNative(memory, pname, first, count, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, GLEnum pname, int first, int count, Span<uint> @params)
		{
			fixed (uint* pparams0 = @params)
			{
				GetMemoryObjectDetachedResourcesuivNVNative(memory, pname, first, count, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, GLEnum pname, int first, int count, ref uint @params)
		{
			fixed (uint* pparams0 = &@params)
			{
				GetMemoryObjectDetachedResourcesuivNVNative(memory, pname, first, count, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NamedBufferAttachMemoryNVNative(uint buffer, uint memory, ulong offset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, ulong, void>)funcTable[2])(buffer, memory, offset);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, ulong, void>)funcTable[2])(buffer, memory, offset);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void NamedBufferAttachMemoryNV(uint buffer, uint memory, ulong offset)
		{
			NamedBufferAttachMemoryNVNative(buffer, memory, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ResetMemoryObjectParameterNVNative(uint memory, GLEnum pname)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[3])(memory, pname);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, void>)funcTable[3])(memory, pname);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void ResetMemoryObjectParameterNV(uint memory, GLEnum pname)
		{
			ResetMemoryObjectParameterNVNative(memory, pname);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TexAttachMemoryNVNative(GLTextureTarget target, uint memory, ulong offset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLTextureTarget, uint, ulong, void>)funcTable[4])(target, memory, offset);
			#else
			((delegate* unmanaged[Cdecl]<GLTextureTarget, uint, ulong, void>)funcTable[4])(target, memory, offset);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void TexAttachMemoryNV(GLTextureTarget target, uint memory, ulong offset)
		{
			TexAttachMemoryNVNative(target, memory, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TextureAttachMemoryNVNative(uint texture, uint memory, ulong offset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, ulong, void>)funcTable[5])(texture, memory, offset);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, ulong, void>)funcTable[5])(texture, memory, offset);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_memory_attachment</remarks>
		public static void TextureAttachMemoryNV(uint texture, uint memory, ulong offset)
		{
			TextureAttachMemoryNVNative(texture, memory, offset);
		}

	}
}
