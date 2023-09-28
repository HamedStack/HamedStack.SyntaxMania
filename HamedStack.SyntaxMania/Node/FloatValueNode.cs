// ReSharper disable UnusedMember.Global
namespace HamedStack.SyntaxMania.Node;

public class FloatValueNode<TToken> : AstNode<TToken> where TToken : Enum
{
    public TToken Token { get; set; }
    public float Value { get; set; }

    public FloatValueNode(TToken token, float value)
    {
        Token = token;
        Value = value;
    }
}