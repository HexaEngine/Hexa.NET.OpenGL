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

namespace Hexa.NET.OpenGL.INTEL
{
	public static unsafe partial class GLINTELMapTexture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void* MapTexture2DINTELNative(uint texture, int level, uint access, int* stride, GLEnum* layout)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, int, uint, int*, GLEnum*, void*>)funcTable[0])(texture, level, access, stride, layout);
			#else
			return (void*)((delegate* unmanaged[Cdecl]<uint, int, uint, nint, nint, nint>)funcTable[0])(texture, level, access, (nint)stride, (nint)layout);
			#endif
		}

		public static void* MapTexture2DINTEL(uint texture, int level, uint access, int* stride, GLEnum* layout)
		{
			void* ret = MapTexture2DINTELNative(texture, level, access, stride, layout);
			return ret;
		}

		public static void* MapTexture2DINTEL(uint texture, int level, uint access, ref int stride, GLEnum* layout)
		{
			fixed (int* pstride0 = &stride)
			{
				void* ret = MapTexture2DINTELNative(texture, level, access, pstride0, layout);
				return ret;
			}
		}

		public static void* MapTexture2DINTEL(uint texture, int level, uint access, int* stride, ref GLEnum layout)
		{
			fixed (GLEnum* playout0 = &layout)
			{
				void* ret = MapTexture2DINTELNative(texture, level, access, stride, playout0);
				return ret;
			}
		}

		public static void* MapTexture2DINTEL(uint texture, int level, uint access, ref int stride, ref GLEnum layout)
		{
			fixed (int* pstride0 = &stride)
			{
				fixed (GLEnum* playout1 = &layout)
				{
					void* ret = MapTexture2DINTELNative(texture, level, access, pstride0, playout1);
					return ret;
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SyncTextureINTELNative(uint texture)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[1])(texture);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[1])(texture);
			#endif
		}

		public static void SyncTextureINTEL(uint texture)
		{
			SyncTextureINTELNative(texture);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void UnmapTexture2DINTELNative(uint texture, int level)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, void>)funcTable[2])(texture, level);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, void>)funcTable[2])(texture, level);
			#endif
		}

		public static void UnmapTexture2DINTEL(uint texture, int level)
		{
			UnmapTexture2DINTELNative(texture, level);
		}

	}
}
