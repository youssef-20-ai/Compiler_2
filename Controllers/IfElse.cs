namespace CompilerProject.Controllers
{
    public class IfElse
    {
        static char characterForIf = 'f';
        static List<char> charactersForElse = new List<char> { 'l', 's', 'e' };

        public static string? validateIf(string codeFile , int lastPosition , int state)
        {
            if(codeFile[lastPosition+1] == characterForIf)
            {
                return "if";
            }
            else
            {
                return null;
            }
        }

        public static string? validateElse(string codeFile , int lastPosition , int state)
        {
            int counter = 0;
            for(int i = 0; i < charactersForElse.Count; i++)
            {
                if (codeFile.Contains(charactersForElse[i]))
                    counter++;
            }

            if (counter == charactersForElse.Count)
                return "else";
            else
                return null;
        }
    }
}
