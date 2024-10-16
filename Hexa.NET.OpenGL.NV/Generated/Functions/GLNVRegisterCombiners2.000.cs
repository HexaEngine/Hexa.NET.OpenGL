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

namespace Hexa.NET.OpenGL.NV
{
	public static unsafe partial class GLNVRegisterCombiners2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CombinerStageParameterfvNVNative(GLCombinerStageNV stage, GLCombinerParameterNV pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLCombinerStageNV, GLCombinerParameterNV, float*, void>)funcTable[0])(stage, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLCombinerStageNV, GLCombinerParameterNV, nint, void>)funcTable[0])(stage, pname, (nint)@params);
			#endif
		}

		public static void CombinerStageParameterfvNV(GLCombinerStageNV stage, GLCombinerParameterNV pname, float* @params)
		{
			CombinerStageParameterfvNVNative(stage, pname, @params);
		}

		public static void CombinerStageParameterfvNV(GLCombinerStageNV stage, GLCombinerParameterNV pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				CombinerStageParameterfvNVNative(stage, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetCombinerStageParameterfvNVNative(GLCombinerStageNV stage, GLCombinerParameterNV pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLCombinerStageNV, GLCombinerParameterNV, float*, void>)funcTable[1])(stage, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLCombinerStageNV, GLCombinerParameterNV, nint, void>)funcTable[1])(stage, pname, (nint)@params);
			#endif
		}

		public static void GetCombinerStageParameterfvNV(GLCombinerStageNV stage, GLCombinerParameterNV pname, float* @params)
		{
			GetCombinerStageParameterfvNVNative(stage, pname, @params);
		}

		public static void GetCombinerStageParameterfvNV(GLCombinerStageNV stage, GLCombinerParameterNV pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetCombinerStageParameterfvNVNative(stage, pname, pparams0);
			}
		}

	}
}
