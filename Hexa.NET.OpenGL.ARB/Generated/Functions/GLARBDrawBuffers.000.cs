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
	public static unsafe partial class GLARBDrawBuffers
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawBuffersARBNative(int n, GLDrawBufferMode bufs)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLDrawBufferMode, void>)funcTable[0])(n, bufs);
			#else
			((delegate* unmanaged[Cdecl]<int, GLDrawBufferMode, void>)funcTable[0])(n, bufs);
			#endif
		}

		public static void DrawBuffersARB(int n, GLDrawBufferMode bufs)
		{
			DrawBuffersARBNative(n, bufs);
		}

	}
}