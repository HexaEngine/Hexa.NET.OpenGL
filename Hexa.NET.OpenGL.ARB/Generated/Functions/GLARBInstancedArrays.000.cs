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
	public unsafe partial class GLARBInstancedArrays
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void VertexAttribDivisorARBNative(uint index, uint divisor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(index, divisor);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, void>)funcTable[0])(index, divisor);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_instanced_arrays</remarks>
		public void VertexAttribDivisorARB(uint index, uint divisor)
		{
			VertexAttribDivisorARBNative(index, divisor);
		}

	}
}
