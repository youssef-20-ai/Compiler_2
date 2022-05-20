using CompilerProject.Controllers;

namespace CompilerProject.Models
{
    public class DataTypes
    {
        static List<char> Silap = new List<char> {'S' ,'i', 'l', 'a', 'p' };
        static List<char> Ilapf = new List<char> {'I', 'l', 'a', 'p', 'f' };
        static List<char> Ilap = new List<char> {'I', 'l', 'a', 'p' };
        static List<char> Series = new List<char> {'S', 'e', 'r', 'i', 'e', 's'};
        static List<char> Silapf = new List<char> {'S', 'i', 'l', 'a', 'p', 'f' };
        static List<char> Clop = new List<char> {'C' ,'l', 'o', 'p' };
        static List<char> None = new List<char> {'N' ,'o', 'n', 'e' };
        static List<char> Logical = new List<char> {'L' ,'o', 'g', 'i', 'c', 'a', 'l' };
        static public int number;
        public static DataModel? validateClop(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == Clop.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (Clop[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == Clop.Count)
                {
                    number = position;
                    model.token = "Character";
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
        public static DataModel? validateIlapf(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == Ilapf.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (Ilapf[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == Ilapf.Count)
                {
                    number = position;
                    model.token = "Float";
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
        public static DataModel? validateIlap(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == Ilap.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (Ilap[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == Ilap.Count)
                {
                    number = position;
                    model.token = "Integer";
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
        public static DataModel? validateSeries(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == Series.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (Series[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == Series.Count)
                {
                    number = position;
                    model.token = "String";
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

        public static DataModel validateSilapf(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == Silapf.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (Silapf[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == Silapf.Count)
                {
                    number = position;
                    model.token = "SFloat";
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
        public static DataModel validateSilap(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == Silap.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (Silap[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == Silap.Count)
                {
                    number = position;
                    model.token = "SInteger";
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

        public static DataModel? validateNone(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == None.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (None[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == None.Count)
                {
                    number = position;
                    model.token = "Void";
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

        public static DataModel? validateLogical(string codeFile, int lastPosition, int state)
        {
            DataModel model = new DataModel();
            List<char> word = new List<char>();
            Identifier ID = new Identifier();
            word = ID.idCheck(lastPosition, codeFile);

            int position = lastPosition;
            int counter = 0;
            if (word.Count == Logical.Count)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == (Logical[i]))
                    {
                        counter++;
                        position++;
                    }
                }
                if (counter == Logical.Count)
                {
                    number = position;
                    model.token = "Boolean";
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