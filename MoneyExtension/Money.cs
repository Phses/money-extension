namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if(amount == 0)
        {
            return 0;
        }
        var str = amount.ToString().Replace(".", "").Replace(",", "");

        _ = int.TryParse(str, out var result);

        return result;
    }
}
