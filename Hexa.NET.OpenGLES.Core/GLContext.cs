namespace Hexa.NET.OpenGLES
{
    using HexaGen.Runtime;

    public class GLContext : IDisposable
    {
        public FunctionTable? Table;
        public Dictionary<string, FunctionTable> ExtensionTables = [];
        public INativeContext Context;

        public GLContext(INativeContext context)
        {
            Context = context;
        }

        public FunctionTable GetOrAddExtension(string name, int length, Action<FunctionTable> initTable)
        {
            if (!ExtensionTables.TryGetValue(name, out var table))
            {
                table = new(Context, length);
                initTable(table);
                ExtensionTables.Add(name, table);
            }

            return table;
        }

        public FunctionTable? GetExtension(string name)
        {
            ExtensionTables.TryGetValue(name, out var table);
            return table;
        }

        public void Dispose()
        {
            Table?.Dispose();
            foreach (var extension in ExtensionTables)
            {
                extension.Value.Dispose();
            }
            ExtensionTables.Clear();
            Context.Dispose();

            GC.SuppressFinalize(this);
        }

        public bool IsExtensionSupported(string extensionName)
        {
            return Context.IsExtensionSupported(extensionName);
        }

        public bool DeleteExtension(string extensionName)
        {
            if (ExtensionTables.TryGetValue(extensionName, out var table))
            {
                ExtensionTables.Remove(extensionName);
                table.Dispose();
                return true;
            }
            return false;
        }
    }
}