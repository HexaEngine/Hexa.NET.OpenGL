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

namespace Hexa.NET.OpenGL.AMD
{
	public static unsafe partial class GLAMDInterleavedElements
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexAttribParameteriAMDNative(uint index, GLEnum pname, int param)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, void>)funcTable[0])(index, pname, param);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, void>)funcTable[0])(index, pname, param);
			#endif
		}

		public static void VertexAttribParameteriAMD(uint index, GLEnum pname, int param)
		{
			VertexAttribParameteriAMDNative(index, pname, param);
		}

	}
}