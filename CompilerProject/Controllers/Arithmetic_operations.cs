namespace CompilerProject.Controllers
{
    public class Arithmetic_operations
    {
        static List<string> chars = new List<string> {"+","-", "*", "/" };
        public static void ValidateA (string codeFile, int lastPosition, int state)
        {
            for(int i = 0; i<chars.Count; i++)
            {
                if ( codeFile == chars[i])
                {
                    Console.WriteLine(codeFile);

                }
                else
                {
                    Console.WriteLine("error");

                }
            }
        }
    }
}
