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
	public static unsafe partial class GLEXTPixelTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPixelTransformParameterfvEXTNative(GLEnum target, GLEnum pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, float*, void>)funcTable[0])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, nint, void>)funcTable[0])(target, pname, (nint)@params);
			#endif
		}

		public static void GetPixelTransformParameterfvEXT(GLEnum target, GLEnum pname, float* @params)
		{
			GetPixelTransformParameterfvEXTNative(target, pname, @params);
		}

		public static void GetPixelTransformParameterfvEXT(GLEnum target, GLEnum pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				GetPixelTransformParameterfvEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPixelTransformParameterivEXTNative(GLEnum target, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, int*, void>)funcTable[1])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLEnum, nint, void>)funcTable[1])(target, pname, (nint)@params);
			#endif
		}

		public static void GetPixelTransformParameterivEXT(GLEnum target, GLEnum pname, int* @params)
		{
			GetPixelTransformParameterivEXTNative(target, pname, @params);
		}

		public static void GetPixelTransformParameterivEXT(GLEnum target, GLEnum pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetPixelTransformParameterivEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PixelTransformParameterfEXTNative(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, float param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, float, void>)funcTable[2])(target, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, float, void>)funcTable[2])(target, pname, param);
			#endif
		}

		public static void PixelTransformParameterfEXT(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, float param)
		{
			PixelTransformParameterfEXTNative(target, pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PixelTransformParameterfvEXTNative(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, float*, void>)funcTable[3])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, nint, void>)funcTable[3])(target, pname, (nint)@params);
			#endif
		}

		public static void PixelTransformParameterfvEXT(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, float* @params)
		{
			PixelTransformParameterfvEXTNative(target, pname, @params);
		}

		public static void PixelTransformParameterfvEXT(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				PixelTransformParameterfvEXTNative(target, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PixelTransformParameteriEXTNative(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, int, void>)funcTable[4])(target, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, int, void>)funcTable[4])(target, pname, param);
			#endif
		}

		public static void PixelTransformParameteriEXT(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, int param)
		{
			PixelTransformParameteriEXTNative(target, pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PixelTransformParameterivEXTNative(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, int*, void>)funcTable[5])(target, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLPixelTransformTargetEXT, GLPixelTransformPNameEXT, nint, void>)funcTable[5])(target, pname, (nint)@params);
			#endif
		}

		public static void PixelTransformParameterivEXT(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, int* @params)
		{
			PixelTransformParameterivEXTNative(target, pname, @params);
		}

		public static void PixelTransformParameterivEXT(GLPixelTransformTargetEXT target, GLPixelTransformPNameEXT pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				PixelTransformParameterivEXTNative(target, pname, pparams0);
			}
		}

	}
}