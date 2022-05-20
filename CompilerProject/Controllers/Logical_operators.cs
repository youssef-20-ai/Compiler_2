using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Logical_operators
    {
        public static int number;
        static List<char> characterForAnd = new List<char>{ '&', '&'};
        static List<char> characterForOr = new List<char> { '|', '|' };
        public static DataModel validateAnd(string codeFile, int lastPosition, int state)
        {

            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);
            DataModel model = new DataModel();
            int position = lastPosition;
            int counter = 0;
            if (word.Count == characterForAnd.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (characterForAnd[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == characterForAnd.Count)
                {
                    number = position;
                    model.token = "Logic operators";
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
        public static DataModel validateOr(string codeFile, int lastPosition, int state)
        {
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);
            DataModel model = new DataModel();
            int position = lastPosition;
            int counter = 0;
            if (word.Count == characterForOr.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (characterForOr[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == characterForOr.Count)
                {
                    number = position;
                    model.token = "Logic operators";
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
        public static String validateNot(string codeFile, int lastPosition, int state)
        {
            if (codeFile[lastPosition+1] == '~')
            {
                number = lastPosition + 2;
                return "Logic operators";
            }

            else
            {
                return "ID";
            }

        }

    }
}
