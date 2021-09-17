using System;

namespace c_sharp_practice
{
    struct Person
    {
        public string firstname;
        public string lastname;
        private int age;

        public Person(String _firstname = "0", String _lastname = "0", int _age = 0)
        {
            firstname = _firstname;
            lastname = _lastname;
            age = _age;
        }
    }

    enum Type : ushort
    {
        HardWorking = 100,
        Lazy = 0,
        Mixed = 50

        //To get enum value = (ushort) Type.Hardworking
    }


    /*Inheritance Type
        : Single Level, Hieraarchical, MultiLevel

      Interface (Support Multple Implements, No fields) 
    */

    interface Book<T>
    {
        string book
        {
            get; set;
        }
        void returnKnowledge();
    }

    interface Technology
    {
        string programming
        {
            set;
            get;
        }
        void returnApp();
    }
    class InheritFromMultiple<T> : Book<T>, Technology
    {
        private string a;
        protected string b;
        internal string c;

        InheritFromMultiple()
        {

        }

        InheritFromMultiple(T a, int b)
        {

        }

        void function(int a, int b)
        {

        }

        void function(T b)
        {

        }

        public InheritFromMultiple(string _programming, string _book)
        {
            this.programming = _programming;
            this.book = _book;
        }
        public string book
        {
            set;
            get;
        }
        public string programming
        {
            set;
            get;
        }
        public void returnKnowledge() { }
        public void returnApp() { }
    }
}

