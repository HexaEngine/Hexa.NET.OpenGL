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
	public unsafe partial class GLARBShaderStorageBufferObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ShaderStorageBlockBindingNative(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, void>)funcTable[0])(program, storageBlockIndex, storageBlockBinding);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, void>)funcTable[0])(program, storageBlockIndex, storageBlockBinding);
			#endif
		}

		/// <summary>
		/// Change an active shader storage block binding
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.3 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_shader_storage_buffer_object</remarks>
		public void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			ShaderStorageBlockBindingNative(program, storageBlockIndex, storageBlockBinding);
		}

	}
}
