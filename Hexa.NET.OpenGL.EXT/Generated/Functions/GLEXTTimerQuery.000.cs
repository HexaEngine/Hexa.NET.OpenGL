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
	public static unsafe partial class GLEXTTimerQuery
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetQueryObjecti64vEXTNative(uint id, GLQueryObjectParameterName pname, long* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLQueryObjectParameterName, long*, void>)funcTable[0])(id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLQueryObjectParameterName, nint, void>)funcTable[0])(id, pname, (nint)@params);
			#endif
		}

		public static void GetQueryObjecti64vEXT(uint id, GLQueryObjectParameterName pname, long* @params)
		{
			GetQueryObjecti64vEXTNative(id, pname, @params);
		}

		public static void GetQueryObjecti64vEXT(uint id, GLQueryObjectParameterName pname, ref long @params)
		{
			fixed (long* pparams0 = &@params)
			{
				GetQueryObjecti64vEXTNative(id, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetQueryObjectui64vEXTNative(uint id, GLQueryObjectParameterName pname, ulong* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLQueryObjectParameterName, ulong*, void>)funcTable[1])(id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLQueryObjectParameterName, nint, void>)funcTable[1])(id, pname, (nint)@params);
			#endif
		}

		public static void GetQueryObjectui64vEXT(uint id, GLQueryObjectParameterName pname, ulong* @params)
		{
			GetQueryObjectui64vEXTNative(id, pname, @params);
		}

		public static void GetQueryObjectui64vEXT(uint id, GLQueryObjectParameterName pname, ref ulong @params)
		{
			fixed (ulong* pparams0 = &@params)
			{
				GetQueryObjectui64vEXTNative(id, pname, pparams0);
			}
		}

	}
}
