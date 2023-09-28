// ReSharper disable UnusedMember.Global
namespace HamedStack.SyntaxMania.Node;

public class CharValueNode<TToken> : AstNode<TToken> where TToken : Enum
{
    public TToken Token { get; set; }
    public char Value { get; set; }

    public CharValueNode(TToken token, char value)
    {
        Token = token;
        Value = value;
    }
}