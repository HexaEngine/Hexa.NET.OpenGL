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

namespace Hexa.NET.OpenGL.APPLE
{
	public static unsafe partial class GLAPPLEObjectPurgeable
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetObjectParameterivAPPLENative(GLEnum objectType, uint name, GLEnum pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, int*, void>)funcTable[0])(objectType, name, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, nint, void>)funcTable[0])(objectType, name, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_object_purgeable</remarks>
		public static void GetObjectParameterivAPPLE(GLEnum objectType, uint name, GLEnum pname, int* @params)
		{
			GetObjectParameterivAPPLENative(objectType, name, pname, @params);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_object_purgeable</remarks>
		public static void GetObjectParameterivAPPLE(GLEnum objectType, uint name, GLEnum pname, out int @params)
		{
			int pparams;
			GetObjectParameterivAPPLENative(objectType, name, pname, &pparams);
			@params = pparams;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_object_purgeable</remarks>
		public static void GetObjectParameterivAPPLE(GLEnum objectType, uint name, GLEnum pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetObjectParameterivAPPLENative(objectType, name, pname, pparams);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum ObjectPurgeableAPPLENative(GLEnum objectType, uint name, GLEnum option)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[1])(objectType, name, option);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[1])(objectType, name, option);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_object_purgeable</remarks>
		public static GLEnum ObjectPurgeableAPPLE(GLEnum objectType, uint name, GLEnum option)
		{
			GLEnum ret = ObjectPurgeableAPPLENative(objectType, name, option);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static GLEnum ObjectUnpurgeableAPPLENative(GLEnum objectType, uint name, GLEnum option)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[2])(objectType, name, option);
			#else
			return (GLEnum)((delegate* unmanaged[Cdecl]<GLEnum, uint, GLEnum, GLEnum>)funcTable[2])(objectType, name, option);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_object_purgeable</remarks>
		public static GLEnum ObjectUnpurgeableAPPLE(GLEnum objectType, uint name, GLEnum option)
		{
			GLEnum ret = ObjectUnpurgeableAPPLENative(objectType, name, option);
			return ret;
		}

	}
}
