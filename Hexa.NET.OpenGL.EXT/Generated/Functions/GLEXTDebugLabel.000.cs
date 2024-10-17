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
	public static unsafe partial class GLEXTDebugLabel
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetObjectLabelEXTNative(GLEnum type, uint @object, int bufSize, int* length, byte* label)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, int, int*, byte*, void>)funcTable[0])(type, @object, bufSize, length, label);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, int, nint, nint, void>)funcTable[0])(type, @object, bufSize, (nint)length, (nint)label);
			#endif
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, int* length, byte* label)
		{
			GetObjectLabelEXTNative(type, @object, bufSize, length, label);
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, Span<int> length, byte* label)
		{
			fixed (int* plength0 = length)
			{
				GetObjectLabelEXTNative(type, @object, bufSize, plength0, label);
			}
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, ref int length, byte* label)
		{
			fixed (int* plength0 = &length)
			{
				GetObjectLabelEXTNative(type, @object, bufSize, plength0, label);
			}
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, int* length, string label)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetObjectLabelEXTNative(type, @object, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, int* length, Span<byte> label)
		{
			fixed (byte* plabel0 = label)
			{
				GetObjectLabelEXTNative(type, @object, bufSize, length, plabel0);
			}
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, int* length, ref byte label)
		{
			fixed (byte* plabel0 = &label)
			{
				GetObjectLabelEXTNative(type, @object, bufSize, length, plabel0);
			}
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, Span<int> length, Span<byte> label)
		{
			fixed (int* plength0 = length)
			{
				fixed (byte* plabel1 = label)
				{
					GetObjectLabelEXTNative(type, @object, bufSize, plength0, plabel1);
				}
			}
		}

		public static void GetObjectLabelEXT(GLEnum type, uint @object, int bufSize, ref int length, ref byte label)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* plabel1 = &label)
				{
					GetObjectLabelEXTNative(type, @object, bufSize, plength0, plabel1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void LabelObjectEXTNative(GLEnum type, uint @object, int length, byte* label)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, uint, int, byte*, void>)funcTable[1])(type, @object, length, label);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, uint, int, nint, void>)funcTable[1])(type, @object, length, (nint)label);
			#endif
		}

		public static void LabelObjectEXT(GLEnum type, uint @object, int length, byte* label)
		{
			LabelObjectEXTNative(type, @object, length, label);
		}

		public static void LabelObjectEXT(GLEnum type, uint @object, int length, string label)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (label != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(label);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(label, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			LabelObjectEXTNative(type, @object, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void LabelObjectEXT(GLEnum type, uint @object, int length, Span<byte> label)
		{
			fixed (byte* plabel0 = label)
			{
				LabelObjectEXTNative(type, @object, length, plabel0);
			}
		}

		public static void LabelObjectEXT(GLEnum type, uint @object, int length, ref byte label)
		{
			fixed (byte* plabel0 = &label)
			{
				LabelObjectEXTNative(type, @object, length, plabel0);
			}
		}

	}
}
