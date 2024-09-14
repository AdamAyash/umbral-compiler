namespace UmbralCompiler.CodeAnalysis
{
    public enum SyntaxKind
    {
        BadToken,
        EndOfFileToken,
        WhiteSpaceToken,
        NumberToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenParanthesisToken,
        CloseParanthesisToken,
        
        //Expressions
        NumberExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}

