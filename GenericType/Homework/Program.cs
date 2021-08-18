using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //Console.WriteLine("Valyutani daxil edin");
            //string input = Console.ReadLine();
            //if (double.TryParse(input, out double result))
            //{
            //    Console.WriteLine(Converter(Currency.Dollar, result));
            //}
            //else
            //{
            //    Console.WriteLine("yalnis input");
            //}

            #endregion

            #region Task 2

            //Console.WriteLine("Index-i daxil edin.");
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out int result))
            //{
            //    Alphabet english = new Alphabet("English");
            //    //english[0] = 'A';
            //    //english[2] = 'C';
            //    //Console.WriteLine(english[0]);
            //    english.SetLetter(result, 'A');
            //    //english.SetLetter(2, 'C');
            //    Console.WriteLine(english.GetLetter(result));
            //}

            #endregion

            #region Array sort

            Person[] persons = ArraySort();
            foreach (Person item in persons)
            {
                Console.WriteLine(item);
            }
            
            #endregion
        }

        #region Task 1

        static double Converter(Currency currency, double manat)
        {
            switch (currency)
            {
                case Currency.Dollar:

                    return manat / 1.7;

                case Currency.Euro:

                    return manat / 1.98;

                case Currency.Lira:

                    return manat / 0.2;

                case Currency.Yuan:

                    return manat * 3.8;
            }
            return 0;
        }


        #endregion

        #region Array sort

        public static Person[] ArraySort()
        {
            Person p1 = new Person("Rail", "Jannatov", 24);
            Person p2 = new Person("Sarkhan", "Efendizade", 23);
            Person p3 = new Person("Vugar", "Rustamov", 39);

            Person[] persons = { p1, p2, p3 };

            Array.Sort(persons);
            //for (int i = 0; i < persons.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < persons.Length; j++)
            //    {
            //        if (persons[i] > persons[j])
            //        {
            //            Person temp = persons[i];
            //            persons[i] = persons[j];
            //            persons[j] = temp;
            //        }
            //    }
            //}

            return persons;
        }

        #endregion
    }

    #region Task 2

    class Alphabet
    {
        public string Name { get; set; }
        private char[] _letter;

        public Alphabet(string name)
        {
            Name = name;
            _letter = new char[30];

        }
        //public char this[int index]
        //{
        //    get
        //    {
        //        return _letter[index];
        //    }
        //    set
        //    {
        //        _letter[index] = value;
        //    }
        //}

        public char GetLetter(int index)
        {
            return _letter[index];

        }

        public void SetLetter(int index, char symbol)
        {
            _letter[index] = symbol;

        }

    }


    #endregion

    #region Array sort

    public class Person : /*IComparable,*/ IComparable<Person>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }

        //public int CompareTo(object obj)
        //{
        //    Person p2 = (Person)obj;
        //    return Age.CompareTo(p2.Age);
        //}

        public int CompareTo(Person p2)
        {
            return Age.CompareTo(p2.Age);
        }
    }

    #endregion
}
