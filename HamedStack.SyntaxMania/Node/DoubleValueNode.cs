// ReSharper disable UnusedMember.Global
namespace HamedStack.SyntaxMania.Node;

public class DoubleValueNode<TToken> : AstNode<TToken> where TToken : Enum
{
    public TToken Token { get; set; }
    public double Value { get; set; }

    public DoubleValueNode(TToken token, double value)
    {
        Token = token;
        Value = value;
    }
}