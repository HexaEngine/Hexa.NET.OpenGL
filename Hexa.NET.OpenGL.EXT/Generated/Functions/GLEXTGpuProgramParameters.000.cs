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
	public static unsafe partial class GLEXTGpuProgramParameters
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramEnvParameters4fvEXTNative(GLProgramTarget target, uint index, int count, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, int, float*, void>)funcTable[0])(target, index, count, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, int, nint, void>)funcTable[0])(target, index, count, (nint)@params);
			#endif
		}

		public static void ProgramEnvParameters4fvEXT(GLProgramTarget target, uint index, int count, float* @params)
		{
			ProgramEnvParameters4fvEXTNative(target, index, count, @params);
		}

		public static void ProgramEnvParameters4fvEXT(GLProgramTarget target, uint index, int count, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				ProgramEnvParameters4fvEXTNative(target, index, count, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ProgramLocalParameters4fvEXTNative(GLProgramTarget target, uint index, int count, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, int, float*, void>)funcTable[1])(target, index, count, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLProgramTarget, uint, int, nint, void>)funcTable[1])(target, index, count, (nint)@params);
			#endif
		}

		public static void ProgramLocalParameters4fvEXT(GLProgramTarget target, uint index, int count, float* @params)
		{
			ProgramLocalParameters4fvEXTNative(target, index, count, @params);
		}

		public static void ProgramLocalParameters4fvEXT(GLProgramTarget target, uint index, int count, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				ProgramLocalParameters4fvEXTNative(target, index, count, pparams0);
			}
		}

	}
}
