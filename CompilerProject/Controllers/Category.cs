using CompilerProject.Controllers;

namespace CompilerProject.Models
{
    public class Category
    {
        public static DataModel model = new DataModel();
        static List<char> characters = new List<char> {'C', 'a', 't', 'e', 'g', 'o', 'r', 'y'};
        public static int number = 0;
        public static DataModel? validate(string codeFile, int lastPosition, int state)
        {
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
                    number = position;
                    model.token = "Class";
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
