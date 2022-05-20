using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Loop
    {

        static List<char> rotate = new List<char> {'R' ,'o', 't', 'a', 't', 'e', 'w', 'h', 'e', 'n' };

        static List<char> cont = new List<char> {'C' ,'o', 'n', 't', 'i', 'n', 'u', 'e', 'w', 'h', 'e', 'n' };

        static public int number;

        public static DataModel? validateRotate(string codeFile, int lastPosition, int state)
        {
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);
            DataModel model = new DataModel();
            int position = lastPosition;
            int counter = 0;
            if (word.Count == rotate.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (rotate[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == rotate.Count)
                {
                    number = position;
                    model.token = "Loop";
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

        public static DataModel? validateContinue(string codeFile, int lastPosition, int state)
        {
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);
            DataModel model = new DataModel();
            int position = lastPosition;
            int counter = 0;
            if (word.Count == cont.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (cont[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == cont.Count)
                {
                    number = position;
                    model.token = "Loop";
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