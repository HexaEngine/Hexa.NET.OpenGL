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

namespace Hexa.NET.OpenGLES.KHR
{
	public unsafe partial class GLKHRBlendEquationAdvanced
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BlendBarrierKHRNative()
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
		/// <remarks>Used by Extensions:<br/>GL_KHR_blend_equation_advanced</remarks>
		public void BlendBarrierKHR()
		{
			BlendBarrierKHRNative();
		}

	}
}
