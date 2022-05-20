using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class End
    {
        static List<char> charactersForEnd = new List<char> {'E', 'n', 'd' };
        public static int number;
        public static DataModel? validateEnd(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition ;
            int counter = 0;
            if (word.Count == charactersForEnd.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (charactersForEnd[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == charactersForEnd.Count)
                {
                    number = position + 1;
                    model.token = "End";
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