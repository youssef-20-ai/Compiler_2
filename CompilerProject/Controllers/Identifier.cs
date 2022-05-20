using CompilerProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompilerProject.Controllers
{
    public class Identifier : Controller
    {
        public int number;
        public static List<Char> word = new List<Char>();
        public List<Char> idCheck(int position, String codeFile)
        {
            int lastPosition = position;
            List<Char> newword = new List<Char>();
            while (codeFile[lastPosition] != ' ' )
            {
                newword.Add(codeFile[lastPosition]);
                lastPosition++;
            }
            number = lastPosition;
            word = newword;
            return word;
        }

        public DataModel idCheckDefault(int position, String codeFile)
        {
            DataModel model = new DataModel();
            int lastPosition = position;
            List<Char> newword = new List<Char>();
            while (codeFile[lastPosition] != ' ')
            {
                newword.Add(codeFile[lastPosition]);
                lastPosition++;
            }
            number = lastPosition;
            word = newword;
            model.token = "ID";
            model.input = new string(word.ToArray());
            return model;
        }

        public String ListToString()
        {
            return new string(word.ToArray());
        }
    }
}
