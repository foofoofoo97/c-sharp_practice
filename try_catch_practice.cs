using System;

namespace c_sharp_practice
{

    //can inherit other
    //but cannot inherit by other
    class TryCatchPractice : PracticeBase
    {

        public override void runResult()
        {
            Console.WriteLine(errorFunction());
        }

        private int errorFunction()
        {
            try
            {
                int x = 0;
                return 100 / x;
            }
            catch (FunctionException e)
            {

                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }

    class FunctionException : Exception
    {
        public FunctionException()
        {
        }
        public FunctionException(string message)
            : base(message)
        {
        }
    }
}
