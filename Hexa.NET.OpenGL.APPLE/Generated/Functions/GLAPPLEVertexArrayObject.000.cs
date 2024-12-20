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
	public unsafe partial class GLAPPLEVertexArrayObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindVertexArrayAPPLENative(uint array)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(array);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void BindVertexArrayAPPLE(uint array)
		{
			BindVertexArrayAPPLENative(array);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DeleteVertexArraysAPPLENative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)arrays);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void DeleteVertexArraysAPPLE(int n, uint* arrays)
		{
			DeleteVertexArraysAPPLENative(n, arrays);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void DeleteVertexArraysAPPL(uint array)
		{
			DeleteVertexArraysAPPLENative(1, &array);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void DeleteVertexArraysAPPLE(int n, Span<uint> arrays)
		{
			fixed (uint* parrays0 = arrays)
			{
				DeleteVertexArraysAPPLENative(n, parrays0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void DeleteVertexArraysAPPLE(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				DeleteVertexArraysAPPLENative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GenVertexArraysAPPLENative(int n, uint* arrays)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[2])(n, arrays);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(n, (nint)arrays);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void GenVertexArraysAPPLE(int n, uint* arrays)
		{
			GenVertexArraysAPPLENative(n, arrays);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public uint GenVertexArraysAPPL()
		{
			uint result;
			GenVertexArraysAPPLENative(1, &result);
			return result;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void GenVertexArraysAPPLE(int n, Span<uint> arrays)
		{
			fixed (uint* parrays0 = arrays)
			{
				GenVertexArraysAPPLENative(n, parrays0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public void GenVertexArraysAPPLE(int n, ref uint arrays)
		{
			fixed (uint* parrays0 = &arrays)
			{
				GenVertexArraysAPPLENative(n, parrays0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal byte IsVertexArrayAPPLENative(uint array)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[3])(array);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<uint, byte>)funcTable[3])(array);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_APPLE_vertex_array_object</remarks>
		public bool IsVertexArrayAPPLE(uint array)
		{
			byte ret = IsVertexArrayAPPLENative(array);
			return ret != 0;
		}

	}
}
