namespace SourceLinkTest;

public static class Class1
{
    public static bool ParseSomething(string? text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));

        var result = text.Equals("yes", StringComparison.OrdinalIgnoreCase) || text.Equals("ja", StringComparison.OrdinalIgnoreCase)
            ? true : false;

        return result;
    }
}
