using System;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Wrong way

            //MyIntList intList = new MyIntList();
            //intList.AddItem(0);
            //intList.AddItem(1);
            //intList.AddItem(2);
            //intList.AddItem(3);
            //intList.ShowItems();

            //MyStringList stringList = new MyStringList();
            //stringList.AddItem("Elnur");
            //stringList.AddItem("Rail");
            //stringList.AddItem("Vuqar");
            //stringList.AddItem("Fagan");
            //stringList.ShowItems();

            //MyPersonList personList = new MyPersonList();
            //personList.AddItem(new Person());
            //personList.AddItem(new Person());
            //personList.AddItem(new Person());
            //personList.ShowItems();

            #endregion

            #region Generic

            //MyList<int> intList = new MyList<int>();
            //intList.AddItem(1);
            //intList.AddItem(2);
            //intList.AddItem(4);
            //intList.AddItem(3);
            //intList.ShowItems();

            //MyList<string> stringList = new MyList<string>();
            //stringList.AddItem("Elnur");
            //stringList.AddItem("Rail");
            //stringList.AddItem("Vuqar");
            //stringList.ShowItems();

            //MyList<Person> personList = new MyList<Person>();
            //personList.AddItem(new Person());
            //personList.AddItem(new Person());
            //personList.AddItem(new Person());
            //personList.ShowItems();

            MyList<Person, int> myList = new MyList<Person, int>();

            #endregion
        }
    }

    #region Wrong way

    class MyIntList
    {
        private int[] _numbers;

        public MyIntList()
        {
            _numbers = new int[0];
        }

        public void AddItem(int number)
        {
            Array.Resize(ref _numbers, _numbers.Length + 1);
            _numbers[_numbers.Length - 1] = number;
        }

        public void ShowItems()
        {
            foreach (int item in _numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MyStringList
    {
        private string[] _numbers;

        public MyStringList()
        {
            _numbers = new string[0];
        }

        public void AddItem(string number)
        {
            Array.Resize(ref _numbers, _numbers.Length + 1);
            _numbers[_numbers.Length - 1] = number;
        }

        public void ShowItems()
        {
            foreach (string item in _numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MyPersonList
    {
        private Person[] _numbers;

        public MyPersonList()
        {
            _numbers = new Person[0];
        }

        public void AddItem(Person number)
        {
            Array.Resize(ref _numbers, _numbers.Length + 1);
            _numbers[_numbers.Length - 1] = number;
        }

        public void ShowItems()
        {
            foreach (Person item in _numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

    #endregion

    #region Generic

    //class MyList<T, U> where T:class
    //class MyList<T, U> where T:class,new()
    //class MyList<T, U> where T:struct
    //class MyList<T, U> where T:class, IRun
    //class MyList<T, U> where T:U
    class MyList<T, U> where T:class where U:struct
    {
        //MyList class-i olsun, generic type-da
        //private array field saxlasin
        //ctor-da array uchun yer ayrilsin
        //Add ve Remove methodlari olsun
        private T[] _numbers;

        public MyList()
        {
            _numbers = new T[0];
        }

        public void AddItem(T number)
        {
            Array.Resize(ref _numbers, _numbers.Length + 1);
            _numbers[_numbers.Length - 1] = number;
        }

        public void ShowItems()
        {
            foreach (T item in _numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

    #endregion

    interface IRun
    {

    }

    class Test
    {

    }

    class Person : Test, IRun
    {
        public Person(string name)
        {

        }
    }
}
