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

namespace Hexa.NET.OpenGLES.OES
{
	public unsafe partial class GLOESPointSizeArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void PointSizePointerOESNative(GLEnum type, int stride, void* pointer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<GLEnum, int, void*, void>)funcTable[0])(type, stride, pointer);
			#else
			((delegate* unmanaged[Cdecl]<GLEnum, int, nint, void>)funcTable[0])(type, stride, (nint)pointer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_point_size_array</remarks>
		public void PointSizePointerOES(GLEnum type, int stride, void* pointer)
		{
			PointSizePointerOESNative(type, stride, pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_point_size_array</remarks>
		public void PointSizePointerOES(GLEnum type, int stride, nint pointer)
		{
			PointSizePointerOESNative(type, stride, (void*)pointer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_OES_point_size_array</remarks>
		public void PointSizePointerOES<TPointer>(GLEnum type, int stride, Span<TPointer> pointer) where TPointer : unmanaged
		{
			fixed (TPointer* ppointer0 = pointer)
			{
				PointSizePointerOESNative(type, stride, ppointer0);
			}
		}

	}
}
