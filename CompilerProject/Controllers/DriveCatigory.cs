using CompilerProject.Controllers;

namespace CompilerProject.Models
{
    public class DriveCatigory
    {
        static List<char> characters = new List<char> {'D' ,'e', 'r', 'i', 'v', 'e'};
        public static int number = 0;
        public static DataModel? validate(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition +2;
            int counter = 0;
            if (word.Count == characters.Count) {
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
                    model.token = "Derive";
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