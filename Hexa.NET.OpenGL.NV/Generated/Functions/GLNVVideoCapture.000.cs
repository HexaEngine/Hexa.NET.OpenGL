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
	public unsafe partial class GLNVVideoCapture
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BeginVideoCaptureNVNative(uint videoCaptureSlot)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(videoCaptureSlot);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(videoCaptureSlot);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void BeginVideoCaptureNV(uint videoCaptureSlot)
		{
			BeginVideoCaptureNVNative(videoCaptureSlot);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindVideoCaptureStreamBufferNVNative(uint videoCaptureSlot, uint stream, GLEnum frameRegion, nint offset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[1])(videoCaptureSlot, stream, frameRegion, offset);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[1])(videoCaptureSlot, stream, frameRegion, offset);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void BindVideoCaptureStreamBufferNV(uint videoCaptureSlot, uint stream, GLEnum frameRegion, nint offset)
		{
			BindVideoCaptureStreamBufferNVNative(videoCaptureSlot, stream, frameRegion, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindVideoCaptureStreamTextureNVNative(uint videoCaptureSlot, uint stream, GLEnum frameRegion, GLEnum target, uint texture)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, GLEnum, uint, void>)funcTable[2])(videoCaptureSlot, stream, frameRegion, target, texture);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, GLEnum, uint, void>)funcTable[2])(videoCaptureSlot, stream, frameRegion, target, texture);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void BindVideoCaptureStreamTextureNV(uint videoCaptureSlot, uint stream, GLEnum frameRegion, GLEnum target, uint texture)
		{
			BindVideoCaptureStreamTextureNVNative(videoCaptureSlot, stream, frameRegion, target, texture);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EndVideoCaptureNVNative(uint videoCaptureSlot)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[3])(videoCaptureSlot);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[3])(videoCaptureSlot);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void EndVideoCaptureNV(uint videoCaptureSlot)
		{
			EndVideoCaptureNVNative(videoCaptureSlot);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideoCaptureStreamdvNVNative(uint videoCaptureSlot, uint stream, GLEnum pname, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, double*, void>)funcTable[4])(videoCaptureSlot, stream, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[4])(videoCaptureSlot, stream, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamdvNV(uint videoCaptureSlot, uint stream, GLEnum pname, double* @params)
		{
			GetVideoCaptureStreamdvNVNative(videoCaptureSlot, stream, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamdvNV(uint videoCaptureSlot, uint stream, GLEnum pname, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				GetVideoCaptureStreamdvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamdvNV(uint videoCaptureSlot, uint stream, GLEnum pname, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				GetVideoCaptureStreamdvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideoCaptureStreamfvNVNative(uint videoCaptureSlot, uint stream, GLEnum pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, float*, void>)funcTable[5])(videoCaptureSlot, stream, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[5])(videoCaptureSlot, stream, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamfvNV(uint videoCaptureSlot, uint stream, GLEnum pname, float* @params)
		{
			GetVideoCaptureStreamfvNVNative(videoCaptureSlot, stream, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamfvNV(uint videoCaptureSlot, uint stream, GLEnum pname, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				GetVideoCaptureStreamfvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamfvNV(uint videoCaptureSlot, uint stream, GLEnum pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetVideoCaptureStreamfvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideoCaptureStreamivNVNative(uint videoCaptureSlot, uint stream, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, int*, void>)funcTable[6])(videoCaptureSlot, stream, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[6])(videoCaptureSlot, stream, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamivNV(uint videoCaptureSlot, uint stream, GLEnum pname, int* @params)
		{
			GetVideoCaptureStreamivNVNative(videoCaptureSlot, stream, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamivNV(uint videoCaptureSlot, uint stream, GLEnum pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetVideoCaptureStreamivNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureStreamivNV(uint videoCaptureSlot, uint stream, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetVideoCaptureStreamivNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideoCaptureivNVNative(uint videoCaptureSlot, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int*, void>)funcTable[7])(videoCaptureSlot, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, void>)funcTable[7])(videoCaptureSlot, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureivNV(uint videoCaptureSlot, GLEnum pname, int* @params)
		{
			GetVideoCaptureivNVNative(videoCaptureSlot, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureivNV(uint videoCaptureSlot, GLEnum pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetVideoCaptureivNVNative(videoCaptureSlot, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void GetVideoCaptureivNV(uint videoCaptureSlot, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetVideoCaptureivNVNative(videoCaptureSlot, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal GLEnum VideoCaptureNVNative(uint videoCaptureSlot, uint* sequenceNum, ulong* captureTime)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, uint*, ulong*, GLEnum>)funcTable[8])(videoCaptureSlot, sequenceNum, captureTime);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<uint, nint, nint, GLEnum>)funcTable[8])(videoCaptureSlot, (nint)sequenceNum, (nint)captureTime);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public GLEnum VideoCaptureNV(uint videoCaptureSlot, uint* sequenceNum, ulong* captureTime)
		{
			GLEnum ret = VideoCaptureNVNative(videoCaptureSlot, sequenceNum, captureTime);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public GLEnum VideoCaptureNV(uint videoCaptureSlot, Span<uint> sequenceNum, ulong* captureTime)
		{
			fixed (uint* psequenceNum0 = sequenceNum)
			{
				GLEnum ret = VideoCaptureNVNative(videoCaptureSlot, psequenceNum0, captureTime);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public GLEnum VideoCaptureNV(uint videoCaptureSlot, ref uint sequenceNum, ulong* captureTime)
		{
			fixed (uint* psequenceNum0 = &sequenceNum)
			{
				GLEnum ret = VideoCaptureNVNative(videoCaptureSlot, psequenceNum0, captureTime);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public GLEnum VideoCaptureNV(uint videoCaptureSlot, uint* sequenceNum, Span<ulong> captureTime)
		{
			fixed (ulong* pcaptureTime0 = captureTime)
			{
				GLEnum ret = VideoCaptureNVNative(videoCaptureSlot, sequenceNum, pcaptureTime0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public GLEnum VideoCaptureNV(uint videoCaptureSlot, uint* sequenceNum, ref ulong captureTime)
		{
			fixed (ulong* pcaptureTime0 = &captureTime)
			{
				GLEnum ret = VideoCaptureNVNative(videoCaptureSlot, sequenceNum, pcaptureTime0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public GLEnum VideoCaptureNV(uint videoCaptureSlot, Span<uint> sequenceNum, Span<ulong> captureTime)
		{
			fixed (uint* psequenceNum0 = sequenceNum)
			{
				fixed (ulong* pcaptureTime1 = captureTime)
				{
					GLEnum ret = VideoCaptureNVNative(videoCaptureSlot, psequenceNum0, pcaptureTime1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public GLEnum VideoCaptureNV(uint videoCaptureSlot, ref uint sequenceNum, ref ulong captureTime)
		{
			fixed (uint* psequenceNum0 = &sequenceNum)
			{
				fixed (ulong* pcaptureTime1 = &captureTime)
				{
					GLEnum ret = VideoCaptureNVNative(videoCaptureSlot, psequenceNum0, pcaptureTime1);
					return ret;
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VideoCaptureStreamParameterdvNVNative(uint videoCaptureSlot, uint stream, GLEnum pname, double* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, double*, void>)funcTable[9])(videoCaptureSlot, stream, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[9])(videoCaptureSlot, stream, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterdvNV(uint videoCaptureSlot, uint stream, GLEnum pname, double* @params)
		{
			VideoCaptureStreamParameterdvNVNative(videoCaptureSlot, stream, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterdvNV(uint videoCaptureSlot, uint stream, GLEnum pname, Span<double> @params)
		{
			fixed (double* pparams0 = @params)
			{
				VideoCaptureStreamParameterdvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterdvNV(uint videoCaptureSlot, uint stream, GLEnum pname, ref double @params)
		{
			fixed (double* pparams0 = &@params)
			{
				VideoCaptureStreamParameterdvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VideoCaptureStreamParameterfvNVNative(uint videoCaptureSlot, uint stream, GLEnum pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, float*, void>)funcTable[10])(videoCaptureSlot, stream, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[10])(videoCaptureSlot, stream, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterfvNV(uint videoCaptureSlot, uint stream, GLEnum pname, float* @params)
		{
			VideoCaptureStreamParameterfvNVNative(videoCaptureSlot, stream, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterfvNV(uint videoCaptureSlot, uint stream, GLEnum pname, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				VideoCaptureStreamParameterfvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterfvNV(uint videoCaptureSlot, uint stream, GLEnum pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				VideoCaptureStreamParameterfvNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VideoCaptureStreamParameterivNVNative(uint videoCaptureSlot, uint stream, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, int*, void>)funcTable[11])(videoCaptureSlot, stream, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[11])(videoCaptureSlot, stream, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterivNV(uint videoCaptureSlot, uint stream, GLEnum pname, int* @params)
		{
			VideoCaptureStreamParameterivNVNative(videoCaptureSlot, stream, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterivNV(uint videoCaptureSlot, uint stream, GLEnum pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				VideoCaptureStreamParameterivNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_video_capture</remarks>
		public void VideoCaptureStreamParameterivNV(uint videoCaptureSlot, uint stream, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				VideoCaptureStreamParameterivNVNative(videoCaptureSlot, stream, pname, pparams0);
			}
		}

	}
}
