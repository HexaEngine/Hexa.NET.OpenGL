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
	public unsafe partial class GLNVPresentVideo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideoi64vNVNative(uint videoSlot, GLEnum pname, long* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, long*, void>)funcTable[0])(videoSlot, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, void>)funcTable[0])(videoSlot, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoi64vNV(uint videoSlot, GLEnum pname, long* @params)
		{
			GetVideoi64vNVNative(videoSlot, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoi64vNV(uint videoSlot, GLEnum pname, Span<long> @params)
		{
			fixed (long* pparams0 = @params)
			{
				GetVideoi64vNVNative(videoSlot, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoi64vNV(uint videoSlot, GLEnum pname, ref long @params)
		{
			fixed (long* pparams0 = &@params)
			{
				GetVideoi64vNVNative(videoSlot, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideoivNVNative(uint videoSlot, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int*, void>)funcTable[1])(videoSlot, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, void>)funcTable[1])(videoSlot, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoivNV(uint videoSlot, GLEnum pname, int* @params)
		{
			GetVideoivNVNative(videoSlot, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoivNV(uint videoSlot, GLEnum pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetVideoivNVNative(videoSlot, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoivNV(uint videoSlot, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetVideoivNVNative(videoSlot, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideoui64vNVNative(uint videoSlot, GLEnum pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, ulong*, void>)funcTable[2])(videoSlot, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, void>)funcTable[2])(videoSlot, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoui64vNV(uint videoSlot, GLEnum pname, ulong* @params)
		{
			GetVideoui64vNVNative(videoSlot, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoui64vNV(uint videoSlot, GLEnum pname, Span<ulong> @params)
		{
			fixed (ulong* pparams0 = @params)
			{
				GetVideoui64vNVNative(videoSlot, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideoui64vNV(uint videoSlot, GLEnum pname, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				GetVideoui64vNVNative(videoSlot, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetVideouivNVNative(uint videoSlot, GLEnum pname, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, uint*, void>)funcTable[3])(videoSlot, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, nint, void>)funcTable[3])(videoSlot, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideouivNV(uint videoSlot, GLEnum pname, uint* @params)
		{
			GetVideouivNVNative(videoSlot, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideouivNV(uint videoSlot, GLEnum pname, Span<uint> @params)
		{
			fixed (uint* pparams0 = @params)
			{
				GetVideouivNVNative(videoSlot, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void GetVideouivNV(uint videoSlot, GLEnum pname, ref uint @params)
		{
			fixed (uint* pparams0 = &@params)
			{
				GetVideouivNVNative(videoSlot, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PresentFrameDualFillNVNative(uint videoSlot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, GLEnum type, GLEnum target0, uint fill0, GLEnum target1, uint fill1, GLEnum target2, uint fill2, GLEnum target3, uint fill3)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong, uint, uint, GLEnum, GLEnum, uint, GLEnum, uint, GLEnum, uint, GLEnum, uint, void>)funcTable[4])(videoSlot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
			#else
			((delegate* unmanaged[Cdecl]<uint, ulong, uint, uint, GLEnum, GLEnum, uint, GLEnum, uint, GLEnum, uint, GLEnum, uint, void>)funcTable[4])(videoSlot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void PresentFrameDualFillNV(uint videoSlot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, GLEnum type, GLEnum target0, uint fill0, GLEnum target1, uint fill1, GLEnum target2, uint fill2, GLEnum target3, uint fill3)
		{
			PresentFrameDualFillNVNative(videoSlot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PresentFrameKeyedNVNative(uint videoSlot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, GLEnum type, GLEnum target0, uint fill0, uint key0, GLEnum target1, uint fill1, uint key1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, ulong, uint, uint, GLEnum, GLEnum, uint, uint, GLEnum, uint, uint, void>)funcTable[5])(videoSlot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
			#else
			((delegate* unmanaged[Cdecl]<uint, ulong, uint, uint, GLEnum, GLEnum, uint, uint, GLEnum, uint, uint, void>)funcTable[5])(videoSlot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_present_video</remarks>
		public void PresentFrameKeyedNV(uint videoSlot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, GLEnum type, GLEnum target0, uint fill0, uint key0, GLEnum target1, uint fill1, uint key1)
		{
			PresentFrameKeyedNVNative(videoSlot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
		}

	}
}
