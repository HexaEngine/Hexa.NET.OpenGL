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
	public unsafe partial class GLNVPrimitiveRestart
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PrimitiveRestartIndexNVNative(uint index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(index);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(index);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_primitive_restart</remarks>
		public void PrimitiveRestartIndexNV(uint index)
		{
			PrimitiveRestartIndexNVNative(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PrimitiveRestartNVNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_primitive_restart</remarks>
		public void PrimitiveRestartNV()
		{
			PrimitiveRestartNVNative();
		}

	}
}
