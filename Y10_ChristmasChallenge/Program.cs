namespace Y10_ChristmasChallenge
{
    internal class Program
    {
        static void NaughtyNiceScore()
        {
            //StreamReader Names = new StreamReader("//hgs-fs6/users$/students/22/22zkeyan/My Documents/ChristmasNames Y10.txt");
            string listOfNames = "Alice Smith, Bob Jones, Charlie Williams, Dave Brown, Eve Davis, Jillian Miller, Karen Wilson, Larry Moore, Michael Taylor, Nancy Anderson, Oliver Thomas, Peggy Jackson, Quentin White, Roger Harris, Sally Martin, Terry Thompson, Ursula Garcia, Victor Martinez, Walter Robinson, Wendy Clark, Xavier Smith, Yolanda Jones, Zelda Williams, Alice Brown, Bob Davis, Charlie Miller, Dave Wilson, Eve Moore, Jillian Taylor, Karen Anderson, Larry Thomas, Michael Jackson, Nancy White, Oliver Harris, Peggy Martin, Quentin Thompson, Roger Garcia, Sally Martinez, Terry Robinson, Ursula Clark, Victor Smith, Walter Jones, Wendy Williams, Xavier Brown, Yolanda Davis, Zelda Miller, Alice Wilson, Bob Moore, Charlie Taylor, Dave Anderson, Eve Thomas, Jillian Jackson, Karen White, Larry Harris, Michael Martin, Nancy Thompson, Oliver Garcia, Peggy Martinez, Quentin Robinson, Roger Clark, Sally Smith, Terry Jones, Ursula Williams, Victor Brown, Walter Davis, Wendy Miller, Xavier Wilson, Yolanda Moore, Zelda Taylor, Alice Anderson, Bob Thomas, Charlie Jackson, Dave White, Eve Harris, Jillian Martin, Karen Thompson, Larry Garcia, Michael Martinez, Nancy Robinson, Oliver Clark, Peggy Smith, Quentin Jones, Roger Williams, Sally Brown, Terry Davis, Ursula Miller, Victor Wilson, Walter Moore, Wendy Taylor, Xavier Anderson, Yolanda Thomas, Zelda Jackson";
            string[] names = listOfNames.Split(',');
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] nice_score = new int[names.Length];
            int[] naughty_score = new int[names.Length];
            char[] santa = { 's', 'a', 'n', 't', 'a' };
            char[] grinch = { 'g', 'r', 'i', 'n', 'c', 'h' };
            double[] overall_nice = new double[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                //nice score
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (names[i].Contains(vowels[j]))
                    {
                        nice_score[i]++;
                    }
                }
                string firstName = names[i].Substring(0, names[i].IndexOf(' ')).ToLower().Trim();
                string lastName = names[i].Substring(names[i].IndexOf(' ') + 1).ToLower().Trim();
                nice_score[i] += lastName.Length;
                if (firstName.Length % 2 == 0 && lastName.Length % 2 == 0)
                {
                    nice_score[i] += 5;
                }
                for (int k = 0; k < santa.Length; k++)
                {
                    if (names[i].Contains(santa[k]))
                    {
                        nice_score[i] += 2;
                    }
                }

                //naughty score
                for (int l = 0; l < firstName.Length; l++)
                {
                    if (Convert.ToInt32(firstName[l]) > 109)
                    {
                        naughty_score[i]++;
                    }
                }

                naughty_score[i] += firstName.Length;

                if (firstName.Length % 2 != 0 && lastName.Length % 2 != 0)
                {
                    naughty_score[i] += 5;
                }

                for (int m = 0; m < grinch.Length; m++)
                {
                    if (names[i].Contains(grinch[m]))
                    {
                        naughty_score[i] += 2;
                    }
                }

                overall_nice[i] = Math.Round((Convert.ToDouble(nice_score[i]) / (Convert.ToDouble(naughty_score[i]) + Convert.ToDouble(nice_score[i]))) * 100, 0);

                Console.WriteLine($"{names[i]}: \n- Nice score: {nice_score[i]} \n- Naughty score: {naughty_score[i]} \n- Overall nice score: {overall_nice[i]}%");
            }
        }
        static void Main(string[] args)
        {
            NaughtyNiceScore();
        }
    }
}
