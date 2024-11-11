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
	public unsafe partial class GLARBSampleLocations : GLExtension, IDisposable
	{
		public const string ExtensionName = "GL_ARB_sample_locations";

		public GLARBSampleLocations() : base(3)
		{
		}

		public override bool IsSupported(IGLContext context)
		{
			return context.IsExtensionSupported(ExtensionName);
		}

		protected override void InitTable(FunctionTable funcTable)
		{
			funcTable.Load(0, "glEvaluateDepthValuesARB");
			funcTable.Load(1, "glFramebufferSampleLocationsfvARB");
			funcTable.Load(2, "glNamedFramebufferSampleLocationsfvARB");
		}

		public void Dispose()
		{
			funcTable.Dispose();
		}
	}
}
