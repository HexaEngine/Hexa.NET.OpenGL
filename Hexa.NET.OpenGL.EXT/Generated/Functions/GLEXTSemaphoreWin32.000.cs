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
	public static unsafe partial class GLEXTSemaphoreWin32
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ImportSemaphoreWin32HandleEXTNative(uint semaphore, GLExternalHandleType handleType, void* handle)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLExternalHandleType, void*, void>)funcTable[0])(semaphore, handleType, handle);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLExternalHandleType, nint, void>)funcTable[0])(semaphore, handleType, (nint)handle);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_semaphore_win32</remarks>
		public static void ImportSemaphoreWin32HandleEXT(uint semaphore, GLExternalHandleType handleType, void* handle)
		{
			ImportSemaphoreWin32HandleEXTNative(semaphore, handleType, handle);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_semaphore_win32</remarks>
		public static void ImportSemaphoreWin32HandleEXT(uint semaphore, GLExternalHandleType handleType, nint handle)
		{
			ImportSemaphoreWin32HandleEXTNative(semaphore, handleType, (void*)handle);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_semaphore_win32</remarks>
		public static void ImportSemaphoreWin32HandleEXT<THandle>(uint semaphore, GLExternalHandleType handleType, Span<THandle> handle) where THandle : unmanaged
		{
			fixed (THandle* phandle0 = handle)
			{
				ImportSemaphoreWin32HandleEXTNative(semaphore, handleType, phandle0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ImportSemaphoreWin32NameEXTNative(uint semaphore, GLExternalHandleType handleType, void* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLExternalHandleType, void*, void>)funcTable[1])(semaphore, handleType, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLExternalHandleType, nint, void>)funcTable[1])(semaphore, handleType, (nint)name);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_semaphore_win32</remarks>
		public static void ImportSemaphoreWin32NameEXT(uint semaphore, GLExternalHandleType handleType, void* name)
		{
			ImportSemaphoreWin32NameEXTNative(semaphore, handleType, name);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_semaphore_win32</remarks>
		public static void ImportSemaphoreWin32NameEXT(uint semaphore, GLExternalHandleType handleType, nint name)
		{
			ImportSemaphoreWin32NameEXTNative(semaphore, handleType, (void*)name);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_semaphore_win32</remarks>
		public static void ImportSemaphoreWin32NameEXT<TName>(uint semaphore, GLExternalHandleType handleType, Span<TName> name) where TName : unmanaged
		{
			fixed (TName* pname0 = name)
			{
				ImportSemaphoreWin32NameEXTNative(semaphore, handleType, pname0);
			}
		}

	}
}
