namespace BBP;

/// <summary>
///     Compare BBPResult objects to sort a list of BBPResult objects.
/// </summary>
public class BBPResultComparer : IComparer<BBPResult>
{
    public int Compare(BBPResult? x, BBPResult? y)
    {
        return x switch
        {
            null when y is null => 0,
            null => -1,
            not null when y is null => 1,
            _ => x!.Digit.CompareTo(value: y!.Digit),
        };
    }
}
