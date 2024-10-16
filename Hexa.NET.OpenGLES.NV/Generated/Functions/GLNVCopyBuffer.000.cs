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

namespace Hexa.NET.OpenGLES.NV
{
	public static unsafe partial class GLNVCopyBuffer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void CopyBufferSubDataNVNative(GLCopyBufferSubDataTarget readTarget, GLCopyBufferSubDataTarget writeTarget, nint readOffset, nint writeOffset, nint size)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLCopyBufferSubDataTarget, GLCopyBufferSubDataTarget, nint, nint, nint, void>)funcTable[0])(readTarget, writeTarget, readOffset, writeOffset, size);
			#else
			((delegate* unmanaged[Cdecl]<GLCopyBufferSubDataTarget, GLCopyBufferSubDataTarget, nint, nint, nint, void>)funcTable[0])(readTarget, writeTarget, readOffset, writeOffset, size);
			#endif
		}

		public static void CopyBufferSubDataNV(GLCopyBufferSubDataTarget readTarget, GLCopyBufferSubDataTarget writeTarget, nint readOffset, nint writeOffset, nint size)
		{
			CopyBufferSubDataNVNative(readTarget, writeTarget, readOffset, writeOffset, size);
		}

	}
}