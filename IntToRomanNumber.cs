/**
 * The problem is to translate any number between 1 to 100 to roman numerals.
 * Note: instead of dictionary we can also use tuple or hashtable. 
 * Either way my solution is neat and 'outside the box'  
 */
public void RomanNumber()
{

    Dictionary<char, int> map = new Dictionary<char, int>();
    map.Add('I', 1);map.Add('V', 5);map.Add('X', 10);map.Add('L', 50);map.Add('C', 100);
    int n=1; //default
    do
    {
        Console.WriteLine("Please enter a number between 0 to 100 (included), I will translate it to roman numerals:");
        n = Convert.ToInt32(Console.ReadLine());
        if(n==0)
        {
            Console.WriteLine("0 --> none");
            continue;
        }
        if(n>100)
        {
            Console.WriteLine($"{n} is bigger than 100 ! try again...   ");
            continue;
        }
        if(n<0)
        {
            Console.WriteLine("Bye Bye");
            return;
        }
        else // n is between 1 to 100
        {
            string romanNumeral = "";
            int subN = n; // manipulate on this variable
            char addedKey = ' ';
            while (subN > 0)
            {
                int difference2sub = -1; // default
                foreach (var kvp in map.Reverse())
                {
                    int difference = subN - kvp.Value;
                    if (difference >= 0)
                    {
                        addedKey = kvp.Key;
                        difference2sub = difference;
                        break;
                    }
                }
                if (subN - difference2sub >= 0)
                {
                    romanNumeral += addedKey;
                    subN = difference2sub;
                }
            }
            romanNumeral = romanNumeral.Replace("LXXXX", "XC");
            romanNumeral = romanNumeral.Replace("XXXX", "XL");
            romanNumeral = romanNumeral.Replace("VIIII", "IX");
            romanNumeral = romanNumeral.Replace("IIII", "IV");
            Console.WriteLine($"{n} --> {romanNumeral}");
        }
        


    }
    while (n > 0);

}
