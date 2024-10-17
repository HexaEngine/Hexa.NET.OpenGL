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
	public static unsafe partial class GLARBClearTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ClearTexImageNative(uint texture, int level, GLPixelFormat format, GLPixelType type, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, GLPixelFormat, GLPixelType, void*, void>)funcTable[0])(texture, level, format, type, data);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, GLPixelFormat, GLPixelType, nint, void>)funcTable[0])(texture, level, format, type, (nint)data);
			#endif
		}

		public static void ClearTexImage(uint texture, int level, GLPixelFormat format, GLPixelType type, void* data)
		{
			ClearTexImageNative(texture, level, format, type, data);
		}

		public static void ClearTexImage(uint texture, int level, GLPixelFormat format, GLPixelType type, nint data)
		{
			ClearTexImageNative(texture, level, format, type, (void*)data);
		}

		public static void ClearTexImage<TData>(uint texture, int level, GLPixelFormat format, GLPixelType type, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				ClearTexImageNative(texture, level, format, type, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ClearTexSubImageNative(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLPixelFormat format, GLPixelType type, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, int, int, int, GLPixelFormat, GLPixelType, void*, void>)funcTable[1])(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, int, int, int, int, int, int, GLPixelFormat, GLPixelType, nint, void>)funcTable[1])(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (nint)data);
			#endif
		}

		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLPixelFormat format, GLPixelType type, void* data)
		{
			ClearTexSubImageNative(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}

		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLPixelFormat format, GLPixelType type, nint data)
		{
			ClearTexSubImageNative(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (void*)data);
		}

		public static void ClearTexSubImage<TData>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, GLPixelFormat format, GLPixelType type, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				ClearTexSubImageNative(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pdata0);
			}
		}

	}
}
