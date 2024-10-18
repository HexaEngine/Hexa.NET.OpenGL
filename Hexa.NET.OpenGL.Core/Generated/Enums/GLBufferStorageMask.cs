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
using System.Numerics;

namespace Hexa.NET.OpenGL
{
	/// <summary>
	/// GL_MAP_{COHERENT,PERSISTENT,READ,WRITE}_{BIT,BIT_EXT} also lie in this namespace<br/>
	/// </summary>
	public enum GLBufferStorageMask : uint
	{
		/// <summary>
		/// Indicates dynamic storage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage</remarks>
		DynamicStorageBit = unchecked((uint)0x0100),

		/// <summary>
		/// Dynamic storage for extensions.
		/// </summary>
		/// <remarks></remarks>
		DynamicStorageBitExt = unchecked((uint)0x0100),

		/// <summary>
		/// Indicates client-side storage.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage</remarks>
		ClientStorageBit = unchecked((uint)0x0200),

		/// <summary>
		/// Client storage for extensions.
		/// </summary>
		/// <remarks></remarks>
		ClientStorageBitExt = unchecked((uint)0x0200),

		/// <summary>
		/// Sparse storage for ARB.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_sparse_buffer</remarks>
		SparseStorageBitArb = unchecked((uint)0x0400),

		/// <summary>
		/// Separate storage for LGPU.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NVX_linked_gpu_multicast</remarks>
		LgpuSeparateStorageBitNvx = unchecked((uint)0x0800),

		/// <summary>
		/// Per-GPU storage for NV.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_NV_gpu_multicast</remarks>
		PerGpuStorageBitNv = unchecked((uint)0x0800),

		/// <summary>
		/// External storage for NVX.
		/// </summary>
		/// <remarks></remarks>
		ExternalStorageBitNvx = unchecked((uint)0x2000),

		/// <summary>
		/// Allows mapping for read access.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage<br/>GL_ARB_map_buffer_range</remarks>
		MapReadBit = unchecked((uint)0x0001),

		/// <summary>
		/// Read access mapping for extensions.
		/// </summary>
		/// <remarks></remarks>
		MapReadBitExt = unchecked((uint)0x0001),

		/// <summary>
		/// Allows mapping for write access.
		/// </summary>
		/// <remarks>Supported Versions: All GL versions.<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage<br/>GL_ARB_map_buffer_range</remarks>
		MapWriteBit = unchecked((uint)0x0002),

		/// <summary>
		/// Write access mapping for extensions.
		/// </summary>
		/// <remarks></remarks>
		MapWriteBitExt = unchecked((uint)0x0002),

		/// <summary>
		/// Indicates persistent mapping.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage</remarks>
		MapPersistentBit = unchecked((uint)0x0040),

		/// <summary>
		/// Persistent mapping for extensions.
		/// </summary>
		/// <remarks></remarks>
		MapPersistentBitExt = unchecked((uint)0x0040),

		/// <summary>
		/// Indicates coherent mapping.
		/// </summary>
		/// <remarks>Supported Versions:<br/>GL 4.4 - GL 4.6<br/><br/>Used by Extensions:<br/>GL_ARB_buffer_storage</remarks>
		MapCoherentBit = unchecked((uint)0x0080),

		/// <summary>
		/// Coherent mapping for extensions.
		/// </summary>
		/// <remarks></remarks>
		MapCoherentBitExt = unchecked((uint)0x0080),
	}
}
