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
	public unsafe partial class GLEXTPointParameters
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PointParameterfEXTNative(GLPointParameterNameARB pname, float param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPointParameterNameARB, float, void>)funcTable[0])(pname, param);
			#else
			((delegate* unmanaged[Cdecl]<GLPointParameterNameARB, float, void>)funcTable[0])(pname, param);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_point_parameters</remarks>
		public void PointParameterfEXT(GLPointParameterNameARB pname, float param)
		{
			PointParameterfEXTNative(pname, param);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PointParameterfvEXTNative(GLPointParameterNameARB pname, float* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPointParameterNameARB, float*, void>)funcTable[1])(pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLPointParameterNameARB, nint, void>)funcTable[1])(pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_point_parameters</remarks>
		public void PointParameterfvEXT(GLPointParameterNameARB pname, float* @params)
		{
			PointParameterfvEXTNative(pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_point_parameters</remarks>
		public void PointParameterfvEXT(GLPointParameterNameARB pname, Span<float> @params)
		{
			fixed (float* pparams0 = @params)
			{
				PointParameterfvEXTNative(pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_point_parameters</remarks>
		public void PointParameterfvEXT(GLPointParameterNameARB pname, ref float @params)
		{
			fixed (float* pparams0 = &@params)
			{
				PointParameterfvEXTNative(pname, pparams0);
			}
		}

	}
}
