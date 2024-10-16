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

namespace Hexa.NET.OpenGLES.OES
{
	public static unsafe partial class GLOESBlendFuncSeparate
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BlendFuncSeparateOESNative(GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[0])(srcRGB, dstRGB, srcAlpha, dstAlpha);
			#else
			((delegate* unmanaged[Cdecl]<GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[0])(srcRGB, dstRGB, srcAlpha, dstAlpha);
			#endif
		}

		public static void BlendFuncSeparateOES(GLBlendingFactor srcRGB, GLBlendingFactor dstRGB, GLBlendingFactor srcAlpha, GLBlendingFactor dstAlpha)
		{
			BlendFuncSeparateOESNative(srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

	}
}