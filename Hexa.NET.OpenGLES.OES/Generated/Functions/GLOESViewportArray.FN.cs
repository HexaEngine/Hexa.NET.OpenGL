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
using Hexa.NET.OpenGLES;

namespace Hexa.NET.OpenGLES.OES
{
	public unsafe partial class GLOESViewportArray : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_OES_viewport_array";

		public GLOESViewportArray() : base(12)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glDepthRangeArrayfvOES");
			funcTable.Load(1, "glDepthRangeIndexedfOES");
			funcTable.Load(2, "glDisableiOES");
			funcTable.Load(3, "glEnableiOES");
			funcTable.Load(4, "glGetFloati_vOES");
			funcTable.Load(5, "glIsEnablediOES");
			funcTable.Load(6, "glScissorArrayvOES");
			funcTable.Load(7, "glScissorIndexedOES");
			funcTable.Load(8, "glScissorIndexedvOES");
			funcTable.Load(9, "glViewportArrayvOES");
			funcTable.Load(10, "glViewportIndexedfOES");
			funcTable.Load(11, "glViewportIndexedfvOES");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
