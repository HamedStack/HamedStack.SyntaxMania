using HamedStack.SyntaxMania.Node;
using HamedStack.SyntaxMania.Types;

namespace HamedStack.SyntaxMania.Parser;

public class ParserResult<TToken> where TToken : Enum
{
    public IEnumerable<Error>? Errors { get; internal set; }
    public AstNode<TToken>? Result { get; internal set; }
}