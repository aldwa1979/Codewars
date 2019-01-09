namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        int x = input.Length;
            string str = input.Replace(" ", string.Empty);
            return str;
    }  
  }
}
