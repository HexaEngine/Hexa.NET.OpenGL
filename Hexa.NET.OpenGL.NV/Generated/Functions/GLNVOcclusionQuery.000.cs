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
	public static unsafe partial class GLNVOcclusionQuery
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BeginOcclusionQueryNVNative(uint id)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(id);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(id);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void BeginOcclusionQueryNV(uint id)
		{
			BeginOcclusionQueryNVNative(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteOcclusionQueriesNVNative(int n, uint* ids)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(n, ids);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)ids);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void DeleteOcclusionQueriesNV(int n, uint* ids)
		{
			DeleteOcclusionQueriesNVNative(n, ids);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void DeleteOcclusionQueriesN(uint id)
		{
			DeleteOcclusionQueriesNVNative(1, &id);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void DeleteOcclusionQueriesNV(int n, Span<uint> ids)
		{
			fixed (uint* pids0 = ids)
			{
				DeleteOcclusionQueriesNVNative(n, pids0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void DeleteOcclusionQueriesNV(int n, ref uint ids)
		{
			fixed (uint* pids0 = &ids)
			{
				DeleteOcclusionQueriesNVNative(n, pids0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EndOcclusionQueryNVNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[2])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[2])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void EndOcclusionQueryNV()
		{
			EndOcclusionQueryNVNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenOcclusionQueriesNVNative(int n, uint* ids)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[3])(n, ids);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[3])(n, (nint)ids);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GenOcclusionQueriesNV(int n, uint* ids)
		{
			GenOcclusionQueriesNVNative(n, ids);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static uint GenOcclusionQueriesN()
		{
			uint result;
			GenOcclusionQueriesNVNative(1, &result);
			return result;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GenOcclusionQueriesNV(int n, Span<uint> ids)
		{
			fixed (uint* pids0 = ids)
			{
				GenOcclusionQueriesNVNative(n, pids0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GenOcclusionQueriesNV(int n, ref uint ids)
		{
			fixed (uint* pids0 = &ids)
			{
				GenOcclusionQueriesNVNative(n, pids0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetOcclusionQueryivNVNative(uint id, GLOcclusionQueryParameterNameNV pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLOcclusionQueryParameterNameNV, int*, void>)funcTable[4])(id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLOcclusionQueryParameterNameNV, nint, void>)funcTable[4])(id, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GetOcclusionQueryivNV(uint id, GLOcclusionQueryParameterNameNV pname, int* @params)
		{
			GetOcclusionQueryivNVNative(id, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GetOcclusionQueryivNV(uint id, GLOcclusionQueryParameterNameNV pname, Span<int> @params)
		{
			fixed (int* pparams0 = @params)
			{
				GetOcclusionQueryivNVNative(id, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GetOcclusionQueryivNV(uint id, GLOcclusionQueryParameterNameNV pname, ref int @params)
		{
			fixed (int* pparams0 = &@params)
			{
				GetOcclusionQueryivNVNative(id, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetOcclusionQueryuivNVNative(uint id, GLOcclusionQueryParameterNameNV pname, uint* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLOcclusionQueryParameterNameNV, uint*, void>)funcTable[5])(id, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLOcclusionQueryParameterNameNV, nint, void>)funcTable[5])(id, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GetOcclusionQueryuivNV(uint id, GLOcclusionQueryParameterNameNV pname, uint* @params)
		{
			GetOcclusionQueryuivNVNative(id, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GetOcclusionQueryuivNV(uint id, GLOcclusionQueryParameterNameNV pname, Span<uint> @params)
		{
			fixed (uint* pparams0 = @params)
			{
				GetOcclusionQueryuivNVNative(id, pname, pparams0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static void GetOcclusionQueryuivNV(uint id, GLOcclusionQueryParameterNameNV pname, ref uint @params)
		{
			fixed (uint* pparams0 = &@params)
			{
				GetOcclusionQueryuivNVNative(id, pname, pparams0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsOcclusionQueryNVNative(uint id)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[6])(id);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[6])(id);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_occlusion_query</remarks>
		public static bool IsOcclusionQueryNV(uint id)
		{
			byte ret = IsOcclusionQueryNVNative(id);
			return ret != 0;
		}

	}
}
