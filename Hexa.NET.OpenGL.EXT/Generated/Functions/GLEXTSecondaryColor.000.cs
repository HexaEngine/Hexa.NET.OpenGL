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
	public unsafe partial class GLEXTSecondaryColor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3bEXTNative(sbyte red, sbyte green, sbyte blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)funcTable[0])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, void>)funcTable[0])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue)
		{
			SecondaryColor3bEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3bvEXTNative(sbyte* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<sbyte*, void>)funcTable[1])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[1])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3bvEXT(sbyte* v)
		{
			SecondaryColor3bvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3bvEXT(Span<sbyte> v)
		{
			fixed (sbyte* pv0 = v)
			{
				SecondaryColor3bvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3bvEXT(ref sbyte v)
		{
			fixed (sbyte* pv0 = &v)
			{
				SecondaryColor3bvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3dEXTNative(double red, double green, double blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[2])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<double, double, double, void>)funcTable[2])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3dEXT(double red, double green, double blue)
		{
			SecondaryColor3dEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3dvEXTNative(double* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<double*, void>)funcTable[3])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[3])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3dvEXT(double* v)
		{
			SecondaryColor3dvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3dvEXT(Span<double> v)
		{
			fixed (double* pv0 = v)
			{
				SecondaryColor3dvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3dvEXT(ref double v)
		{
			fixed (double* pv0 = &v)
			{
				SecondaryColor3dvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3fEXTNative(float red, float green, float blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[4])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<float, float, float, void>)funcTable[4])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3fEXT(float red, float green, float blue)
		{
			SecondaryColor3fEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3fvEXTNative(float* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<float*, void>)funcTable[5])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[5])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3fvEXT(float* v)
		{
			SecondaryColor3fvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3fvEXT(Span<float> v)
		{
			fixed (float* pv0 = v)
			{
				SecondaryColor3fvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3fvEXT(ref float v)
		{
			fixed (float* pv0 = &v)
			{
				SecondaryColor3fvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3iEXTNative(int red, int green, int blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[6])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<int, int, int, void>)funcTable[6])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3iEXT(int red, int green, int blue)
		{
			SecondaryColor3iEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3ivEXTNative(int* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, void>)funcTable[7])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[7])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ivEXT(int* v)
		{
			SecondaryColor3ivEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ivEXT(Span<int> v)
		{
			fixed (int* pv0 = v)
			{
				SecondaryColor3ivEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ivEXT(ref int v)
		{
			fixed (int* pv0 = &v)
			{
				SecondaryColor3ivEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3sEXTNative(short red, short green, short blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[8])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<short, short, short, void>)funcTable[8])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3sEXT(short red, short green, short blue)
		{
			SecondaryColor3sEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3svEXTNative(short* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<short*, void>)funcTable[9])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[9])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3svEXT(short* v)
		{
			SecondaryColor3svEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3svEXT(Span<short> v)
		{
			fixed (short* pv0 = v)
			{
				SecondaryColor3svEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3svEXT(ref short v)
		{
			fixed (short* pv0 = &v)
			{
				SecondaryColor3svEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3ubEXTNative(bool red, bool green, bool blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<byte, byte, byte, void>)funcTable[10])(*((byte*)(&red)), *((byte*)(&green)), *((byte*)(&blue)));
			#else
			((delegate* unmanaged[Cdecl]<byte, byte, byte, void>)funcTable[10])(*((byte*)(&red)), *((byte*)(&green)), *((byte*)(&blue)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ubEXT(bool red, bool green, bool blue)
		{
			SecondaryColor3ubEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3ubvEXTNative(byte* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<byte*, void>)funcTable[11])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[11])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ubvEXT(byte* v)
		{
			SecondaryColor3ubvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ubvEXT(string v)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (v != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(v);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(v, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			SecondaryColor3ubvEXTNative(pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ubvEXT(Span<byte> v)
		{
			fixed (byte* pv0 = v)
			{
				SecondaryColor3ubvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3ubvEXT(ref byte v)
		{
			fixed (byte* pv0 = &v)
			{
				SecondaryColor3ubvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3uiEXTNative(uint red, uint green, uint blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, void>)funcTable[12])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, void>)funcTable[12])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3uiEXT(uint red, uint green, uint blue)
		{
			SecondaryColor3uiEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3uivEXTNative(uint* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint*, void>)funcTable[13])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[13])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3uivEXT(uint* v)
		{
			SecondaryColor3uivEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3uivEXT(Span<uint> v)
		{
			fixed (uint* pv0 = v)
			{
				SecondaryColor3uivEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3uivEXT(ref uint v)
		{
			fixed (uint* pv0 = &v)
			{
				SecondaryColor3uivEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3usEXTNative(ushort red, ushort green, ushort blue)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ushort, ushort, ushort, void>)funcTable[14])(red, green, blue);
			#else
			((delegate* unmanaged[Cdecl]<ushort, ushort, ushort, void>)funcTable[14])(red, green, blue);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3usEXT(ushort red, ushort green, ushort blue)
		{
			SecondaryColor3usEXTNative(red, green, blue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColor3usvEXTNative(ushort* v)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ushort*, void>)funcTable[15])(v);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[15])((nint)v);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3usvEXT(ushort* v)
		{
			SecondaryColor3usvEXTNative(v);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3usvEXT(Span<ushort> v)
		{
			fixed (ushort* pv0 = v)
			{
				SecondaryColor3usvEXTNative(pv0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColor3usvEXT(ref ushort v)
		{
			fixed (ushort* pv0 = &v)
			{
				SecondaryColor3usvEXTNative(pv0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void SecondaryColorPointerEXTNative(int size, GLColorPointerType type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, GLColorPointerType, int, void*, void>)funcTable[16])(size, type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<int, GLColorPointerType, int, nint, void>)funcTable[16])(size, type, stride, (nint)pointer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColorPointerEXT(int size, GLColorPointerType type, int stride, void* pointer)
		{
			SecondaryColorPointerEXTNative(size, type, stride, pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColorPointerEXT(int size, GLColorPointerType type, int stride, nint pointer)
		{
			SecondaryColorPointerEXTNative(size, type, stride, (void*)pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_secondary_color</remarks>
		public void SecondaryColorPointerEXT<TPointer>(int size, GLColorPointerType type, int stride, Span<TPointer> pointer) where TPointer : unmanaged
		{
			fixed (TPointer* ppointer0 = pointer)
			{
				SecondaryColorPointerEXTNative(size, type, stride, ppointer0);
			}
		}

	}
}
