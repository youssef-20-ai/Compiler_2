using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Seop
    {
        public static int number;
        static List<char> charactersForSeop = new List<char> {'S' ,'e', 'o', 'p' };
        public static DataModel? validateSeop(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == charactersForSeop.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (charactersForSeop[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == charactersForSeop.Count)
                {
                    number = position;
                    model.token = "Struct";
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
                number = ID.number;
                model.token = "ID";
                model.input = ID.ListToString();
                return model;
            }
        }
    }
}