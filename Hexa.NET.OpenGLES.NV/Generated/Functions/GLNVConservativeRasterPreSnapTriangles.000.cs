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
	public static unsafe partial class GLNVConservativeRasterPreSnapTriangles
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ConservativeRasterParameteriNVNative(GLEnum pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[0])(pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, void>)funcTable[0])(pname, param);
			#endif
		}

		public static void ConservativeRasterParameteriNV(GLEnum pname, int param)
		{
			ConservativeRasterParameteriNVNative(pname, param);
		}

	}
}
