// See https://aka.ms/new-console-template for more information

using System.Numerics;

public struct Vertex
{
    public Vector3 Pos;
    public Vector4 Color;

    public Vertex(Vector3 pos, Vector4 color)
    {
        Pos = pos;
        Color = color;
    }
}