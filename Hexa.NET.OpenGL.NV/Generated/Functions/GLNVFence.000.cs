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
	public static unsafe partial class GLNVFence
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteFencesNVNative(int n, uint* fences)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[0])(n, fences);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[0])(n, (nint)fences);
			#endif
		}

		public static void DeleteFencesNV(int n, uint* fences)
		{
			DeleteFencesNVNative(n, fences);
		}

		public static void DeleteFencesN(uint fence)
		{
			DeleteFencesNVNative(1, &fence);
		}

		public static void DeleteFencesNV(int n, Span<uint> fences)
		{
			fixed (uint* pfences0 = fences)
			{
				DeleteFencesNVNative(n, pfences0);
			}
		}

		public static void DeleteFencesNV(int n, ref uint fences)
		{
			fixed (uint* pfences0 = &fences)
			{
				DeleteFencesNVNative(n, pfences0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void FinishFenceNVNative(uint fence)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[1])(fence);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[1])(fence);
			#endif
		}

		public static void FinishFenceNV(uint fence)
		{
			FinishFenceNVNative(fence);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenFencesNVNative(int n, uint* fences)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(n, fences);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(n, (nint)fences);
			#endif
		}

		public static void GenFencesNV(int n, uint* fences)
		{
			GenFencesNVNative(n, fences);
		}

		public static uint GenFencesN()
		{
			uint result;
			GenFencesNVNative(1, &result);
			return result;
		}

		public static void GenFencesNV(int n, Span<uint> fences)
		{
			fixed (uint* pfences0 = fences)
			{
				GenFencesNVNative(n, pfences0);
			}
		}

		public static void GenFencesNV(int n, ref uint fences)
		{
			fixed (uint* pfences0 = &fences)
			{
				GenFencesNVNative(n, pfences0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetFenceivNVNative(uint fence, GLFenceParameterNameNV pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLFenceParameterNameNV, int*, void>)funcTable[3])(fence, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLFenceParameterNameNV, nint, void>)funcTable[3])(fence, pname, (nint)@params);
			#endif
		}

		public static void GetFenceivNV(uint fence, GLFenceParameterNameNV pname, int* @params)
		{
			GetFenceivNVNative(fence, pname, @params);
		}

		public static void GetFenceivNV(uint fence, GLFenceParameterNameNV pname, out int @params)
		{
			int pparams;
			GetFenceivNVNative(fence, pname, &pparams);
			@params = pparams;
		}

		public static void GetFenceivNV(uint fence, GLFenceParameterNameNV pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetFenceivNVNative(fence, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsFenceNVNative(uint fence)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[4])(fence);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[4])(fence);
			#endif
		}

		public static bool IsFenceNV(uint fence)
		{
			byte ret = IsFenceNVNative(fence);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetFenceNVNative(uint fence, GLFenceConditionNV condition)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLFenceConditionNV, void>)funcTable[5])(fence, condition);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLFenceConditionNV, void>)funcTable[5])(fence, condition);
			#endif
		}

		public static void SetFenceNV(uint fence, GLFenceConditionNV condition)
		{
			SetFenceNVNative(fence, condition);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte TestFenceNVNative(uint fence)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[6])(fence);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[6])(fence);
			#endif
		}

		public static bool TestFenceNV(uint fence)
		{
			byte ret = TestFenceNVNative(fence);
			return ret != 0;
		}

	}
}
