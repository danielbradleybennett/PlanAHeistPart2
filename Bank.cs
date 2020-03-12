namespace HeistPart2
{
  public class Bank
  {
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }

    public int VaultScore { get; set; }

    public int SecurityGuardScore { get; set; }

    public bool IsSecure
    {
      get
      {
        if (AlarmScore + CashOnHand + VaultScore + SecurityGuardScore <= 0)
        { return false; }
        else
        { return true; }

      }

    }

  }

}