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
	public static unsafe partial class GLEXTBlendMinmax
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BlendEquationEXTNative(GLBlendEquationModeEXT mode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBlendEquationModeEXT, void>)funcTable[0])(mode);
			#else
			((delegate* unmanaged[Cdecl]<GLBlendEquationModeEXT, void>)funcTable[0])(mode);
			#endif
		}

		public static void BlendEquationEXT(GLBlendEquationModeEXT mode)
		{
			BlendEquationEXTNative(mode);
		}

	}
}
