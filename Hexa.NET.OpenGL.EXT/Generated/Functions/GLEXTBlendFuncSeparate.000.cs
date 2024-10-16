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
	public static unsafe partial class GLEXTBlendFuncSeparate
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BlendFuncSeparateEXTNative(GLBlendingFactor sfactorRGB, GLBlendingFactor dfactorRGB, GLBlendingFactor sfactorAlpha, GLBlendingFactor dfactorAlpha)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[0])(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			#else
			((delegate* unmanaged[Cdecl]<GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, GLBlendingFactor, void>)funcTable[0])(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			#endif
		}

		public static void BlendFuncSeparateEXT(GLBlendingFactor sfactorRGB, GLBlendingFactor dfactorRGB, GLBlendingFactor sfactorAlpha, GLBlendingFactor dfactorAlpha)
		{
			BlendFuncSeparateEXTNative(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}

	}
}