using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Program
    {
        public static DataModel model = new DataModel();

        public static int number;
        static List<char> charactersForProgram = new List<char> {'P', 'r', 'o', 'g', 'r', 'a', 'm' };
        public static DataModel? validateProgram(string codeFile, int lastPosition, int state)
        {
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == charactersForProgram.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (charactersForProgram[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == charactersForProgram.Count)
                {
                    number = position;
                    model.token = "Program";
                    model.input = ID.ListToString();
                    return model;
                }
                else
                {
                    number = ID.number;
                    model.token = "ID";
                    model.input = ID.ListToString();
                    return model;
                }
            }
            else
            {
                number = ID.number + 1;
                model.token = "ID";
                model.input = ID.ListToString();
                return model;
            }
        }
    }
}