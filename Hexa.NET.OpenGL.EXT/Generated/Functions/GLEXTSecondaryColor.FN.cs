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
using Hexa.NET.OpenGL;

namespace Hexa.NET.OpenGL.EXT
{
	public unsafe partial class GLEXTSecondaryColor
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		/// <summary>
		/// Initializes the function table of the extension, call before you access any function.
		/// </summary>
		public static void InitExtension()
		{
			if (funcTable != null) return;
			if (GLBase.NativeContext == null) throw new InvalidOperationException("OpenGL is not initialized, call GL.InitApi.");
			funcTable = new FunctionTable(GLBase.NativeContext, 17);
			funcTable.Load(0, "glSecondaryColor3bEXT");
			funcTable.Load(1, "glSecondaryColor3bvEXT");
			funcTable.Load(2, "glSecondaryColor3dEXT");
			funcTable.Load(3, "glSecondaryColor3dvEXT");
			funcTable.Load(4, "glSecondaryColor3fEXT");
			funcTable.Load(5, "glSecondaryColor3fvEXT");
			funcTable.Load(6, "glSecondaryColor3iEXT");
			funcTable.Load(7, "glSecondaryColor3ivEXT");
			funcTable.Load(8, "glSecondaryColor3sEXT");
			funcTable.Load(9, "glSecondaryColor3svEXT");
			funcTable.Load(10, "glSecondaryColor3ubEXT");
			funcTable.Load(11, "glSecondaryColor3ubvEXT");
			funcTable.Load(12, "glSecondaryColor3uiEXT");
			funcTable.Load(13, "glSecondaryColor3uivEXT");
			funcTable.Load(14, "glSecondaryColor3usEXT");
			funcTable.Load(15, "glSecondaryColor3usvEXT");
			funcTable.Load(16, "glSecondaryColorPointerEXT");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
