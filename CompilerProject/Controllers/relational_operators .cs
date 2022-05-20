namespace CompilerProject.Controllers
{
    public class relational_operators
    {
        public static int number;
        static char characterForEqual = '=';
        static char characterForOr = '|';
        public static String validateEqual(string codeFile, int lastPosition, int state)
        {

            if (codeFile[lastPosition] == characterForEqual)
            {
                number = lastPosition + 1;
                return "relation operators";
            }
            else
            {
                return "ID";
            }
        }
        public static String validateAssignment(string codeFile, int lastPosition, int state)
        {

            if (codeFile[lastPosition] == characterForEqual)
            {
                return "Assignment operators";
            }
            else
            {
                return "ID";
            }
        }
        public static String validateGT(string codeFile, int lastPosition, int state)
        {
            if (codeFile[lastPosition] == '<')
            {
                return "Logic operators";
            }
            else
            {
                return "ID";
            }
        }
        public static String validateST(string codeFile, int lastPosition, int state)
        {
            if (codeFile[lastPosition] == '>')
            {
                return "Logic operators";
            }

            else
            {
                return "ID";
            }

        }

       
        public static String validateNotEqual(string codeFile, int lastPosition, int state)
        {
            
            if (codeFile[lastPosition+1] == characterForEqual)
            {
                return "relational operators";
            }
            else
            {
                return "ID";
            }
        }
        public static String validateGreaterOrEqual(string codeFile, int lastPosition, int state)
        {
            if (codeFile[ lastPosition+1] == characterForEqual)
            {
                return "Logic operators";
            }
            else
            {
                return "ID";
            }
        }
        public static String validateSmallerOrEqual(string codeFile, int lastPosition, int state)
        {
            if (codeFile[lastPosition+1] == characterForEqual)
            {
                return "Logic operators";
            }

            else
            {
                return "ID";
            }

        }
    }
}
