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

namespace Hexa.NET.OpenGL.ARB
{
	public unsafe partial class GLARBPointParameters : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_point_parameters";

		public GLARBPointParameters() : base(2)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glPointParameterfARB");
			funcTable.Load(1, "glPointParameterfvARB");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
