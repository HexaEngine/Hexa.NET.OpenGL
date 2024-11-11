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
	public unsafe partial class GLARBDebugOutput
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DebugMessageCallbackARBNative(GLDebugProcARB callback, void* userParam)
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
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageCallbackARB(GLDebugProcARB callback, void* userParam)
		{
			DebugMessageCallbackARBNative(callback, userParam);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageCallbackARB(GLDebugProcARB callback, nint userParam)
		{
			DebugMessageCallbackARBNative(callback, (void*)userParam);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageCallbackARB<TUserParam>(GLDebugProcARB callback, Span<TUserParam> userParam) where TUserParam : unmanaged
		{
			fixed (TUserParam* puserParam0 = userParam)
			{
				DebugMessageCallbackARBNative(callback, puserParam0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DebugMessageControlARBNative(GLDebugSource source, GLDebugType type, GLDebugSeverity severity, int count, uint* ids, bool enabled)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLDebugSource, GLDebugType, GLDebugSeverity, int, uint*, byte, void>)funcTable[1])(source, type, severity, count, ids, *((byte*)(&enabled)));
			#else
			((delegate* unmanaged[Cdecl]<GLDebugSource, GLDebugType, GLDebugSeverity, int, nint, byte, void>)funcTable[1])(source, type, severity, count, (nint)ids, *((byte*)(&enabled)));
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageControlARB(GLDebugSource source, GLDebugType type, GLDebugSeverity severity, int count, uint* ids, bool enabled)
		{
			DebugMessageControlARBNative(source, type, severity, count, ids, enabled);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageControlARB(GLDebugSource source, GLDebugType type, GLDebugSeverity severity, int count, Span<uint> ids, bool enabled)
		{
			fixed (uint* pids0 = ids)
			{
				DebugMessageControlARBNative(source, type, severity, count, pids0, enabled);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageControlARB(GLDebugSource source, GLDebugType type, GLDebugSeverity severity, int count, ref uint ids, bool enabled)
		{
			fixed (uint* pids0 = &ids)
			{
				DebugMessageControlARBNative(source, type, severity, count, pids0, enabled);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void DebugMessageInsertARBNative(GLDebugSource source, GLDebugType type, uint id, GLDebugSeverity severity, int length, byte* buf)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLDebugSource, GLDebugType, uint, GLDebugSeverity, int, byte*, void>)funcTable[2])(source, type, id, severity, length, buf);
			#else
			((delegate* unmanaged[Cdecl]<GLDebugSource, GLDebugType, uint, GLDebugSeverity, int, nint, void>)funcTable[2])(source, type, id, severity, length, (nint)buf);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageInsertARB(GLDebugSource source, GLDebugType type, uint id, GLDebugSeverity severity, int length, byte* buf)
		{
			DebugMessageInsertARBNative(source, type, id, severity, length, buf);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageInsertARB(GLDebugSource source, GLDebugType type, uint id, GLDebugSeverity severity, int length, string buf)
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
			DebugMessageInsertARBNative(source, type, id, severity, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageInsertARB(GLDebugSource source, GLDebugType type, uint id, GLDebugSeverity severity, int length, Span<byte> buf)
		{
			fixed (byte* pbuf0 = buf)
			{
				DebugMessageInsertARBNative(source, type, id, severity, length, pbuf0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public void DebugMessageInsertARB(GLDebugSource source, GLDebugType type, uint id, GLDebugSeverity severity, int length, ref byte buf)
		{
			fixed (byte* pbuf0 = &buf)
			{
				DebugMessageInsertARBNative(source, type, id, severity, length, pbuf0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal uint GetDebugMessageLogARBNative(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, int* lengths, byte* messageLog)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<uint, int, GLDebugSource, GLDebugType, uint*, GLDebugSeverity, int*, byte*, uint>)funcTable[3])(count, bufSize, sources, types, ids, severities, lengths, messageLog);
			#else
			return (uint)((delegate* unmanaged[Cdecl]<uint, int, GLDebugSource, GLDebugType, nint, GLDebugSeverity, nint, nint, uint>)funcTable[3])(count, bufSize, sources, types, (nint)ids, severities, (nint)lengths, (nint)messageLog);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, int* lengths, byte* messageLog)
		{
			uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, lengths, messageLog);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, Span<uint> ids, GLDebugSeverity severities, int* lengths, byte* messageLog)
		{
			fixed (uint* pids0 = ids)
			{
				uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, lengths, messageLog);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, ref uint ids, GLDebugSeverity severities, int* lengths, byte* messageLog)
		{
			fixed (uint* pids0 = &ids)
			{
				uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, lengths, messageLog);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, Span<int> lengths, byte* messageLog)
		{
			fixed (int* plengths0 = lengths)
			{
				uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, plengths0, messageLog);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, ref int lengths, byte* messageLog)
		{
			fixed (int* plengths0 = &lengths)
			{
				uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, plengths0, messageLog);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, Span<uint> ids, GLDebugSeverity severities, Span<int> lengths, byte* messageLog)
		{
			fixed (uint* pids0 = ids)
			{
				fixed (int* plengths1 = lengths)
				{
					uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, plengths1, messageLog);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, ref uint ids, GLDebugSeverity severities, ref int lengths, byte* messageLog)
		{
			fixed (uint* pids0 = &ids)
			{
				fixed (int* plengths1 = &lengths)
				{
					uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, plengths1, messageLog);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, int* lengths, string messageLog)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (messageLog != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(messageLog);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(messageLog, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, lengths, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, int* lengths, Span<byte> messageLog)
		{
			fixed (byte* pmessageLog0 = messageLog)
			{
				uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, lengths, pmessageLog0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, int* lengths, ref byte messageLog)
		{
			fixed (byte* pmessageLog0 = &messageLog)
			{
				uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, lengths, pmessageLog0);
				return ret;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, Span<uint> ids, GLDebugSeverity severities, int* lengths, Span<byte> messageLog)
		{
			fixed (uint* pids0 = ids)
			{
				fixed (byte* pmessageLog1 = messageLog)
				{
					uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, lengths, pmessageLog1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, ref uint ids, GLDebugSeverity severities, int* lengths, ref byte messageLog)
		{
			fixed (uint* pids0 = &ids)
			{
				fixed (byte* pmessageLog1 = &messageLog)
				{
					uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, lengths, pmessageLog1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, Span<int> lengths, Span<byte> messageLog)
		{
			fixed (int* plengths0 = lengths)
			{
				fixed (byte* pmessageLog1 = messageLog)
				{
					uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, plengths0, pmessageLog1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, uint* ids, GLDebugSeverity severities, ref int lengths, ref byte messageLog)
		{
			fixed (int* plengths0 = &lengths)
			{
				fixed (byte* pmessageLog1 = &messageLog)
				{
					uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, ids, severities, plengths0, pmessageLog1);
					return ret;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, Span<uint> ids, GLDebugSeverity severities, Span<int> lengths, Span<byte> messageLog)
		{
			fixed (uint* pids0 = ids)
			{
				fixed (int* plengths1 = lengths)
				{
					fixed (byte* pmessageLog2 = messageLog)
					{
						uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, plengths1, pmessageLog2);
						return ret;
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_debug_output</remarks>
		public uint GetDebugMessageLogARB(uint count, int bufSize, GLDebugSource sources, GLDebugType types, ref uint ids, GLDebugSeverity severities, ref int lengths, ref byte messageLog)
		{
			fixed (uint* pids0 = &ids)
			{
				fixed (int* plengths1 = &lengths)
				{
					fixed (byte* pmessageLog2 = &messageLog)
					{
						uint ret = GetDebugMessageLogARBNative(count, bufSize, sources, types, pids0, severities, plengths1, pmessageLog2);
						return ret;
					}
				}
			}
		}

	}
}
