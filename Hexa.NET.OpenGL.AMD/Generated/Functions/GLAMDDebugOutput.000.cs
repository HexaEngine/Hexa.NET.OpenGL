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

namespace Hexa.NET.OpenGL.AMD
{
	public static unsafe partial class GLAMDDebugOutput
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DebugMessageCallbackAMDNative(GLDebugProcAMD callback, void* userParam)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void*, void*, void>)funcTable[0])((void*)Utils.GetFunctionPointerForDelegate(callback), userParam);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[0])(Utils.GetFunctionPointerForDelegate(callback), (nint)userParam);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageCallbackAMD(GLDebugProcAMD callback, void* userParam)
		{
			DebugMessageCallbackAMDNative(callback, userParam);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageCallbackAMD(GLDebugProcAMD callback, nint userParam)
		{
			DebugMessageCallbackAMDNative(callback, (void*)userParam);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageCallbackAMD<TUserParam>(GLDebugProcAMD callback, Span<TUserParam> userParam) where TUserParam : unmanaged
		{
			fixed (TUserParam* puserParam0 = userParam)
			{
				DebugMessageCallbackAMDNative(callback, puserParam0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DebugMessageEnableAMDNative(GLEnum category, GLDebugSeverity severity, int count, uint* ids, bool enabled)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLDebugSeverity, int, uint*, byte, void>)funcTable[1])(category, severity, count, ids, *((byte*)(&enabled)));
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLDebugSeverity, int, nint, byte, void>)funcTable[1])(category, severity, count, (nint)ids, *((byte*)(&enabled)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageEnableAMD(GLEnum category, GLDebugSeverity severity, int count, uint* ids, bool enabled)
		{
			DebugMessageEnableAMDNative(category, severity, count, ids, enabled);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageEnableAMD(GLEnum category, GLDebugSeverity severity, int count, Span<uint> ids, bool enabled)
		{
			fixed (uint* pids0 = ids)
			{
				DebugMessageEnableAMDNative(category, severity, count, pids0, enabled);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageEnableAMD(GLEnum category, GLDebugSeverity severity, int count, ref uint ids, bool enabled)
		{
			fixed (uint* pids0 = &ids)
			{
				DebugMessageEnableAMDNative(category, severity, count, pids0, enabled);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DebugMessageInsertAMDNative(GLEnum category, GLDebugSeverity severity, uint id, int length, byte* buf)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, GLDebugSeverity, uint, int, byte*, void>)funcTable[2])(category, severity, id, length, buf);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, GLDebugSeverity, uint, int, nint, void>)funcTable[2])(category, severity, id, length, (nint)buf);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageInsertAMD(GLEnum category, GLDebugSeverity severity, uint id, int length, byte* buf)
		{
			DebugMessageInsertAMDNative(category, severity, id, length, buf);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageInsertAMD(GLEnum category, GLDebugSeverity severity, uint id, int length, string buf)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (buf != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(buf);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(buf, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			DebugMessageInsertAMDNative(category, severity, id, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageInsertAMD(GLEnum category, GLDebugSeverity severity, uint id, int length, Span<byte> buf)
		{
			fixed (byte* pbuf0 = buf)
			{
				DebugMessageInsertAMDNative(category, severity, id, length, pbuf0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static void DebugMessageInsertAMD(GLEnum category, GLDebugSeverity severity, uint id, int length, ref byte buf)
		{
			fixed (byte* pbuf0 = &buf)
			{
				DebugMessageInsertAMDNative(category, severity, id, length, pbuf0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint GetDebugMessageLogAMDNative(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, int* lengths, byte* message)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, int, GLEnum*, GLDebugSeverity, uint*, int*, byte*, uint>)funcTable[3])(count, bufSize, categories, severities, ids, lengths, message);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<uint, int, nint, GLDebugSeverity, nint, nint, nint, uint>)funcTable[3])(count, bufSize, (nint)categories, severities, (nint)ids, (nint)lengths, (nint)message);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, int* lengths, byte* message)
		{
			uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, lengths, message);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, uint* ids, int* lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, lengths, message);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, uint* ids, int* lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, lengths, message);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, Span<uint> ids, int* lengths, byte* message)
		{
			fixed (uint* pids0 = ids)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, lengths, message);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, ref uint ids, int* lengths, byte* message)
		{
			fixed (uint* pids0 = &ids)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, lengths, message);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, Span<uint> ids, int* lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				fixed (uint* pids1 = ids)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, lengths, message);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, ref uint ids, int* lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				fixed (uint* pids1 = &ids)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, lengths, message);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, Span<int> lengths, byte* message)
		{
			fixed (int* plengths0 = lengths)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, plengths0, message);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, ref int lengths, byte* message)
		{
			fixed (int* plengths0 = &lengths)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, plengths0, message);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, uint* ids, Span<int> lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				fixed (int* plengths1 = lengths)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, plengths1, message);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, uint* ids, ref int lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				fixed (int* plengths1 = &lengths)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, plengths1, message);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, Span<uint> ids, Span<int> lengths, byte* message)
		{
			fixed (uint* pids0 = ids)
			{
				fixed (int* plengths1 = lengths)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, plengths1, message);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, ref uint ids, ref int lengths, byte* message)
		{
			fixed (uint* pids0 = &ids)
			{
				fixed (int* plengths1 = &lengths)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, plengths1, message);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, Span<uint> ids, Span<int> lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				fixed (uint* pids1 = ids)
				{
					fixed (int* plengths2 = lengths)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, plengths2, message);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, ref uint ids, ref int lengths, byte* message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				fixed (uint* pids1 = &ids)
				{
					fixed (int* plengths2 = &lengths)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, plengths2, message);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, int* lengths, string message)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (message != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(message);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(message, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, lengths, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, int* lengths, Span<byte> message)
		{
			fixed (byte* pmessage0 = message)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, lengths, pmessage0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, int* lengths, ref byte message)
		{
			fixed (byte* pmessage0 = &message)
			{
				uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, lengths, pmessage0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, uint* ids, int* lengths, Span<byte> message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				fixed (byte* pmessage1 = message)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, lengths, pmessage1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, uint* ids, int* lengths, ref byte message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				fixed (byte* pmessage1 = &message)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, lengths, pmessage1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, Span<uint> ids, int* lengths, Span<byte> message)
		{
			fixed (uint* pids0 = ids)
			{
				fixed (byte* pmessage1 = message)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, lengths, pmessage1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, ref uint ids, int* lengths, ref byte message)
		{
			fixed (uint* pids0 = &ids)
			{
				fixed (byte* pmessage1 = &message)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, lengths, pmessage1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, Span<uint> ids, int* lengths, Span<byte> message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				fixed (uint* pids1 = ids)
				{
					fixed (byte* pmessage2 = message)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, lengths, pmessage2);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, ref uint ids, int* lengths, ref byte message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				fixed (uint* pids1 = &ids)
				{
					fixed (byte* pmessage2 = &message)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, lengths, pmessage2);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, Span<int> lengths, Span<byte> message)
		{
			fixed (int* plengths0 = lengths)
			{
				fixed (byte* pmessage1 = message)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, plengths0, pmessage1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, uint* ids, ref int lengths, ref byte message)
		{
			fixed (int* plengths0 = &lengths)
			{
				fixed (byte* pmessage1 = &message)
				{
					uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, ids, plengths0, pmessage1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, uint* ids, Span<int> lengths, Span<byte> message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				fixed (int* plengths1 = lengths)
				{
					fixed (byte* pmessage2 = message)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, plengths1, pmessage2);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, uint* ids, ref int lengths, ref byte message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				fixed (int* plengths1 = &lengths)
				{
					fixed (byte* pmessage2 = &message)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, ids, plengths1, pmessage2);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, Span<uint> ids, Span<int> lengths, Span<byte> message)
		{
			fixed (uint* pids0 = ids)
			{
				fixed (int* plengths1 = lengths)
				{
					fixed (byte* pmessage2 = message)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, plengths1, pmessage2);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, GLEnum* categories, GLDebugSeverity severities, ref uint ids, ref int lengths, ref byte message)
		{
			fixed (uint* pids0 = &ids)
			{
				fixed (int* plengths1 = &lengths)
				{
					fixed (byte* pmessage2 = &message)
					{
						uint ret = GetDebugMessageLogAMDNative(count, bufSize, categories, severities, pids0, plengths1, pmessage2);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, Span<GLEnum> categories, GLDebugSeverity severities, Span<uint> ids, Span<int> lengths, Span<byte> message)
		{
			fixed (GLEnum* pcategories0 = categories)
			{
				fixed (uint* pids1 = ids)
				{
					fixed (int* plengths2 = lengths)
					{
						fixed (byte* pmessage3 = message)
						{
							uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, plengths2, pmessage3);
							return ret;
						}
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_AMD_debug_output</remarks>
		public static uint GetDebugMessageLogAMD(uint count, int bufSize, ref GLEnum categories, GLDebugSeverity severities, ref uint ids, ref int lengths, ref byte message)
		{
			fixed (GLEnum* pcategories0 = &categories)
			{
				fixed (uint* pids1 = &ids)
				{
					fixed (int* plengths2 = &lengths)
					{
						fixed (byte* pmessage3 = &message)
						{
							uint ret = GetDebugMessageLogAMDNative(count, bufSize, pcategories0, severities, pids1, plengths2, pmessage3);
							return ret;
						}
					}
				}
			}
		}

	}
}
