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
	public static unsafe partial class GLNVXLinkedGpuMulticast
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void LGPUCopyImageSubDataNVXNative(uint sourceGpu, uint destinationGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srxY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, void>)funcTable[0])(sourceGpu, destinationGpuMask, srcName, srcTarget, srcLevel, srcX, srxY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, void>)funcTable[0])(sourceGpu, destinationGpuMask, srcName, srcTarget, srcLevel, srcX, srxY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			#endif
		}

		public static void LGPUCopyImageSubDataNVX(uint sourceGpu, uint destinationGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srxY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
		{
			LGPUCopyImageSubDataNVXNative(sourceGpu, destinationGpuMask, srcName, srcTarget, srcLevel, srcX, srxY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void LGPUInterlockNVXNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#endif
		}

		public static void LGPUInterlockNVX()
		{
			LGPUInterlockNVXNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void LGPUNamedBufferSubDataNVXNative(uint gpuMask, uint buffer, nint offset, nint size, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, nint, nint, void*, void>)funcTable[2])(gpuMask, buffer, offset, size, data);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, nint, nint, nint, void>)funcTable[2])(gpuMask, buffer, offset, size, (nint)data);
			#endif
		}

		public static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, nint offset, nint size, void* data)
		{
			LGPUNamedBufferSubDataNVXNative(gpuMask, buffer, offset, size, data);
		}

		public static void LGPUNamedBufferSubDataNVX(uint gpuMask, uint buffer, nint offset, nint size, nint data)
		{
			LGPUNamedBufferSubDataNVXNative(gpuMask, buffer, offset, size, (void*)data);
		}

		public static void LGPUNamedBufferSubDataNVX<TData>(uint gpuMask, uint buffer, nint offset, nint size, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				LGPUNamedBufferSubDataNVXNative(gpuMask, buffer, offset, size, pdata0);
			}
		}

	}
}
