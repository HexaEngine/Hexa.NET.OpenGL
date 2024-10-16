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
	public static unsafe partial class GLAMDPerformanceMonitor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BeginPerfMonitorAMDNative(uint monitor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(monitor);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[0])(monitor);
			#endif
		}

		public static void BeginPerfMonitorAMD(uint monitor)
		{
			BeginPerfMonitorAMDNative(monitor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DeletePerfMonitorsAMDNative(int n, uint* monitors)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[1])(n, monitors);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[1])(n, (nint)monitors);
			#endif
		}

		public static void DeletePerfMonitorsAMD(int n, uint* monitors)
		{
			DeletePerfMonitorsAMDNative(n, monitors);
		}

		public static void DeletePerfMonitorsAMD(int n, ref uint monitors)
		{
			fixed (uint* pmonitors0 = &monitors)
			{
				DeletePerfMonitorsAMDNative(n, pmonitors0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EndPerfMonitorAMDNative(uint monitor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[2])(monitor);
			#else
			((delegate* unmanaged[Cdecl]<uint, void>)funcTable[2])(monitor);
			#endif
		}

		public static void EndPerfMonitorAMD(uint monitor)
		{
			EndPerfMonitorAMDNative(monitor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GenPerfMonitorsAMDNative(int n, uint* monitors)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int, uint*, void>)funcTable[3])(n, monitors);
			#else
			((delegate* unmanaged[Cdecl]<int, nint, void>)funcTable[3])(n, (nint)monitors);
			#endif
		}

		public static void GenPerfMonitorsAMD(int n, uint* monitors)
		{
			GenPerfMonitorsAMDNative(n, monitors);
		}

		public static void GenPerfMonitorsAMD(int n, ref uint monitors)
		{
			fixed (uint* pmonitors0 = &monitors)
			{
				GenPerfMonitorsAMDNative(n, pmonitors0);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPerfMonitorCounterDataAMDNative(uint monitor, GLEnum pname, int dataSize, uint* data, int* bytesWritten)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, uint*, int*, void>)funcTable[4])(monitor, pname, dataSize, data, bytesWritten);
			#else
			((delegate* unmanaged[Cdecl]<uint, GLEnum, int, nint, nint, void>)funcTable[4])(monitor, pname, dataSize, (nint)data, (nint)bytesWritten);
			#endif
		}

		public static void GetPerfMonitorCounterDataAMD(uint monitor, GLEnum pname, int dataSize, uint* data, int* bytesWritten)
		{
			GetPerfMonitorCounterDataAMDNative(monitor, pname, dataSize, data, bytesWritten);
		}

		public static void GetPerfMonitorCounterDataAMD(uint monitor, GLEnum pname, int dataSize, ref uint data, int* bytesWritten)
		{
			fixed (uint* pdata0 = &data)
			{
				GetPerfMonitorCounterDataAMDNative(monitor, pname, dataSize, pdata0, bytesWritten);
			}
		}

		public static void GetPerfMonitorCounterDataAMD(uint monitor, GLEnum pname, int dataSize, uint* data, ref int bytesWritten)
		{
			fixed (int* pbytesWritten0 = &bytesWritten)
			{
				GetPerfMonitorCounterDataAMDNative(monitor, pname, dataSize, data, pbytesWritten0);
			}
		}

		public static void GetPerfMonitorCounterDataAMD(uint monitor, GLEnum pname, int dataSize, ref uint data, ref int bytesWritten)
		{
			fixed (uint* pdata0 = &data)
			{
				fixed (int* pbytesWritten1 = &bytesWritten)
				{
					GetPerfMonitorCounterDataAMDNative(monitor, pname, dataSize, pdata0, pbytesWritten1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPerfMonitorCounterInfoAMDNative(uint group, uint counter, GLEnum pname, void* data)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, void*, void>)funcTable[5])(group, counter, pname, data);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, GLEnum, nint, void>)funcTable[5])(group, counter, pname, (nint)data);
			#endif
		}

		public static void GetPerfMonitorCounterInfoAMD(uint group, uint counter, GLEnum pname, void* data)
		{
			GetPerfMonitorCounterInfoAMDNative(group, counter, pname, data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPerfMonitorCounterStringAMDNative(uint group, uint counter, int bufSize, int* length, byte* counterString)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, uint, int, int*, byte*, void>)funcTable[6])(group, counter, bufSize, length, counterString);
			#else
			((delegate* unmanaged[Cdecl]<uint, uint, int, nint, nint, void>)funcTable[6])(group, counter, bufSize, (nint)length, (nint)counterString);
			#endif
		}

		public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, byte* counterString)
		{
			GetPerfMonitorCounterStringAMDNative(group, counter, bufSize, length, counterString);
		}

		public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, ref int length, byte* counterString)
		{
			fixed (int* plength0 = &length)
			{
				GetPerfMonitorCounterStringAMDNative(group, counter, bufSize, plength0, counterString);
			}
		}

		public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, string counterString)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (counterString != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(counterString);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(counterString, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetPerfMonitorCounterStringAMDNative(group, counter, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, ReadOnlySpan<byte> counterString)
		{
			fixed (byte* pcounterString0 = counterString)
			{
				GetPerfMonitorCounterStringAMDNative(group, counter, bufSize, length, pcounterString0);
			}
		}

		public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, int* length, ref byte counterString)
		{
			fixed (byte* pcounterString0 = &counterString)
			{
				GetPerfMonitorCounterStringAMDNative(group, counter, bufSize, length, pcounterString0);
			}
		}

		public static void GetPerfMonitorCounterStringAMD(uint group, uint counter, int bufSize, ref int length, ref byte counterString)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pcounterString1 = &counterString)
				{
					GetPerfMonitorCounterStringAMDNative(group, counter, bufSize, plength0, pcounterString1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPerfMonitorCountersAMDNative(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int*, int*, int, uint*, void>)funcTable[7])(group, numCounters, maxActiveCounters, counterSize, counters);
			#else
			((delegate* unmanaged[Cdecl]<uint, nint, nint, int, nint, void>)funcTable[7])(group, (nint)numCounters, (nint)maxActiveCounters, counterSize, (nint)counters);
			#endif
		}

		public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters)
		{
			GetPerfMonitorCountersAMDNative(group, numCounters, maxActiveCounters, counterSize, counters);
		}

		public static void GetPerfMonitorCountersAMD(uint group, ref int numCounters, int* maxActiveCounters, int counterSize, uint* counters)
		{
			fixed (int* pnumCounters0 = &numCounters)
			{
				GetPerfMonitorCountersAMDNative(group, pnumCounters0, maxActiveCounters, counterSize, counters);
			}
		}

		public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, ref int maxActiveCounters, int counterSize, uint* counters)
		{
			fixed (int* pmaxActiveCounters0 = &maxActiveCounters)
			{
				GetPerfMonitorCountersAMDNative(group, numCounters, pmaxActiveCounters0, counterSize, counters);
			}
		}

		public static void GetPerfMonitorCountersAMD(uint group, ref int numCounters, ref int maxActiveCounters, int counterSize, uint* counters)
		{
			fixed (int* pnumCounters0 = &numCounters)
			{
				fixed (int* pmaxActiveCounters1 = &maxActiveCounters)
				{
					GetPerfMonitorCountersAMDNative(group, pnumCounters0, pmaxActiveCounters1, counterSize, counters);
				}
			}
		}

		public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, int* maxActiveCounters, int counterSize, ref uint counters)
		{
			fixed (uint* pcounters0 = &counters)
			{
				GetPerfMonitorCountersAMDNative(group, numCounters, maxActiveCounters, counterSize, pcounters0);
			}
		}

		public static void GetPerfMonitorCountersAMD(uint group, ref int numCounters, int* maxActiveCounters, int counterSize, ref uint counters)
		{
			fixed (int* pnumCounters0 = &numCounters)
			{
				fixed (uint* pcounters1 = &counters)
				{
					GetPerfMonitorCountersAMDNative(group, pnumCounters0, maxActiveCounters, counterSize, pcounters1);
				}
			}
		}

		public static void GetPerfMonitorCountersAMD(uint group, int* numCounters, ref int maxActiveCounters, int counterSize, ref uint counters)
		{
			fixed (int* pmaxActiveCounters0 = &maxActiveCounters)
			{
				fixed (uint* pcounters1 = &counters)
				{
					GetPerfMonitorCountersAMDNative(group, numCounters, pmaxActiveCounters0, counterSize, pcounters1);
				}
			}
		}

		public static void GetPerfMonitorCountersAMD(uint group, ref int numCounters, ref int maxActiveCounters, int counterSize, ref uint counters)
		{
			fixed (int* pnumCounters0 = &numCounters)
			{
				fixed (int* pmaxActiveCounters1 = &maxActiveCounters)
				{
					fixed (uint* pcounters2 = &counters)
					{
						GetPerfMonitorCountersAMDNative(group, pnumCounters0, pmaxActiveCounters1, counterSize, pcounters2);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPerfMonitorGroupStringAMDNative(uint group, int bufSize, int* length, byte* groupString)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, int, int*, byte*, void>)funcTable[8])(group, bufSize, length, groupString);
			#else
			((delegate* unmanaged[Cdecl]<uint, int, nint, nint, void>)funcTable[8])(group, bufSize, (nint)length, (nint)groupString);
			#endif
		}

		public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, byte* groupString)
		{
			GetPerfMonitorGroupStringAMDNative(group, bufSize, length, groupString);
		}

		public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, ref int length, byte* groupString)
		{
			fixed (int* plength0 = &length)
			{
				GetPerfMonitorGroupStringAMDNative(group, bufSize, plength0, groupString);
			}
		}

		public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, string groupString)
		{
			byte* pStr0 = null;
			int pStrSize0 = 0;
			if (groupString != null)
			{
				pStrSize0 = Utils.GetByteCountUTF8(groupString);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
				}
				else
				{
					byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
					pStr0 = pStrStack0;
				}
				int pStrOffset0 = Utils.EncodeStringUTF8(groupString, pStr0, pStrSize0);
				pStr0[pStrOffset0] = 0;
			}
			GetPerfMonitorGroupStringAMDNative(group, bufSize, length, pStr0);
			if (pStrSize0 >= Utils.MaxStackallocSize)
			{
				Utils.Free(pStr0);
			}
		}

		public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, ReadOnlySpan<byte> groupString)
		{
			fixed (byte* pgroupString0 = groupString)
			{
				GetPerfMonitorGroupStringAMDNative(group, bufSize, length, pgroupString0);
			}
		}

		public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, int* length, ref byte groupString)
		{
			fixed (byte* pgroupString0 = &groupString)
			{
				GetPerfMonitorGroupStringAMDNative(group, bufSize, length, pgroupString0);
			}
		}

		public static void GetPerfMonitorGroupStringAMD(uint group, int bufSize, ref int length, ref byte groupString)
		{
			fixed (int* plength0 = &length)
			{
				fixed (byte* pgroupString1 = &groupString)
				{
					GetPerfMonitorGroupStringAMDNative(group, bufSize, plength0, pgroupString1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void GetPerfMonitorGroupsAMDNative(int* numGroups, int groupsSize, uint* groups)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<int*, int, uint*, void>)funcTable[9])(numGroups, groupsSize, groups);
			#else
			((delegate* unmanaged[Cdecl]<nint, int, nint, void>)funcTable[9])((nint)numGroups, groupsSize, (nint)groups);
			#endif
		}

		public static void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, uint* groups)
		{
			GetPerfMonitorGroupsAMDNative(numGroups, groupsSize, groups);
		}

		public static void GetPerfMonitorGroupsAMD(ref int numGroups, int groupsSize, uint* groups)
		{
			fixed (int* pnumGroups0 = &numGroups)
			{
				GetPerfMonitorGroupsAMDNative(pnumGroups0, groupsSize, groups);
			}
		}

		public static void GetPerfMonitorGroupsAMD(int* numGroups, int groupsSize, ref uint groups)
		{
			fixed (uint* pgroups0 = &groups)
			{
				GetPerfMonitorGroupsAMDNative(numGroups, groupsSize, pgroups0);
			}
		}

		public static void GetPerfMonitorGroupsAMD(ref int numGroups, int groupsSize, ref uint groups)
		{
			fixed (int* pnumGroups0 = &numGroups)
			{
				fixed (uint* pgroups1 = &groups)
				{
					GetPerfMonitorGroupsAMDNative(pnumGroups0, groupsSize, pgroups1);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SelectPerfMonitorCountersAMDNative(uint monitor, byte enable, uint group, int numCounters, uint* counterList)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<uint, byte, uint, int, uint*, void>)funcTable[10])(monitor, enable, group, numCounters, counterList);
			#else
			((delegate* unmanaged[Cdecl]<uint, byte, uint, int, nint, void>)funcTable[10])(monitor, enable, group, numCounters, (nint)counterList);
			#endif
		}

		public static void SelectPerfMonitorCountersAMD(uint monitor, byte enable, uint group, int numCounters, uint* counterList)
		{
			SelectPerfMonitorCountersAMDNative(monitor, enable, group, numCounters, counterList);
		}

		public static void SelectPerfMonitorCountersAMD(uint monitor, byte enable, uint group, int numCounters, ref uint counterList)
		{
			fixed (uint* pcounterList0 = &counterList)
			{
				SelectPerfMonitorCountersAMDNative(monitor, enable, group, numCounters, pcounterList0);
			}
		}

	}
}
