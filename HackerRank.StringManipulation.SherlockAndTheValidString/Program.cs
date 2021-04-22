using System;
using System.Collections.Generic;

namespace HackerRank.StringManipulation.SherlockAndTheValidString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isValid("a"));
            Console.WriteLine(isValid("aa"));
            Console.WriteLine(isValid("ab"));
            Console.WriteLine(isValid("abc"));
            Console.WriteLine(isValid("abcc"));
            Console.WriteLine(isValid("abccc"));
            Console.WriteLine(isValid("aabbcd"));
            Console.WriteLine(isValid("aabbccddeefghi"));
            Console.WriteLine(isValid("abcdefghhgfedecba"));
            Console.WriteLine(isValid("ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd"));
        }

        static string isValid(string s)
        {
            var hashtable = new Dictionary<char, int>();
            foreach(var character in s)
            {
                if (hashtable.ContainsKey(character))
                {
                    hashtable[character]++;
                }
                else
                {
                    hashtable.Add(character, 1);
                }
            }

            var isOneCharacterRemoved = false;
            var currentFrequency = -1;

            foreach(var keyValuePair in hashtable)
            {
                if(currentFrequency == -1)
                {
                    currentFrequency = keyValuePair.Value;
                    continue;
                }

                if(keyValuePair.Value != currentFrequency)
                {
                    if(isOneCharacterRemoved || (Math.Abs(keyValuePair.Value - currentFrequency) > 1 && keyValuePair.Value != 1 && currentFrequency != 1))
                    {
                        return "NO";
                    }
                    else
                    {
                        isOneCharacterRemoved = true;
                    }
                }
            }

            return "YES";
        }
    }
}
