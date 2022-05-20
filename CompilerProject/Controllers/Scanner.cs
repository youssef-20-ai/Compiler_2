using CompilerProject.Models;

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


        public static List<DataModel> tokens = new List<DataModel> { };

        static int numberOfErrors = 0;
        public string OldcodeFile { get; set; }
        public List<string> outPut { get; set; }
        public void initScanner()
        {
            compilerManager.Awake();
            compilerManager.resetState();
        }

        public static void Scan(string OldcodeFile)
        {
            
            OldcodeFile = OldcodeFile.Insert(OldcodeFile.Length, "                 ");
            string codeFile = OldcodeFile.Replace("\n", " ").Replace("\r", " ");
            for (int i = 0; i < codeFile.Length;)
            {
                if (codeFile[i] == ' ')
                {
                    i++;
                }
                else
                {
                    switch (codeFile[i])
                    {
                        case 'C':
                            compilerManager.setState(6);
                            switch (codeFile[i + 1])
                            {
                                case 'o':
                                    tokens.Add(Loop.validateContinue(codeFile, i, 6));
                                    i = Loop.number;
                                    break;
                                case 'l':
                                    tokens.Add(DataTypes.validateClop(codeFile, i, 6));
                                    i = DataTypes.number;
                                    break;
                                case 'h':
                                    tokens.Add(Check.validateCheck(codeFile, i, 6));
                                    i = Check.number;
                                    break;
                                case 'a':
                                    tokens.Add(Category.validate(codeFile, i, 6));
                                    i = Category.number;
                                    break;
                            }
                            break;
                        case 'D':
                            compilerManager.setState(27);
                            tokens.Add(DriveCatigory.validate(codeFile, i, 27));
                            i = DriveCatigory.number;

                            break;
                        case 'E':
                            compilerManager.setState(9);
                            if (codeFile[i + 1] == 'l')
                            {
                                tokens.Add(IfElse.validateElse(codeFile, i, 9));
                                i = IfElse.number;
                            }
                            else if (codeFile[i + 1] == 'n')
                            {
                                tokens.Add(End.validateEnd(codeFile, i, 9));
                                i = End.number;
                            }
                            else
                                numberOfErrors++;
                            break;
                        case 'I':
                            compilerManager.setState(38);
                            if (codeFile[i + 1] == 'l')
                            {
                                if (codeFile[i + 4] == 'f')
                                {
                                    tokens.Add(DataTypes.validateIlapf(codeFile, i, 38));
                                    i = DataTypes.number;
                                }
                                else
                                {
                                    tokens.Add(DataTypes.validateIlap(codeFile, i, 38));
                                    i = DataTypes.number;
                                }
                            }
                            else if (codeFile[i + 1] == 'f')
                            {
                                tokens.Add(IfElse.validateIf(codeFile, i, 38));
                                i = IfElse.number;
                            }
                            else if (codeFile[i + 1] == 'f')
                            {
                                tokens.Add(IfElse.validateIf(codeFile, i, 38));
                                i = IfElse.number;
                            }
                            else
                                numberOfErrors++;
                            break;
                        case 'L':
                            compilerManager.setState(44);
                            tokens.Add(DataTypes.validateLogical(codeFile, i, 44));
                            i = DataTypes.number;
                            break;
                        case 'N':
                            compilerManager.setState(51);
                            tokens.Add(DataTypes.validateNone(codeFile, i, 51));
                            i = DataTypes.number;
                            break;
                        case 'R':
                            compilerManager.setState(11);
                            switch (codeFile[i + 1])
                            {
                                case 'e':
                                    tokens.Add(Return.validate(codeFile, i, 11));
                                    i = Return.number;
                                    break;
                                case 'o':
                                    tokens.Add(Loop.validateRotate(codeFile, i, 11));
                                    i = Loop.number;
                                    break;
                            }
                            break;
                        case 'S':
                            compilerManager.setState(7);
                            switch (codeFile[i + 1])
                            {
                                case 'e':
                                    switch (codeFile[i + 2])
                                    {
                                        case 'o':
                                            tokens.Add(Seop.validateSeop(codeFile, i, 7));
                                            i = Seop.number;
                                            break;
                                        case 'r':
                                            tokens.Add(DataTypes.validateSeries(codeFile, i, 7));
                                            i = DataTypes.number;
                                            break;
                                    }
                                    break;
                                case 'i':
                                    if (codeFile[i + 5] == 'f')
                                    {
                                        tokens.Add(DataTypes.validateSilapf(codeFile, i, 38));
                                        i = DataTypes.number;
                                    }
                                    else
                                    {
                                        tokens.Add(DataTypes.validateSilap(codeFile, i, 38));
                                        i = DataTypes.number;
                                    }
                                    break;

                            }
                            break;
                        case 's':
                            tokens.Add(Check.validateSituationOf(codeFile, i, 8));
                            i = Check.number;
                            break;
                        case 'P':
                            compilerManager.setState(8);
                            tokens.Add(Program.validateProgram(codeFile, i, 8));
                            i = Program.number;
                            break;
                        case 'T':
                            compilerManager.setState(3);
                            tokens.Add(Terminate.validate(codeFile, i, 3));
                            i = Terminate.number;
                            break;
                        case 'U':
                            compilerManager.setState(10);
                            tokens.Add(Using.validateUsing(codeFile, i, 10));
                            i = Using.number;
                            break;
                        case '\'':
                            DataModel model = new DataModel();
                            compilerManager.setState(19);
                            model.token = "QuotationMark";
                            model.input = "\'";
                            tokens.Add(model);
                            i++;
                            break;
                        case '\"':
                            DataModel model1 = new DataModel();
                            compilerManager.setState(20);
                            model1.token = "QuotationMark";
                            model1.input = "\"";
                            tokens.Add(model1);
                            i++;
                            break;
                        case '.':
                            DataModel model2 = new DataModel();
                            compilerManager.setState(1);
                            model2.token = "Acces Operator";
                            model2.input = ".";
                            tokens.Add(model2);
                            i++;
                            break;
                        case '+':
                            DataModel model3 = new DataModel();
                            compilerManager.setState(15);
                            model3.token = "Arithmetic Operator";
                            model3.input = "+";
                            tokens.Add(model3);
                            i++;
                            break;
                        case '-':
                            DataModel model4 = new DataModel();
                            compilerManager.setState(16);
                            model4.token = "Arithmetic Operator";
                            model4.input = "-";
                            tokens.Add(model4);
                            i++;
                            break;
                        case '/':
                            DataModel model5 = new DataModel();
                            compilerManager.setState(17);
                            model5.token = "Arithmetic Operator";
                            model5.input = "/";
                            tokens.Add(model5);
                            i++;
                            break;
                        case '*':
                            DataModel model6 = new DataModel();
                            compilerManager.setState(18);
                            model6.token = "Arithmetic Operator";
                            model6.input = "*";
                            tokens.Add(model6);
                            i++;
                            break;
                        case '{':
                            DataModel model7 = new DataModel();
                            compilerManager.setState(22);
                            model7.token = "Braces";
                            model7.input = "{";
                            tokens.Add(model7);
                            i++;
                            break;
                        case '(':
                            DataModel model8 = new DataModel();
                            compilerManager.setState(22);
                            model8.token = "Braces";
                            model8.input = "(";
                            tokens.Add(model8);
                            i++;
                            break;
                        case ')':
                            DataModel model9 = new DataModel();
                            compilerManager.setState(22);
                            model9.token = "Braces";
                            model9.input = ")";
                            tokens.Add(model9);
                            i++;
                            break;
                        case '}':
                            DataModel model10 = new DataModel();
                            compilerManager.setState(129);
                            model10.token = "Braces";
                            model10.input = "}";
                            tokens.Add(model10);
                            i++;
                            break;
                        case '[':
                            DataModel model11 = new DataModel();
                            compilerManager.setState(23);
                            model11.token = "Braces";
                            model11.input = "[";
                            tokens.Add(model11);
                            i++;
                            break;
                        case ']':
                            DataModel model12 = new DataModel();
                            compilerManager.setState(131);
                            model12.token = "Braces";
                            model12.input = "]";
                            tokens.Add(model12);
                            i++;
                            break;
                        case '~':
                            DataModel model13 = new DataModel();
                            compilerManager.setState(24);
                            model13.token = "Logic Operator";
                            model13.input = "~";
                            tokens.Add(model13);
                            i++;
                            break;
                        case '&':
                            compilerManager.setState(21);
                            tokens.Add(Logical_operators.validateAnd(codeFile, i, 21));
                            i = Logical_operators.number;
                            break;
                        case '|':
                            compilerManager.setState(12);
                            tokens.Add(Logical_operators.validateOr(codeFile, i, 12));
                            i = Logical_operators.number;
                            break;
                        case '<':
                            compilerManager.setState(25);
                            if (codeFile[i + 1] == '=')
                            {
                                DataModel model14 = new DataModel();
                                model14.token = "relational operators";
                                model14.input = "<=";
                                tokens.Add(model14);
                                i++;
                            }
                            else if (codeFile[i + 1] == ' ')
                            {
                                DataModel model15 = new DataModel();
                                model15.token = "relational operators";
                                model15.input = "<";
                                tokens.Add(model15);
                                i++;
                            }
                            else if(codeFile[i + 1] == '*')
                            {
                                int count = i+2;
                                List<char> word = new List<char> { '<', '*'};
                                while (codeFile[count] != '*' && codeFile[count+1] != '>')
                                {
                                    word.Add(codeFile[count]);
                                    count++;
                                }
                                i = count + 2;
                                DataModel model16 = new DataModel();
                                model16.token = "Comment";
                                model16.input = "Comment";
                                tokens.Add(model16);
                            }
                            break;
                        case '>':
                            compilerManager.setState(26);
                            if (codeFile[i + 1] == '=')
                            {
                                DataModel model17 = new DataModel();
                                model17.token = "relational operators";
                                model17.input = ">=";
                                tokens.Add(model17);
                                i++;
                            }
                            else if (codeFile[i + 1] == ' ')
                            {
                                DataModel model18 = new DataModel();
                                model18.token = "relational operators";
                                model18.input = ">";
                                tokens.Add(model18);
                                i++;
                            }

                            break;
                        case '=':
                            compilerManager.setState(27);
                            if (codeFile[i + 1] == '=')
                            {
                                DataModel model19 = new DataModel();
                                model19.token = "relational operators";
                                model19.input = "==";
                                tokens.Add(model19);
                                i++;
                            }
                            else if (codeFile[i + 1] == ' ')
                            {
                                DataModel model20 = new DataModel();
                                model20.token = "Assignment operator";
                                model20.input = "=";
                                tokens.Add(model20);
                                i++;
                            }
                                
                            break;
                        case '!':
                            compilerManager.setState(28);
                            if (codeFile[i + 1] == '=')
                            {
                                DataModel model21 = new DataModel();
                                model21.token = "relational operators";
                                model21.input = "!=";
                                tokens.Add(model21);
                                i++;
                            }
                            else if (codeFile[i + 1] == ' ')
                            {
                                DataModel model22 = new DataModel();
                                model22.token = "relational operators";
                                model22.input = "!";
                                tokens.Add(model22);
                            }

                            break;
                        case ';':
                            compilerManager.setState(29);
                            DataModel model23 = new DataModel();
                            model23.token = "Line delimiter";
                            model23.input = ";";
                            tokens.Add(model23);
                            i++;
                            break;
                        default:
                            Identifier identifier = new Identifier();
                            tokens.Add(identifier.idCheckDefault(i, codeFile));
                            i = identifier.number;
                            break;
                    }
                }
            }


            Parser parser = new Parser();
            parser.intial(tokens);
            foreach(var item in tokens)
            {
                Console.WriteLine("Token Text: " + item.input + "     Token Type: " + item.token);
            }
            tokens.Clear();
            // new List<String>{"Program", "Class", "ID", "Braces", "Float", "ID", "Braces", "End"}
            // token input : 
        }

    }
}
