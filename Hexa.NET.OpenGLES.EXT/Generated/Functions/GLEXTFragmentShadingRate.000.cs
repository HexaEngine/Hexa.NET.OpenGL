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
	public unsafe partial class GLEXTFragmentShadingRate
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void FramebufferShadingRateEXTNative(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int baseLayer, int numLayers, int texelWidth, int texelHeight)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, int, int, int, void>)funcTable[0])(target, attachment, texture, baseLayer, numLayers, texelWidth, texelHeight);
			#else
			((delegate* unmanaged[Cdecl]<GLFramebufferTarget, GLFramebufferAttachment, uint, int, int, int, int, void>)funcTable[0])(target, attachment, texture, baseLayer, numLayers, texelWidth, texelHeight);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_fragment_shading_rate</remarks>
		public void FramebufferShadingRateEXT(GLFramebufferTarget target, GLFramebufferAttachment attachment, uint texture, int baseLayer, int numLayers, int texelWidth, int texelHeight)
		{
			FramebufferShadingRateEXTNative(target, attachment, texture, baseLayer, numLayers, texelWidth, texelHeight);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetFragmentShadingRatesEXTNative(int samples, int maxCount, int* count, GLShadingRate shadingRates)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int*, GLShadingRate, void>)funcTable[1])(samples, maxCount, count, shadingRates);
			#else
			((delegate* unmanaged[Cdecl]<int, int, nint, GLShadingRate, void>)funcTable[1])(samples, maxCount, (nint)count, shadingRates);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_fragment_shading_rate</remarks>
		public void GetFragmentShadingRatesEXT(int samples, int maxCount, int* count, GLShadingRate shadingRates)
		{
			GetFragmentShadingRatesEXTNative(samples, maxCount, count, shadingRates);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_fragment_shading_rate</remarks>
		public void GetFragmentShadingRatesEXT(int samples, int maxCount, Span<int> count, GLShadingRate shadingRates)
		{
			fixed (int* pcount0 = count)
			{
				GetFragmentShadingRatesEXTNative(samples, maxCount, pcount0, shadingRates);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_fragment_shading_rate</remarks>
		public void GetFragmentShadingRatesEXT(int samples, int maxCount, ref int count, GLShadingRate shadingRates)
		{
			fixed (int* pcount0 = &count)
			{
				GetFragmentShadingRatesEXTNative(samples, maxCount, pcount0, shadingRates);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ShadingRateEXTNative(GLShadingRate rate)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLShadingRate, void>)funcTable[2])(rate);
			#else
			((delegate* unmanaged[Cdecl]<GLShadingRate, void>)funcTable[2])(rate);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_fragment_shading_rate</remarks>
		public void ShadingRateEXT(GLShadingRate rate)
		{
			ShadingRateEXTNative(rate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ShadingRateCombinerOpsEXTNative(GLShadingRateCombinerOp combinerOp0, GLShadingRateCombinerOp combinerOp1)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLShadingRateCombinerOp, GLShadingRateCombinerOp, void>)funcTable[3])(combinerOp0, combinerOp1);
			#else
			((delegate* unmanaged[Cdecl]<GLShadingRateCombinerOp, GLShadingRateCombinerOp, void>)funcTable[3])(combinerOp0, combinerOp1);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_fragment_shading_rate</remarks>
		public void ShadingRateCombinerOpsEXT(GLShadingRateCombinerOp combinerOp0, GLShadingRateCombinerOp combinerOp1)
		{
			ShadingRateCombinerOpsEXTNative(combinerOp0, combinerOp1);
		}

	}
}
