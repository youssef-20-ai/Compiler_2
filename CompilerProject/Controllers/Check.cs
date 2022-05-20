using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Check
    {
        public static DataModel model = new DataModel();
        public static int number;
        static List<char> charactersForCheck = new List<char> {'C' ,'h', 'e', 'c', 'k' };
        static List<char> charactersForSituationOf = new List<char> { 's', 'i', 't', 'u', 'a' , 't', 'i', 'o', 'n', 'o', 'f'};
        public static DataModel? validateCheck(string codeFile, int lastPosition, int state)
        {
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == charactersForCheck.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (charactersForCheck[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == charactersForCheck.Count)
                {
                    number = position;
                    model.token = "Switch";
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

        public static DataModel? validateSituationOf(string codeFile, int lastPosition, int state)
        {
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == charactersForSituationOf.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (charactersForSituationOf[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == charactersForSituationOf.Count)
                {
                    number = position;
                    model.token = "Switch";
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