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

namespace Hexa.NET.OpenGLES.ANGLE
{
	public static unsafe partial class GLANGLETranslatedShaderSource
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetTranslatedShaderSourceANGLENative(uint shader, int bufSize, int* length, byte* source)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, byte*, void>)funcTable[0])(shader, bufSize, length, source);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[0])(shader, bufSize, (nint)length, (nint)source);
			#endif
		}

		public static void GetTranslatedShaderSourceANGLE(uint shader, int bufSize, int* length, byte* source)
		{
			GetTranslatedShaderSourceANGLENative(shader, bufSize, length, source);
		}

		public static void GetTranslatedShaderSourceANGLE(uint shader, int bufSize, ref int length, byte* source)
		{
			fixed (int* plength0 = &length)
			{
				GetTranslatedShaderSourceANGLENative(shader, bufSize, plength0, source);
			}
		}

		public static void GetTranslatedShaderSourceANGLE(uint shader, int bufSize, int* length, string source)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (source != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(source);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(source, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetTranslatedShaderSourceANGLENative(shader, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetTranslatedShaderSourceANGLE(uint shader, int bufSize, int* length, ReadOnlySpan<byte> source)
		{
			fixed (byte* psource0 = source)
			{
				GetTranslatedShaderSourceANGLENative(shader, bufSize, length, psource0);
			}
		}

		public static void GetTranslatedShaderSourceANGLE(uint shader, int bufSize, int* length, ref byte source)
		{
			fixed (byte* psource0 = &source)
			{
				GetTranslatedShaderSourceANGLENative(shader, bufSize, length, psource0);
			}
		}

		public static void GetTranslatedShaderSourceANGLE(uint shader, int bufSize, ref int length, ref byte source)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* psource1 = &source)
				{
					GetTranslatedShaderSourceANGLENative(shader, bufSize, plength0, psource1);
				}
			}
		}

	}
}