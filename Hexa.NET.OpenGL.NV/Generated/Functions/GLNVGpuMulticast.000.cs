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
	public static unsafe partial class GLNVGpuMulticast
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastBarrierNVNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[0])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[0])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastBarrierNV()
		{
			MulticastBarrierNVNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastBlitFramebufferNVNative(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, GLClearBufferMask mask, GLEnum filter)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, int, int, int, int, int, int, int, GLClearBufferMask, GLEnum, void>)funcTable[1])(srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, int, int, int, int, int, int, int, GLClearBufferMask, GLEnum, void>)funcTable[1])(srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastBlitFramebufferNV(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, GLClearBufferMask mask, GLEnum filter)
		{
			MulticastBlitFramebufferNVNative(srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastBufferSubDataNVNative(uint gpuMask, uint buffer, nint offset, nint size, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, nint, nint, void*, void>)funcTable[2])(gpuMask, buffer, offset, size, data);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, nint, nint, nint, void>)funcTable[2])(gpuMask, buffer, offset, size, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, nint offset, nint size, void* data)
		{
			MulticastBufferSubDataNVNative(gpuMask, buffer, offset, size, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastBufferSubDataNV(uint gpuMask, uint buffer, nint offset, nint size, nint data)
		{
			MulticastBufferSubDataNVNative(gpuMask, buffer, offset, size, (void*)data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastBufferSubDataNV<TData>(uint gpuMask, uint buffer, nint offset, nint size, Span<TData> data) where TData : unmanaged
		{
			fixed (TData* pdata0 = data)
			{
				MulticastBufferSubDataNVNative(gpuMask, buffer, offset, size, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastCopyBufferSubDataNVNative(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, nint, nint, nint, void>)funcTable[3])(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, nint, nint, nint, void>)funcTable[3])(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastCopyBufferSubDataNV(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size)
		{
			MulticastCopyBufferSubDataNVNative(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastCopyImageSubDataNVNative(uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, void>)funcTable[4])(srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, GLEnum, int, int, int, int, uint, GLEnum, int, int, int, int, int, int, int, void>)funcTable[4])(srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastCopyImageSubDataNV(uint srcGpu, uint dstGpuMask, uint srcName, GLEnum srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GLEnum dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			MulticastCopyImageSubDataNVNative(srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastFramebufferSampleLocationsfvNVNative(uint gpu, uint framebuffer, uint start, int count, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, int, float*, void>)funcTable[5])(gpu, framebuffer, start, count, v);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, int, nint, void>)funcTable[5])(gpu, framebuffer, start, count, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, int count, float* v)
		{
			MulticastFramebufferSampleLocationsfvNVNative(gpu, framebuffer, start, count, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, int count, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				MulticastFramebufferSampleLocationsfvNVNative(gpu, framebuffer, start, count, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, int count, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				MulticastFramebufferSampleLocationsfvNVNative(gpu, framebuffer, start, count, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastGetQueryObjecti64vNVNative(uint gpu, uint id, GLEnum pname, long* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, long*, void>)funcTable[6])(gpu, id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[6])(gpu, id, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjecti64vNV(uint gpu, uint id, GLEnum pname, long* @params)
		{
			MulticastGetQueryObjecti64vNVNative(gpu, id, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjecti64vNV(uint gpu, uint id, GLEnum pname, out long @params)
		{
			long pparams;
			MulticastGetQueryObjecti64vNVNative(gpu, id, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjecti64vNV(uint gpu, uint id, GLEnum pname, Span<long> @params)
		{
			fixed (long* pparams = @params)
			{
				MulticastGetQueryObjecti64vNVNative(gpu, id, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastGetQueryObjectivNVNative(uint gpu, uint id, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, int*, void>)funcTable[7])(gpu, id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[7])(gpu, id, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectivNV(uint gpu, uint id, GLEnum pname, int* @params)
		{
			MulticastGetQueryObjectivNVNative(gpu, id, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectivNV(uint gpu, uint id, GLEnum pname, out int @params)
		{
			int pparams;
			MulticastGetQueryObjectivNVNative(gpu, id, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectivNV(uint gpu, uint id, GLEnum pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				MulticastGetQueryObjectivNVNative(gpu, id, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastGetQueryObjectui64vNVNative(uint gpu, uint id, GLEnum pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, ulong*, void>)funcTable[8])(gpu, id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[8])(gpu, id, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectui64vNV(uint gpu, uint id, GLEnum pname, ulong* @params)
		{
			MulticastGetQueryObjectui64vNVNative(gpu, id, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectui64vNV(uint gpu, uint id, GLEnum pname, out ulong @params)
		{
			ulong pparams;
			MulticastGetQueryObjectui64vNVNative(gpu, id, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectui64vNV(uint gpu, uint id, GLEnum pname, Span<ulong> @params)
		{
			fixed (ulong* pparams = @params)
			{
				MulticastGetQueryObjectui64vNVNative(gpu, id, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastGetQueryObjectuivNVNative(uint gpu, uint id, GLEnum pname, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, uint*, void>)funcTable[9])(gpu, id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[9])(gpu, id, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectuivNV(uint gpu, uint id, GLEnum pname, uint* @params)
		{
			MulticastGetQueryObjectuivNVNative(gpu, id, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectuivNV(uint gpu, uint id, GLEnum pname, out uint @params)
		{
			uint pparams;
			MulticastGetQueryObjectuivNVNative(gpu, id, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastGetQueryObjectuivNV(uint gpu, uint id, GLEnum pname, Span<uint> @params)
		{
			fixed (uint* pparams = @params)
			{
				MulticastGetQueryObjectuivNVNative(gpu, id, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MulticastWaitSyncNVNative(uint signalGpu, uint waitGpuMask)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[10])(signalGpu, waitGpuMask);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[10])(signalGpu, waitGpuMask);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void MulticastWaitSyncNV(uint signalGpu, uint waitGpuMask)
		{
			MulticastWaitSyncNVNative(signalGpu, waitGpuMask);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void RenderGpuMaskNVNative(uint mask)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[11])(mask);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[11])(mask);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		public static void RenderGpuMaskNV(uint mask)
		{
			RenderGpuMaskNVNative(mask);
		}

	}
}
