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

namespace Hexa.NET.OpenGL.ARB
{
	public unsafe partial class GLARBBufferStorage
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BufferStorageNative(GLBufferStorageTarget target, nint size, void* data, GLBufferStorageMask flags)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferStorageTarget, nint, void*, GLBufferStorageMask, void>)funcTable[0])(target, size, data, flags);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferStorageTarget, nint, nint, GLBufferStorageMask, void>)funcTable[0])(target, size, (nint)data, flags);
			#endif
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data
		///     store
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage</remarks>
		public void BufferStorage(GLBufferStorageTarget target, nint size, void* data, GLBufferStorageMask flags)
		{
			BufferStorageNative(target, size, data, flags);
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data
		///     store
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage</remarks>
		public void BufferStorage(GLBufferStorageTarget target, nint size, nint data, GLBufferStorageMask flags)
		{
			BufferStorageNative(target, size, (void*)data, flags);
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data
		///     store
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage</remarks>
		public void BufferStorage<TData>(GLBufferStorageTarget target, nint size, Span<TData> data, GLBufferStorageMask flags) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				BufferStorageNative(target, size, pdata0, flags);
			}
		}

	}
}
