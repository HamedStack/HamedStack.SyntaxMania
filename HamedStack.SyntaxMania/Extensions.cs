// ReSharper disable UnusedMember.Global

using System.Text.RegularExpressions;

namespace HamedStack.SyntaxMania;

public static class Extensions
{
    public static bool IsRegexMatch(this string input, string regex)
    {
        return Regex.Match(input, regex, RegexOptions.Compiled).Success;
    }

    public static bool IsRegexMatch(this string input, Regex regex)
    {
        return regex.Match(input).Success;
    }
}