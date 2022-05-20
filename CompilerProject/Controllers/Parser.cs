using CompilerProject.Models;

namespace CompilerProject.Controllers
{
    public class Parser
    {
        String nextToken;
        int currentToken = -1;
        List<DataModel> Tokens = new List<DataModel> { };
        int totalNumbersOfError = 0;


        public void intial(List<DataModel> tokens)
        {
            Tokens = tokens;
            lex();
            propgramStart();
        }

        public void match(String token)
        {
            Console.WriteLine(token);
            if (currentToken < Tokens.Count - 1)
                lex();
        }

        public void lex()
        {
            currentToken++;
            nextToken = Tokens[currentToken].token;
        }

        public void error()
        {
            totalNumbersOfError++;
        }



        public void propgramStart()
        {
            if (nextToken == "Program")
            {
                match(nextToken);
                classDeclration();
                
                    if (nextToken == "Braces")
                        match(nextToken);
                    endProgram(); 
                
            }
            else
            {
                error();
            }
        }


        public void classDeclration()
        {
            if (nextToken == "Class")
            {
                match(nextToken);
                ID();
            }
        }

        public void ID()
        {
            if (nextToken == "ID")
            {
                match(nextToken);
                switch (nextToken)
                {
                    case "Braces":
                        match(nextToken);
                        classImpelmentaion();
                        break;
                    case "Derive":
                        match(nextToken);
                        if (nextToken == "Braces")
                        {
                            match(nextToken);
                            classImpelmentaion();
                        }
                        else
                            error();
                        break;
                    default:
                        error();
                        break;
                }
            }
        }

        public void classImpelmentaion()
        {
            if (nextToken == "Integer" || nextToken == "SInteger" || nextToken == "Character" || nextToken == "String" ||
   nextToken == "Float" || nextToken == "SFloat" || nextToken == "Void" || nextToken == "Boaloon")
            {
                varDecleration();
            }
            else if (nextToken == "Comment")
            {
                Comment();
            }
            else if (nextToken == "Using")
            {
                
                Using();
            }
            else if (nextToken == "Integer" || nextToken == "SInteger" || nextToken == "Character" || nextToken == "String" ||
              nextToken == "Float" || nextToken == "SFloat" || nextToken == "Void" || nextToken == "Boaloon")
            {
                methodDecleration();
            }
            else if (nextToken == "Braces")
            {
                endProgram();
            }
        }


        public void ID_List()
        {
            while (nextToken == "ID")
            {
                match(nextToken);
            }
            if (nextToken == "Line delimiter")
            {
                match(nextToken);
                if (nextToken != "Braces")
                    classImpelmentaion();
                //endProgram();
            }
        }

        public void delimater()
        {
            if (nextToken == "Line delimiter")
                match(nextToken);
            else
                error();
        }

       



        public void Statements()
        {
            while (Assignment() || IfStatement() || RotateWhen() || ContinueWhen() || ReplyWith() || terminate()) ;
        }

        public bool Assignment()
        {
            varDecleration();
            if (nextToken == "Assignment operators")
            {
                match(nextToken);
                Expression();
                return true;
            }
            else
                return false;
        }

        public void Expression()
        {
            while (nextToken == "ID" || nextToken == "Constant")
            {
                match(nextToken);
                if (!operations())
                {
                    break;
                }
            }
        }

        public bool operations()
        {
            if (nextToken == "Arithmetic Operation")
            {
                match(nextToken);
                return true;
            }
            else
                return false;
        }

        public bool IfStatement()
        {
            if (nextToken == "Condition")
            {
                match(nextToken);
                if (nextToken == "Braces")
                {
                    match(nextToken);
                    ConditionExpression();
                    if (nextToken == "Braces")
                    {
                        match(nextToken);
                        BlockStatements();
                       
                    }
                    else
                        error();
                }
                else
                    error();
                return true;
            }
            else
            {
                error();
                return false;
            }
        }

        public void ConditionExpression()
        {
            Condition();
            if (nextToken == "Logic Operators")
            {
                match(nextToken);
                Condition();
            }
        }

        public void Condition()
        {
            Expression();
            if (nextToken == "reletional Operators")
            {
                match(nextToken);
                Expression();
            }
            else
                error();
        }

        public void BlockStatements()
        {
            if (nextToken == "Braces")
            {
                match(nextToken);
                Statements();
                if (nextToken == "Braces")
                {
                    match(nextToken);
                }
                else
                    error();
            }
            else
                error();
        }

        public bool RotateWhen()
        {
            if (nextToken == "Loop")
            {
                match(nextToken);
                if (nextToken == "Braces")
                {
                    match(nextToken);
                    ConditionExpression();
                    if (nextToken == "Braces")
                    {
                        match(nextToken);
                        BlockStatements();
                        
                    }
                    else
                        error();
                }
                else
                    error();
                return true;
            }
            else
            {
                error();
                return false;
            }
        }

        public bool ContinueWhen()
        {
            if (nextToken == "Loop")
            {
                match(nextToken);
                if (nextToken == "Braces")
                {
                    match(nextToken);
                    Expression();
                    if (nextToken == "Line delimiter")
                    {
                        match(nextToken);
                        Expression();
                        if (nextToken == "Line delimiter")
                        {
                            match(nextToken);
                            Expression();
                            if (nextToken == "Braces")
                            {
                                match(nextToken);
                                BlockStatements();
                            }
                            else
                                error();
                        }
                        else
                            error();
                    }
                    else
                        error();
                }
                else
                    error();
                return true;
            }
            else
            {
                error();
                return false;
            }
        }

        public bool ReplyWith()
        {
            if (nextToken == "Return")
            {
                match(nextToken);
                Expression();
                if (nextToken == "Line delimiter")
                {
                    match(nextToken);
                   
                }
                else
                    error();
                return true;
            }
            else
            {
                error();
                return false;
            }
        }

        //Confused
        public bool terminate()
        {
            if (nextToken == "break")
            {
                match(nextToken);
                if (nextToken == "Line delimiter")
                {
                    match(nextToken);
                }
                else
                    error();
                return true;
            }
            else
            {
                error();
                return false;
            }
        }

        //classImplementation
        public void varDecleration()
        {
            while (nextToken == "Integer" || nextToken == "SInteger" || nextToken == "Character" || nextToken == "String" ||
               nextToken == "Float" || nextToken == "SFloat" || nextToken == "Void" || nextToken == "Boaloon")
            {
                match(nextToken);
                ID_List();
            }
        }


        public void FuncDecl()
        {
            type();
            if (nextToken == "ID")
            {
                match(nextToken);
                if (nextToken == "Braces")
                {
                    match(nextToken);
                    NonEmptyList();
                }
                else
                    error();
            }
            else
                error();
        }


        public bool type()
        {
            if (nextToken == "Integer" || nextToken == "SInteger" || nextToken == "Character" || nextToken == "String" ||
               nextToken == "Float" || nextToken == "SFloat" || nextToken == "Void" || nextToken == "Boaloon")
            {
                match(nextToken);
                return true;
            }
            else
            {
                error();
                return false;
            }
        }

        public void NonEmptyList()
        {
            while (type())
            {
                if (nextToken == "ID")
                {
                    match(nextToken);
                }
                else
                {
                    
                    error();
                }
            }
            if (nextToken == "Braces")
            {
                match(nextToken);
            }
            else
            {
                
                error();
            }
        }

        public void methodDecleration()
        {
            FuncDecl();       
            if (nextToken == "Braces")
            {
                match(nextToken);
                varDecleration();
                Statements();
                if (nextToken == "Braces")
                {
                    match(nextToken);
                    if (nextToken !="Braces")
                    {
                        classImpelmentaion();

                    }
                }

            }
            else if (nextToken == "Line delimiter")
            {
                match(nextToken);
                if (nextToken !="Braces")
                {
                    classImpelmentaion();

                }
            }
        }

        public void Comment()
        {
            if (nextToken == "Comment")
            {
                match(nextToken);
                if (nextToken != "Braces")
                {
                    classImpelmentaion();
                }
            }
            else
                error();
        }

        public void Using()
        {
            if (nextToken == "Using")
            {
                match(nextToken);
                if (nextToken == "Braces")
                {
                    match(nextToken);
                    if (nextToken == "ID")
                    {
                        match(nextToken);
                        if (nextToken == "Braces")
                        {
                            match(nextToken);
                            if (nextToken == "Line delimiter")
                            {
                                match(nextToken);
                                if (nextToken == "Braces")
                                {
                                    match(nextToken);
                                    if (nextToken != "Braces")
                                    {
                                        classImpelmentaion();
                                    }
                                }
                            }
                            else
                                error();
                        }
                        else
                            error();
                    }
                    else
                        error();
                }
                else
                    error();
            }
        }

        public void FuncCall()
        {
            if (nextToken == "ID")
            {
                match(nextToken);
                if (nextToken == "Braces")
                {
                    NonEmptyList();
                    if (nextToken == "Braces")
                    {
                        match(nextToken);
                        if (nextToken == "Line delimater")
                        {
                            match(nextToken);
                        }
                        else
                            error();
                    }
                    else
                        error();
                }
                else
                    error();
            }
        }

        public void endProgram()
        {
            if (nextToken == "End")
            {
                match(nextToken);
                Console.WriteLine("Total Number Of Errors : " + totalNumbersOfError);
            }
            else
                error();
        }

    }
}
