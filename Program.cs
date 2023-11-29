using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    if (string.IsNullOrEmpty(phrase))
    {
        return phrase;
    }

    var words = phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length > 0)
        {
            words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1);
        }
    }

    return String.Join(" ", words);
    }
}
