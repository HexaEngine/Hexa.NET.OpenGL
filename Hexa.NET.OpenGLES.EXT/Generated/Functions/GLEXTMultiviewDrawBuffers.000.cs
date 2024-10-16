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

namespace Hexa.NET.OpenGLES.EXT
{
	public static unsafe partial class GLEXTMultiviewDrawBuffers
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DrawBuffersIndexedEXTNative(int n, GLEnum* location, int* indices)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLEnum*, int*, void>)funcTable[0])(n, location, indices);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, nint, void>)funcTable[0])(n, (nint)location, (nint)indices);
			#endif
		}

		public static void DrawBuffersIndexedEXT(int n, GLEnum* location, int* indices)
		{
			DrawBuffersIndexedEXTNative(n, location, indices);
		}

		public static void DrawBuffersIndexedEXT(int n, ref GLEnum location, int* indices)
		{
			fixed (GLEnum* plocation0 = &location)
			{
				DrawBuffersIndexedEXTNative(n, plocation0, indices);
			}
		}

		public static void DrawBuffersIndexedEXT(int n, GLEnum* location, ref int indices)
		{
			fixed (int* pindices0 = &indices)
			{
				DrawBuffersIndexedEXTNative(n, location, pindices0);
			}
		}

		public static void DrawBuffersIndexedEXT(int n, ref GLEnum location, ref int indices)
		{
			fixed (GLEnum* plocation0 = &location)
			{
				fixed (int* pindices1 = &indices)
				{
					DrawBuffersIndexedEXTNative(n, plocation0, pindices1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetIntegeri_vEXTNative(GLGetPName target, uint index, int* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, int*, void>)funcTable[1])(target, index, data);
			#else
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, nint, void>)funcTable[1])(target, index, (nint)data);
			#endif
		}

		public static void GetIntegeri_vEXT(GLGetPName target, uint index, int* data)
		{
			GetIntegeri_vEXTNative(target, index, data);
		}

		public static void GetIntegeri_vEXT(GLGetPName target, uint index, ref int data)
		{
			fixed (int* pdata0 = &data)
			{
				GetIntegeri_vEXTNative(target, index, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ReadBufferIndexedEXTNative(GLReadBufferMode src, int index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLReadBufferMode, int, void>)funcTable[2])(src, index);
			#else
			((delegate* unmanaged[Cdecl]<GLReadBufferMode, int, void>)funcTable[2])(src, index);
			#endif
		}

		public static void ReadBufferIndexedEXT(GLReadBufferMode src, int index)
		{
			ReadBufferIndexedEXTNative(src, index);
		}

	}
}