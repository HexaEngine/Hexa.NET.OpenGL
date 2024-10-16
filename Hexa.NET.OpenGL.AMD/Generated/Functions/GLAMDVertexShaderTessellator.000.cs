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

namespace Hexa.NET.OpenGL.AMD
{
	public static unsafe partial class GLAMDVertexShaderTessellator
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TessellationFactorAMDNative(float factor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[0])(factor);
			#else
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[0])(factor);
			#endif
		}

		public static void TessellationFactorAMD(float factor)
		{
			TessellationFactorAMDNative(factor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TessellationModeAMDNative(GLEnum mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[1])(mode);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[1])(mode);
			#endif
		}

		public static void TessellationModeAMD(GLEnum mode)
		{
			TessellationModeAMDNative(mode);
		}

	}
}