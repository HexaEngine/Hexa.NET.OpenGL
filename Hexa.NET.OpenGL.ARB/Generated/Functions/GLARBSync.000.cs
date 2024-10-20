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

namespace Hexa.NET.OpenGL.ARB
{
	public static unsafe partial class GLARBSync
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum ClientWaitSyncNative(GLSync sync, GLSyncObjectMask flags, ulong timeout)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLSync, GLSyncObjectMask, ulong, GLEnum>)funcTable[0])(sync, flags, timeout);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLSync, GLSyncObjectMask, ulong, GLEnum>)funcTable[0])(sync, flags, timeout);
			#endif
		}

		/// <summary>
		/// Block and wait for a sync object to become signaled
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static GLEnum ClientWaitSync(GLSync sync, GLSyncObjectMask flags, ulong timeout)
		{
			GLEnum ret = ClientWaitSyncNative(sync, flags, timeout);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeleteSyncNative(GLSync sync)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSync, void>)funcTable[1])(sync);
			#else
			((delegate* unmanaged[Cdecl]<GLSync, void>)funcTable[1])(sync);
			#endif
		}

		/// <summary>
		/// Delete a sync object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void DeleteSync(GLSync sync)
		{
			DeleteSyncNative(sync);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLSync FenceSyncNative(GLSyncCondition condition, GLSyncBehaviorFlags flags)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLSyncCondition, GLSyncBehaviorFlags, GLSync>)funcTable[2])(condition, flags);
			#else
			return (GLSync)((delegate* unmanaged[Cdecl]<GLSyncCondition, GLSyncBehaviorFlags, GLSync>)funcTable[2])(condition, flags);
			#endif
		}

		/// <summary>
		/// Create a new sync object and insert it into the GL command stream
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static GLSync FenceSync(GLSyncCondition condition, GLSyncBehaviorFlags flags)
		{
			GLSync ret = FenceSyncNative(condition, flags);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetInteger64vNative(GLGetPName pname, long* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetPName, long*, void>)funcTable[3])(pname, data);
			#else
			((delegate* unmanaged[Cdecl]<GLGetPName, nint, void>)funcTable[3])(pname, (nint)data);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetInteger64v(GLGetPName pname, long* data)
		{
			GetInteger64vNative(pname, data);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetInteger64v(GLGetPName pname, out long data)
		{
			long pparam;
			GetInteger64vNative(pname, &pparam);
			data = pparam;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetInteger64v(GLGetPName pname, Span<long> data)
		{
			fixed (long* pparams = data)
			{
				GetInteger64vNative(pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetSyncivNative(GLSync sync, GLSyncParameterName pname, int count, int* length, int* values)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSync, GLSyncParameterName, int, int*, int*, void>)funcTable[4])(sync, pname, count, length, values);
			#else
			((delegate* unmanaged[Cdecl]<GLSync, GLSyncParameterName, int, nint, nint, void>)funcTable[4])(sync, pname, count, (nint)length, (nint)values);
			#endif
		}

		/// <summary>
		/// Query the properties of a sync object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetSynciv(GLSync sync, GLSyncParameterName pname, int count, int* length, int* values)
		{
			GetSyncivNative(sync, pname, count, length, values);
		}

		/// <summary>
		/// Query the properties of a sync object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetSynciv(GLSync sync, GLSyncParameterName pname, int count, int* length, out int values)
		{
			int pparam;
			GetSyncivNative(sync, pname, count, length, &pparam);
			values = pparam;
		}

		/// <summary>
		/// Query the properties of a sync object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetSynciv(GLSync sync, GLSyncParameterName pname, int count, int* length, Span<int> values)
		{
			fixed (int* pparams = values)
			{
				GetSyncivNative(sync, pname, count, length, pparams);
			}
		}

		/// <summary>
		/// Query the properties of a sync object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetSynciv(GLSync sync, GLSyncParameterName pname, int count, Span<int> length, int* values)
		{
			fixed (int* plength0 = length)
			{
				GetSyncivNative(sync, pname, count, plength0, values);
			}
		}

		/// <summary>
		/// Query the properties of a sync object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void GetSynciv(GLSync sync, GLSyncParameterName pname, int count, ref int length, int* values)
		{
			fixed (int* plength0 = &length)
			{
				GetSyncivNative(sync, pname, count, plength0, values);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsSyncNative(GLSync sync)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLSync, byte>)funcTable[5])(sync);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<GLSync, byte>)funcTable[5])(sync);
			#endif
		}

		/// <summary>
		/// Determine if a name corresponds to a sync object
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static bool IsSync(GLSync sync)
		{
			byte ret = IsSyncNative(sync);
			return ret != 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WaitSyncNative(GLSync sync, GLSyncBehaviorFlags flags, ulong timeout)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLSync, GLSyncBehaviorFlags, ulong, void>)funcTable[6])(sync, flags, timeout);
			#else
			((delegate* unmanaged[Cdecl]<GLSync, GLSyncBehaviorFlags, ulong, void>)funcTable[6])(sync, flags, timeout);
			#endif
		}

		/// <summary>
		/// Instruct the GL server to block until the specified sync object becomes signaled
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 3.2 - GL 3.3<br/>GL 4.X<br/><br/>Used by Extensions:<br/>GL_ARB_sync</remarks>
		public static void WaitSync(GLSync sync, GLSyncBehaviorFlags flags, ulong timeout)
		{
			WaitSyncNative(sync, flags, timeout);
		}

	}
}
