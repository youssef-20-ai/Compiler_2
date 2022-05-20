using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class IfElse
    {
        static List<char> characterForIf = new List<char> {'I' ,'f'};
        static List<char> charactersForElse = new List<char> {'E', 'l', 's', 'e'};
        static public int number;

        public static DataModel? validateIf(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == characterForIf.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (characterForIf[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == characterForIf.Count)
                {
                    number = position;
                    model.token = "If";
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

        public static DataModel? validateElse(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition ;
            int counter = 0;
            if (word.Count == charactersForElse.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (charactersForElse[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == charactersForElse.Count)
                {
                    number = position;
                    model.token = "Else";
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