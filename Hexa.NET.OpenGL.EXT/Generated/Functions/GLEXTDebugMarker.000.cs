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
	public static unsafe partial class GLEXTDebugMarker
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void InsertEventMarkerEXTNative(int length, byte* marker)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, void>)funcTable[0])(length, marker);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[0])(length, (nint)marker);
			#endif
		}

		public static void InsertEventMarkerEXT(int length, byte* marker)
		{
			InsertEventMarkerEXTNative(length, marker);
		}

		public static void InsertEventMarkerEXT(int length, string marker)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (marker != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(marker);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(marker, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			InsertEventMarkerEXTNative(length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void InsertEventMarkerEXT(int length, Span<byte> marker)
		{
			fixed (byte* pmarker0 = marker)
			{
				InsertEventMarkerEXTNative(length, pmarker0);
			}
		}

		public static void InsertEventMarkerEXT(int length, ref byte marker)
		{
			fixed (byte* pmarker0 = &marker)
			{
				InsertEventMarkerEXTNative(length, pmarker0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PopGroupMarkerEXTNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[1])();
			#endif
		}

		public static void PopGroupMarkerEXT()
		{
			PopGroupMarkerEXTNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PushGroupMarkerEXTNative(int length, byte* marker)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, byte*, void>)funcTable[2])(length, marker);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[2])(length, (nint)marker);
			#endif
		}

		public static void PushGroupMarkerEXT(int length, byte* marker)
		{
			PushGroupMarkerEXTNative(length, marker);
		}

		public static void PushGroupMarkerEXT(int length, string marker)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (marker != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(marker);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(marker, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			PushGroupMarkerEXTNative(length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void PushGroupMarkerEXT(int length, Span<byte> marker)
		{
			fixed (byte* pmarker0 = marker)
			{
				PushGroupMarkerEXTNative(length, pmarker0);
			}
		}

		public static void PushGroupMarkerEXT(int length, ref byte marker)
		{
			fixed (byte* pmarker0 = &marker)
			{
				PushGroupMarkerEXTNative(length, pmarker0);
			}
		}

	}
}
