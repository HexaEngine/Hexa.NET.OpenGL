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
	public static unsafe partial class GLNVCoverageSample
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CoverageMaskNVNative(byte mask)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<byte, void>)funcTable[0])(mask);
			#else
			((delegate* unmanaged[Cdecl]<byte, void>)funcTable[0])(mask);
			#endif
		}

		public static void CoverageMaskNV(byte mask)
		{
			CoverageMaskNVNative(mask);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CoverageOperationNVNative(GLEnum operation)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[1])(operation);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, void>)funcTable[1])(operation);
			#endif
		}

		public static void CoverageOperationNV(GLEnum operation)
		{
			CoverageOperationNVNative(operation);
		}

	}
}