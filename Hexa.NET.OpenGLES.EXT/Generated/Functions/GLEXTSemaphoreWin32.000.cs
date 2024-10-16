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

		public static void ImportSemaphoreWin32HandleEXT(uint semaphore, GLExternalHandleType handleType, void* handle)
		{
			ImportSemaphoreWin32HandleEXTNative(semaphore, handleType, handle);
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

		public static void ImportSemaphoreWin32NameEXT(uint semaphore, GLExternalHandleType handleType, void* name)
		{
			ImportSemaphoreWin32NameEXTNative(semaphore, handleType, name);
		}

	}
}
