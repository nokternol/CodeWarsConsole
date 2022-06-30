namespace CodeWars.Kata
{
    /// <summary>
    /// Trolls are attacking your comment section!
    /// A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
    /// Your task is to write a function that takes a string and return a new string with all vowels removed.
    /// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
    /// </summary>
    public static class DisemvowelTrolls
    {
        public static readonly char[] vowelChars = new[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };      
        public static string Disemvowel(string str)
        {
            static bool IsVowel(char c) => vowelChars.Contains(c);
            return new string(str.Where(c => !IsVowel(c)).ToArray());
        }
    }
}
