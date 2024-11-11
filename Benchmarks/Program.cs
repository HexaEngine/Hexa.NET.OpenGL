using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class Program
{
    private static void Main()
    {
        /*

| Method       | Mean     | Error     | StdDev    | Ratio | RatioSD |
|------------- |---------:|----------:|----------:|------:|--------:|
| Static       | 6.781 ns | 0.0205 ns | 0.0181 ns |  1.00 |    0.00 |
| Instanced    | 7.174 ns | 0.0955 ns | 0.0846 ns |  1.06 |    0.01 |
| ThreadStatic | 9.700 ns | 0.1138 ns | 0.1065 ns |  1.43 |    0.02 |

        We have a winner **Instanced**

         */
        var summary = BenchmarkRunner.Run<Benchmark>();
    }
}

public class Capsule<T>
{
    public T Value;
}

public unsafe partial class Benchmark
{
    private static Capsule<int> staticField = new();
    private Capsule<int> instanceField = new();

    [ThreadStatic]
    private static Capsule<int> threadStaticField;

    public Benchmark()
    {
        threadStaticField = new();
    }

    [Benchmark(Baseline = true)]
    public void Static()
    {
        staticField.Value++;
        for (int i = 0; i < 16; i++)
        {
            staticField.Value *= staticField.Value;
            staticField.Value ^= staticField.Value;
        }
    }

    [Benchmark]
    public void Instanced()
    {
        instanceField.Value++;
        for (int i = 0; i < 16; i++)
        {
            instanceField.Value *= instanceField.Value;
            instanceField.Value ^= instanceField.Value;
        }
    }

    [Benchmark]
    public void ThreadStatic()
    {
        threadStaticField.Value++;
        for (int i = 0; i < 16; i++)
        {
            threadStaticField.Value *= threadStaticField.Value;
            threadStaticField.Value ^= threadStaticField.Value;
        }
    }
}