namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if(amount == 0)
        {
            return 0;
        }
        var value = amount.ToString("N2")
            .Replace(".", "")
            .Replace(",", "");

        _ = int.TryParse(value, out var result);

        return result;
    }
}
