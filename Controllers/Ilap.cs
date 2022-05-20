namespace CompilerProject.Controllers
{
    public class Ilap
    {
        static List<char> characters = new List<char> {'l' , 'a' , 'p'};

        public static string? validate(string codeFile , int lastPosition , int state)
        {
            int position = lastPosition;
            int counter = 0;
            for(int i = 0; i < 3; i++)
            {
                if(codeFile.Contains(characters[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            if (counter == characters.Count)
            {
                return "Integer";
            }
            else
            {
                return null;
            }
        }
    }
}
