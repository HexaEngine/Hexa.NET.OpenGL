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

namespace Hexa.NET.OpenGL.EXT
{
	public unsafe partial class GLEXTMultisample
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SampleMaskEXTNative(float value, bool invert)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, byte, void>)funcTable[0])(value, *((byte*)(&invert)));
			#else
			((delegate* unmanaged[Cdecl]<float, byte, void>)funcTable[0])(value, *((byte*)(&invert)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_multisample</remarks>
		public void SampleMaskEXT(float value, bool invert)
		{
			SampleMaskEXTNative(value, invert);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SamplePatternEXTNative(GLSamplePatternEXT pattern)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSamplePatternEXT, void>)funcTable[1])(pattern);
			#else
			((delegate* unmanaged[Cdecl]<GLSamplePatternEXT, void>)funcTable[1])(pattern);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_multisample</remarks>
		public void SamplePatternEXT(GLSamplePatternEXT pattern)
		{
			SamplePatternEXTNative(pattern);
		}

	}
}
