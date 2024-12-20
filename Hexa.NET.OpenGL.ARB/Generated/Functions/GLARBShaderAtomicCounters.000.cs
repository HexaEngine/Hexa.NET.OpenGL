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
	public unsafe partial class GLARBShaderAtomicCounters
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetActiveAtomicCounterBufferivNative(uint program, uint bufferIndex, GLAtomicCounterBufferPName pname, int* @params)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLAtomicCounterBufferPName, int*, void>)funcTable[0])(program, bufferIndex, pname, @params);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLAtomicCounterBufferPName, nint, void>)funcTable[0])(program, bufferIndex, pname, (nint)@params);
			#endif
		}

		/// <summary>
		/// Retrieve information about the set of active atomic counter buffers for a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_shader_atomic_counters</remarks>
		public void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, GLAtomicCounterBufferPName pname, int* @params)
		{
			GetActiveAtomicCounterBufferivNative(program, bufferIndex, pname, @params);
		}

		/// <summary>
		/// Retrieve information about the set of active atomic counter buffers for a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_shader_atomic_counters</remarks>
		public void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, GLAtomicCounterBufferPName pname, out int @params)
		{
			int pparam;
			GetActiveAtomicCounterBufferivNative(program, bufferIndex, pname, &pparam);
			@params = pparam;
		}

		/// <summary>
		/// Retrieve information about the set of active atomic counter buffers for a program
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.2 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_shader_atomic_counters</remarks>
		public void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, GLAtomicCounterBufferPName pname, Span<int> @params)
		{
			fixed (int* pparams = @params)
			{
				GetActiveAtomicCounterBufferivNative(program, bufferIndex, pname, pparams);
			}
		}

	}
}
