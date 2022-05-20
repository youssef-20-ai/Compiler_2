using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Using
    {

        static public int number;
        static List<char> charactersForUsing = new List<char> {'U' ,'s', 'i', 'n', 'g' };
        public static DataModel? validateUsing(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == charactersForUsing.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (charactersForUsing[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == charactersForUsing.Count)
                {
                    number = position + 1;
                    model.token = "Using";
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