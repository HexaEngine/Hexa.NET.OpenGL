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
	public static unsafe partial class GLARBTransformFeedbackInstanced
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTransformFeedbackInstancedNative(GLPrimitiveType mode, uint id, int instancecount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, int, void>)funcTable[0])(mode, id, instancecount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, int, void>)funcTable[0])(mode, id, instancecount);
			#endif
		}

		public static void DrawTransformFeedbackInstanced(GLPrimitiveType mode, uint id, int instancecount)
		{
			DrawTransformFeedbackInstancedNative(mode, id, instancecount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawTransformFeedbackStreamInstancedNative(GLPrimitiveType mode, uint id, uint stream, int instancecount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, int, void>)funcTable[1])(mode, id, stream, instancecount);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, uint, uint, int, void>)funcTable[1])(mode, id, stream, instancecount);
			#endif
		}

		public static void DrawTransformFeedbackStreamInstanced(GLPrimitiveType mode, uint id, uint stream, int instancecount)
		{
			DrawTransformFeedbackStreamInstancedNative(mode, id, stream, instancecount);
		}

	}
}