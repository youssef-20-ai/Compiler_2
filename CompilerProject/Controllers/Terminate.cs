using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Terminate
    {

        static List<char> characters = new List<char> {'t' ,'e', 'r', 'm', 'i', 'n', 'a', 't', 'e', 't', 'h', 'i', 's' };
        static public int number;

        public static DataModel? validate(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == characters.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (characters[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == characters.Count)
                {
                    number = position + 1;
                    model.token = "break";
                    model.input = ID.ListToString();
                    return model;
                }
                else
                {
                    number = ID.number + 1;
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