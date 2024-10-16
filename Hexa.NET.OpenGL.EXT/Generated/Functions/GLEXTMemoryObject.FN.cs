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
	public unsafe partial class GLEXTMemoryObject
	{
		internal static FunctionTable funcTable;

		public static bool Initialized => funcTable != null;

		public static bool IsSupported => GLBase.NativeContext.IsExtensionSupported(ExtensionName);

		public const string ExtensionName = "GL_EXT_memory_object";

		/// <summary>
		/// Tries to initialize the function table of the extension, call before you access any function.
		/// </summary>
		/// <returns>Returns <c>true</c> if successful, <c>false</c> if extension is not supported.</returns>
		public static bool TryInitExtension()
		{
			if (!IsSupported) return false;
			InitExtension();
			return true;
		}

		/// <summary>
		/// Initializes the function table of the extension, call before you access any function.
		/// </summary>
		public static void InitExtension()
		{
			if (funcTable != null) return;
			if (GLBase.NativeContext == null) throw new InvalidOperationException("OpenGL is not initialized, call GL.InitApi.");
			funcTable = new FunctionTable(GLBase.NativeContext, 19);
			funcTable.Load(0, "glBufferStorageMemEXT");
			funcTable.Load(1, "glCreateMemoryObjectsEXT");
			funcTable.Load(2, "glDeleteMemoryObjectsEXT");
			funcTable.Load(3, "glGetMemoryObjectParameterivEXT");
			funcTable.Load(4, "glGetUnsignedBytevEXT");
			funcTable.Load(5, "glGetUnsignedBytei_vEXT");
			funcTable.Load(6, "glIsMemoryObjectEXT");
			funcTable.Load(7, "glMemoryObjectParameterivEXT");
			funcTable.Load(8, "glNamedBufferStorageMemEXT");
			funcTable.Load(9, "glTexStorageMem1DEXT");
			funcTable.Load(10, "glTexStorageMem2DEXT");
			funcTable.Load(11, "glTexStorageMem2DMultisampleEXT");
			funcTable.Load(12, "glTexStorageMem3DEXT");
			funcTable.Load(13, "glTexStorageMem3DMultisampleEXT");
			funcTable.Load(14, "glTextureStorageMem1DEXT");
			funcTable.Load(15, "glTextureStorageMem2DEXT");
			funcTable.Load(16, "glTextureStorageMem2DMultisampleEXT");
			funcTable.Load(17, "glTextureStorageMem3DEXT");
			funcTable.Load(18, "glTextureStorageMem3DMultisampleEXT");
		}

		public static void FreeExtension()
		{
			if (funcTable == null) return;
			funcTable.Free();
			funcTable = null;
		}
	}
}
