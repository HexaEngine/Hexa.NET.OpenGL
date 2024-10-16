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
	public static unsafe partial class GLEXTVertexWeighting
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexWeightPointerEXTNative(int size, GLVertexWeightPointerTypeEXT type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLVertexWeightPointerTypeEXT, int, void*, void>)funcTable[0])(size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, GLVertexWeightPointerTypeEXT, int, nint, void>)funcTable[0])(size, type, stride, (nint)pointer);
			#endif
		}

		public static void VertexWeightPointerEXT(int size, GLVertexWeightPointerTypeEXT type, int stride, void* pointer)
		{
			VertexWeightPointerEXTNative(size, type, stride, pointer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexWeightfEXTNative(float weight)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[1])(weight);
			#else
			((delegate* unmanaged[Cdecl]<float, void>)funcTable[1])(weight);
			#endif
		}

		public static void VertexWeightfEXT(float weight)
		{
			VertexWeightfEXTNative(weight);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void VertexWeightfvEXTNative(float* weight)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[2])(weight);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[2])((nint)weight);
			#endif
		}

		public static void VertexWeightfvEXT(float* weight)
		{
			VertexWeightfvEXTNative(weight);
		}

		public static void VertexWeightfvEXT(ref float weight)
		{
			fixed (float* pweight0 = &weight)
			{
				VertexWeightfvEXTNative(pweight0);
			}
		}

	}
}