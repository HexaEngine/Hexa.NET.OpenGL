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
	public static unsafe partial class GLARBIndirectParameters
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawArraysIndirectCountARBNative(GLPrimitiveType mode, void* indirect, nint drawcount, int maxdrawcount, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void*, nint, int, int, void>)funcTable[0])(mode, indirect, drawcount, maxdrawcount, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, nint, nint, int, int, void>)funcTable[0])(mode, (nint)indirect, drawcount, maxdrawcount, stride);
			#endif
		}

		public static void MultiDrawArraysIndirectCountARB(GLPrimitiveType mode, void* indirect, nint drawcount, int maxdrawcount, int stride)
		{
			MultiDrawArraysIndirectCountARBNative(mode, indirect, drawcount, maxdrawcount, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MultiDrawElementsIndirectCountARBNative(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, nint drawcount, int maxdrawcount, int stride)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, void*, nint, int, int, void>)funcTable[1])(mode, type, indirect, drawcount, maxdrawcount, stride);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, GLDrawElementsType, nint, nint, int, int, void>)funcTable[1])(mode, type, (nint)indirect, drawcount, maxdrawcount, stride);
			#endif
		}

		public static void MultiDrawElementsIndirectCountARB(GLPrimitiveType mode, GLDrawElementsType type, void* indirect, nint drawcount, int maxdrawcount, int stride)
		{
			MultiDrawElementsIndirectCountARBNative(mode, type, indirect, drawcount, maxdrawcount, stride);
		}

	}
}