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

namespace Hexa.NET.OpenGLES.NV
{
	public unsafe partial class GLNVFramebufferMixedSamples
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void CoverageModulationNVNative(GLEnum components)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[0])(components);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[0])(components);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void CoverageModulationNV(GLEnum components)
		{
			CoverageModulationNVNative(components);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void CoverageModulationTableNVNative(int n, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, float*, void>)funcTable[1])(n, v);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void CoverageModulationTableNV(int n, float* v)
		{
			CoverageModulationTableNVNative(n, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void CoverageModulationTableNV(int n, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				CoverageModulationTableNVNative(n, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void CoverageModulationTableNV(int n, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				CoverageModulationTableNVNative(n, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetCoverageModulationTableNVNative(int bufSize, float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, float*, void>)funcTable[2])(bufSize, v);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(bufSize, (nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void GetCoverageModulationTableNV(int bufSize, float* v)
		{
			GetCoverageModulationTableNVNative(bufSize, v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void GetCoverageModulationTableNV(int bufSize, Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				GetCoverageModulationTableNVNative(bufSize, pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void GetCoverageModulationTableNV(int bufSize, ref float v)
		{
			fixed (float* pv0 = &v)
			{
				GetCoverageModulationTableNVNative(bufSize, pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void RasterSamplesEXTNative(uint samples, bool fixedsamplelocations)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, byte, void>)funcTable[3])(samples, *((byte*)(&fixedsamplelocations)));
			#else
			((delegate* unmanaged[Cdecl]<uint, byte, void>)funcTable[3])(samples, *((byte*)(&fixedsamplelocations)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_raster_multisample<br/>GL_NV_framebuffer_mixed_samples</remarks>
		public void RasterSamplesEXT(uint samples, bool fixedsamplelocations)
		{
			RasterSamplesEXTNative(samples, fixedsamplelocations);
		}

	}
}
