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
	public static unsafe partial class GLARBSampleShading
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MinSampleShadingARBNative(float value)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[0])(value);
			#else
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[0])(value);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_sample_shading</remarks>
		public static void MinSampleShadingARB(float value)
		{
			MinSampleShadingARBNative(value);
		}

	}
}
