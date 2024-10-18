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
	public static unsafe partial class GLARBComputeVariableGroupSize
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DispatchComputeGroupSizeARBNative(uint numGroupsX, uint numGroupsY, uint numGroupsZ, uint groupSizeX, uint groupSizeY, uint groupSizeZ)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, uint, uint, void>)funcTable[0])(numGroupsX, numGroupsY, numGroupsZ, groupSizeX, groupSizeY, groupSizeZ);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, uint, uint, void>)funcTable[0])(numGroupsX, numGroupsY, numGroupsZ, groupSizeX, groupSizeY, groupSizeZ);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		/// <remarks>Used by Extensions:<br/>GL_ARB_compute_variable_group_size</remarks>
		public static void DispatchComputeGroupSizeARB(uint numGroupsX, uint numGroupsY, uint numGroupsZ, uint groupSizeX, uint groupSizeY, uint groupSizeZ)
		{
			DispatchComputeGroupSizeARBNative(numGroupsX, numGroupsY, numGroupsZ, groupSizeX, groupSizeY, groupSizeZ);
		}

	}
}
