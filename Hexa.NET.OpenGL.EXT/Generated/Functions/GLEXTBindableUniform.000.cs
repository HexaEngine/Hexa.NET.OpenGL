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
	public unsafe partial class GLEXTBindableUniform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal int GetUniformBufferSizeEXTNative(uint program, int location)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, int, int>)funcTable[0])(program, location);
			#else
			return (int)((delegate* unmanaged[Cdecl]<uint, int, int>)funcTable[0])(program, location);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_bindable_uniform</remarks>
		public int GetUniformBufferSizeEXT(uint program, int location)
		{
			int ret = GetUniformBufferSizeEXTNative(program, location);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal nint GetUniformOffsetEXTNative(uint program, int location)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, int, nint>)funcTable[1])(program, location);
			#else
			return (nint)((delegate* unmanaged[Cdecl]<uint, int, nint>)funcTable[1])(program, location);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_bindable_uniform</remarks>
		public nint GetUniformOffsetEXT(uint program, int location)
		{
			nint ret = GetUniformOffsetEXTNative(program, location);
			return ret;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void UniformBufferEXTNative(uint program, int location, uint buffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, uint, void>)funcTable[2])(program, location, buffer);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, uint, void>)funcTable[2])(program, location, buffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_bindable_uniform</remarks>
		public void UniformBufferEXT(uint program, int location, uint buffer)
		{
			UniformBufferEXTNative(program, location, buffer);
		}

	}
}
