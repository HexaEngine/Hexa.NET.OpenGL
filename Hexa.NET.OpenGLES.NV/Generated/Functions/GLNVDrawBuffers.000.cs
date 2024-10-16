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
	public static unsafe partial class GLNVDrawBuffers
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawBuffersNVNative(int n, GLEnum* bufs)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLEnum*, void>)funcTable[0])(n, bufs);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[0])(n, (nint)bufs);
			#endif
		}

		public static void DrawBuffersNV(int n, GLEnum* bufs)
		{
			DrawBuffersNVNative(n, bufs);
		}

		public static void DrawBuffersNV(int n, ref GLEnum bufs)
		{
			fixed (GLEnum* pbufs0 = &bufs)
			{
				DrawBuffersNVNative(n, pbufs0);
			}
		}

	}
}