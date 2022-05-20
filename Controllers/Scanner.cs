namespace CompilerProject.Controllers
{
    public class Scanner
    {
        static CompilerManager compilerManager = new CompilerManager();

        /*Category category = new Category();
        CheckSituationOf checkSituatuinOf = new CheckSituationOf();
        DataTypes datatypes = new DataTypes();
        DrivenCategory drivenCategory = new DrivenCategory();
        Function function = new Function();
        Identifier identifier = new Identifier();
        IfElse ifElse = new IfElse();
        RotateWhen rotateWhen = new RotateWhen();
        Braces braces = new Braces();*/

        public string codeFile { get; set; }
        public void initScanner()
        {
            compilerManager.Awake();
            compilerManager.resetState();
        }

        public static void Scan(string codeFile)
        {
            for (int i = 0; i < codeFile.Length; ++i)
            {
                if(codeFile[i] != ' ')
                {
                    switch (codeFile[i])
                    {
                        case 'C':
                            compilerManager.setState(6);

                            break;
                        case 'D':
                            compilerManager.setState(5);
                            //drivenCategory.codeFile = codeFile;
                            //drivenCategory.characterPosition = j;
                            //drivenCategory.stateNumber = 27;
                            //if (drivenCategory.validate())
                            //{
                            //  Console.WriteLine(DrivenCategory.tokenName);
                            //}
                            //else
                            //{
                            //  Console.WriteLine("ERROR");
                            //}
                            break;
                        case 'E':
                            compilerManager.setState(9);
                            if (IfElse.validateElse(codeFile, i, 9) != null)
                                Console.WriteLine("Else");
                            else
                                Console.WriteLine("error");
                            break;
                        case 'I':
                            compilerManager.setState(4);
                            if (Ilap.validate(codeFile, i, 4) != null)
                                Console.WriteLine("Ilap");
                            else if (IfElse.validateIf(codeFile, i, 4) != null)
                                Console.WriteLine("If");
                            else Console.WriteLine("error");
                            break;
                        case 'L':
                            compilerManager.setState(13);
                            break;
                        case 'N':
                            compilerManager.setState(2);
                            break;
                        case 'R':
                            compilerManager.setState(11);
                            break;
                        case 'S':
                            compilerManager.setState(7);
                            break;
                        case 'P':
                            compilerManager.setState(8);
                            break;
                        case 'T':
                            compilerManager.setState(3);
                            break;
                        case 'U':
                            compilerManager.setState(10);
                            break;
                        case '\'':
                            compilerManager.setState(19);
                            break;
                        case '\"':
                            compilerManager.setState(20);
                            break;
                        case '.':
                            compilerManager.setState(1);
                            break;
                        case '+':
                            compilerManager.setState(15);
                            break;
                        case '-':
                            compilerManager.setState(16);
                            break;
                        case '/':
                            compilerManager.setState(17);
                            break;
                        case '*':
                            compilerManager.setState(18);
                            break;
                        case '{':
                            compilerManager.setState(22);
                            break;
                        //case '}':
                          //  compilerManager.setState(129);
                            //break;
                        case '[':
                            compilerManager.setState(23);
                            break;
                        //case ']':
                          //  compilerManager.setState(131);
                            //break;
                        case '~':
                            compilerManager.setState(24);
                            break;
                        case '&':
                            compilerManager.setState(21);
                            break;
                        case '|':
                            compilerManager.setState(12);
                            break;
                        case '<':
                            compilerManager.setState(25);
                            break;
                        case '>':
                            compilerManager.setState(26);
                            break;
                        case '=':
                            compilerManager.setState(27);
                            break;
                        case '!':
                            compilerManager.setState(28);
                            break;
                        case ',':
                            compilerManager.setState(29);
                            break;
                    }
                }
            }
        }

    }
}
