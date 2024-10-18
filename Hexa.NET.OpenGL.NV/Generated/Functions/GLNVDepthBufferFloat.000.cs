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
	public static unsafe partial class GLNVDepthBufferFloat
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ClearDepthdNVNative(double depth)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, void>)funcTable[0])(depth);
			#else
			((delegate* unmanaged[Cdecl]<double, void>)funcTable[0])(depth);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_depth_buffer_float</remarks>
		public static void ClearDepthdNV(double depth)
		{
			ClearDepthdNVNative(depth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DepthBoundsdNVNative(double zmin, double zmax)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[1])(zmin, zmax);
			#else
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[1])(zmin, zmax);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_depth_buffer_float</remarks>
		public static void DepthBoundsdNV(double zmin, double zmax)
		{
			DepthBoundsdNVNative(zmin, zmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DepthRangedNVNative(double zNear, double zFar)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[2])(zNear, zFar);
			#else
			((delegate* unmanaged[Cdecl]<double, double, void>)funcTable[2])(zNear, zFar);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_depth_buffer_float</remarks>
		public static void DepthRangedNV(double zNear, double zFar)
		{
			DepthRangedNVNative(zNear, zFar);
		}

	}
}
