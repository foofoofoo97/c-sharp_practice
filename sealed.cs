using System;

namespace c_sharp_practice
{

    //can inherit other
    //but cannot inherit by other
    sealed class Sealed : PracticeBase
    {

        public override void runResult()
        {
            return;
        }
    }

    // class InheritSealed : Sealed{

    // }
}

