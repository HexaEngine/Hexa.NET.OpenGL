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
	public static unsafe partial class GLEXTDrawBuffers2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ColorMaskIndexedEXTNative(uint index, byte r, byte g, byte b, byte a)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, byte, byte, byte, byte, void>)funcTable[0])(index, r, g, b, a);
			#else
			((delegate* unmanaged[Cdecl]<uint, byte, byte, byte, byte, void>)funcTable[0])(index, r, g, b, a);
			#endif
		}

		public static void ColorMaskIndexedEXT(uint index, byte r, byte g, byte b, byte a)
		{
			ColorMaskIndexedEXTNative(index, r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DisableIndexedEXTNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[1])(target, index);
			#else
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[1])(target, index);
			#endif
		}

		public static void DisableIndexedEXT(GLEnableCap target, uint index)
		{
			DisableIndexedEXTNative(target, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EnableIndexedEXTNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[2])(target, index);
			#else
			((delegate* unmanaged[Cdecl]<GLEnableCap, uint, void>)funcTable[2])(target, index);
			#endif
		}

		public static void EnableIndexedEXT(GLEnableCap target, uint index)
		{
			EnableIndexedEXTNative(target, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetBooleanIndexedvEXTNative(GLBufferTargetARB target, uint index, byte* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, byte*, void>)funcTable[3])(target, index, data);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, nint, void>)funcTable[3])(target, index, (nint)data);
			#endif
		}

		public static void GetBooleanIndexedvEXT(GLBufferTargetARB target, uint index, byte* data)
		{
			GetBooleanIndexedvEXTNative(target, index, data);
		}

		public static void GetBooleanIndexedvEXT(GLBufferTargetARB target, uint index, string data)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (data != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(data);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(data, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetBooleanIndexedvEXTNative(target, index, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetBooleanIndexedvEXT(GLBufferTargetARB target, uint index, ReadOnlySpan<byte> data)
		{
			fixed (byte* pdata0 = data)
			{
				GetBooleanIndexedvEXTNative(target, index, pdata0);
			}
		}

		public static void GetBooleanIndexedvEXT(GLBufferTargetARB target, uint index, ref byte data)
		{
			fixed (byte* pdata0 = &data)
			{
				GetBooleanIndexedvEXTNative(target, index, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetIntegerIndexedvEXTNative(GLGetPName target, uint index, int* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, int*, void>)funcTable[4])(target, index, data);
			#else
			((delegate* unmanaged[Cdecl]<GLGetPName, uint, nint, void>)funcTable[4])(target, index, (nint)data);
			#endif
		}

		public static void GetIntegerIndexedvEXT(GLGetPName target, uint index, int* data)
		{
			GetIntegerIndexedvEXTNative(target, index, data);
		}

		public static void GetIntegerIndexedvEXT(GLGetPName target, uint index, ref int data)
		{
			fixed (int* pdata0 = &data)
			{
				GetIntegerIndexedvEXTNative(target, index, pdata0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte IsEnabledIndexedEXTNative(GLEnableCap target, uint index)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<GLEnableCap, uint, byte>)funcTable[5])(target, index);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<GLEnableCap, uint, byte>)funcTable[5])(target, index);
			#endif
		}

		public static bool IsEnabledIndexedEXT(GLEnableCap target, uint index)
		{
			byte ret = IsEnabledIndexedEXTNative(target, index);
			return ret != 0;
		}

	}
}
