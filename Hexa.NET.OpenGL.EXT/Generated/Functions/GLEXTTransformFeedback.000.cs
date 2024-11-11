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
	public unsafe partial class GLEXTTransformFeedback
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BeginTransformFeedbackEXTNative(GLPrimitiveType primitiveMode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void>)funcTable[0])(primitiveMode);
			#else
			((delegate* unmanaged[Cdecl]<GLPrimitiveType, void>)funcTable[0])(primitiveMode);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void BeginTransformFeedbackEXT(GLPrimitiveType primitiveMode)
		{
			BeginTransformFeedbackEXTNative(primitiveMode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindBufferBaseEXTNative(GLBufferTargetARB target, uint index, uint buffer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, void>)funcTable[1])(target, index, buffer);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, void>)funcTable[1])(target, index, buffer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void BindBufferBaseEXT(GLBufferTargetARB target, uint index, uint buffer)
		{
			BindBufferBaseEXTNative(target, index, buffer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindBufferOffsetEXTNative(GLBufferTargetARB target, uint index, uint buffer, nint offset)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, void>)funcTable[2])(target, index, buffer, offset);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, void>)funcTable[2])(target, index, buffer, offset);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void BindBufferOffsetEXT(GLBufferTargetARB target, uint index, uint buffer, nint offset)
		{
			BindBufferOffsetEXTNative(target, index, buffer, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void BindBufferRangeEXTNative(GLBufferTargetARB target, uint index, uint buffer, nint offset, nint size)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, nint, void>)funcTable[3])(target, index, buffer, offset, size);
			#else
			((delegate* unmanaged[Cdecl]<GLBufferTargetARB, uint, uint, nint, nint, void>)funcTable[3])(target, index, buffer, offset, size);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void BindBufferRangeEXT(GLBufferTargetARB target, uint index, uint buffer, nint offset, nint size)
		{
			BindBufferRangeEXTNative(target, index, buffer, offset, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void EndTransformFeedbackEXTNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[4])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[4])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void EndTransformFeedbackEXT()
		{
			EndTransformFeedbackEXTNative();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetTransformFeedbackVaryingEXTNative(uint program, uint index, int bufSize, int* length, int* size, GLAttributeType type, byte* name)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, int*, int*, GLAttributeType, byte*, void>)funcTable[5])(program, index, bufSize, length, size, type, name);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, nint, nint, GLAttributeType, nint, void>)funcTable[5])(program, index, bufSize, (nint)length, (nint)size, type, (nint)name);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, GLAttributeType type, byte* name)
		{
			GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, size, type, name);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, Span<int> length, int* size, GLAttributeType type, byte* name)
		{
			fixed (int* plength0 = length)
			{
				GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, size, type, name);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, ref int length, int* size, GLAttributeType type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, size, type, name);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, Span<int> size, GLAttributeType type, byte* name)
		{
			fixed (int* psize0 = size)
			{
				GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, psize0, type, name);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, ref int size, GLAttributeType type, byte* name)
		{
			fixed (int* psize0 = &size)
			{
				GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, psize0, type, name);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, Span<int> length, Span<int> size, GLAttributeType type, byte* name)
		{
			fixed (int* plength0 = length)
			{
				fixed (int* psize1 = size)
				{
					GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, psize1, type, name);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, ref int length, ref int size, GLAttributeType type, byte* name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, psize1, type, name);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, GLAttributeType type, string name)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (name != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(name);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(name, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, size, type, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, GLAttributeType type, Span<byte> name)
		{
			fixed (byte* pname0 = name)
			{
				GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, size, type, pname0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, GLAttributeType type, ref byte name)
		{
			fixed (byte* pname0 = &name)
			{
				GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, size, type, pname0);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, Span<int> length, int* size, GLAttributeType type, Span<byte> name)
		{
			fixed (int* plength0 = length)
			{
				fixed (byte* pname1 = name)
				{
					GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, size, type, pname1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, ref int length, int* size, GLAttributeType type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pname1 = &name)
				{
					GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, size, type, pname1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, Span<int> size, GLAttributeType type, Span<byte> name)
		{
			fixed (int* psize0 = size)
			{
				fixed (byte* pname1 = name)
				{
					GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, psize0, type, pname1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, ref int size, GLAttributeType type, ref byte name)
		{
			fixed (int* psize0 = &size)
			{
				fixed (byte* pname1 = &name)
				{
					GetTransformFeedbackVaryingEXTNative(program, index, bufSize, length, psize0, type, pname1);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, Span<int> length, Span<int> size, GLAttributeType type, Span<byte> name)
		{
			fixed (int* plength0 = length)
			{
				fixed (int* psize1 = size)
				{
					fixed (byte* pname2 = name)
					{
						GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, psize1, type, pname2);
					}
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void GetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, ref int length, ref int size, GLAttributeType type, ref byte name)
		{
			fixed (int* plength0 = &length)
			{
				fixed (int* psize1 = &size)
				{
					fixed (byte* pname2 = &name)
					{
						GetTransformFeedbackVaryingEXTNative(program, index, bufSize, plength0, psize1, type, pname2);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TransformFeedbackVaryingsEXTNative(uint program, int count, byte** varyings, GLTransformFeedbackBufferMode bufferMode)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, byte**, GLTransformFeedbackBufferMode, void>)funcTable[6])(program, count, varyings, bufferMode);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, GLTransformFeedbackBufferMode, void>)funcTable[6])(program, count, (nint)varyings, bufferMode);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_EXT_transform_feedback</remarks>
		public void TransformFeedbackVaryingsEXT(uint program, int count, byte** varyings, GLTransformFeedbackBufferMode bufferMode)
		{
			TransformFeedbackVaryingsEXTNative(program, count, varyings, bufferMode);
		}

	}
}
