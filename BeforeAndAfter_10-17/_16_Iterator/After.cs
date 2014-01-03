using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _16_Iterator
{
    public class After
    {
        public static void Run()
        {
            Country country = new Country();

            /// the get_Cities property has been removed.
            /// Client has to use Iterator.
            IIterator it = country.CreateIterator();
            while(it.MoveNext())
            {
                Console.Write(it.Current as string + ", ");
            }


            /// This demonstrates the abililty to create many iterators
            /// and to iterate on them simultaniously
            IIterator it1 = country.CreateIterator();
            IIterator it2 = country.CreateIterator();

            it1.MoveNext();
            it1.MoveNext();
            Console.WriteLine(it1.Current + Environment.NewLine);

            Console.WriteLine("Two simultaneous iterations:");
            while (it1.MoveNext() && it2.MoveNext())
            {
                Console.Write("[" + it1.Current + "]" + " " + it2.Current + " ");
            }
        }

        /// The Aggregte interface
        public interface IAggregate
        {
            IIterator CreateIterator();
        }

        /// The Iterator interface
        public interface IIterator
        {
            bool MoveNext();
            object Current { get; } /// polymorphic item reference
            void Reset();
        }

        /// the ConcreteAggregate
        public class Country : IAggregate
        {
            private readonly List<City> m_Cities;

            public Country()
            {
                m_Cities = new List<City>()
                {
                    new City() {Name = "Tel Aviv", Prefix = "03", Area = 122.7f, Population = 1250000},
                    new City() {Name = "Herzelia", Prefix = "09", Area = 35.17f, Population = 65200},
                    new City() {Name = "Haifa", Prefix = "04", Area = 105.5f, Population = 1080000},
                    new City() {Name = "Hadera", Prefix = "08", Area = 68.25f, Population = 225000}
                };
            }

            public IIterator CreateIterator()
            {
                return new CityNamesIterator(this);
            }

            /// The ConcreteIterator:
            /// This is a private nested class, which is tightly-coupled 
            /// with the aggregate, and is specific to its needs.
            private class CityNamesIterator : IIterator
            {
                private Country m_Agregate;
                private int m_CurrentIdx = -1;
                private int m_Count = -1;

                public CityNamesIterator(Country i_Collection)
                {
                    m_Agregate = i_Collection;
                    m_Count = m_Agregate.m_Cities.Count;
                }

                public void Reset()
                {
                    m_CurrentIdx = -1;
                }

                public bool MoveNext()
                {
                    if (m_Count != m_Agregate.m_Cities.Count)
                    {
                        throw new Exception("Collection can not be changed during iteration!");
                    }
                    if (m_CurrentIdx >= m_Count)
                    {
                        throw new Exception("Already reached the end of the collection");
                    }

                    return ++m_CurrentIdx < m_Agregate.m_Cities.Count;
                }

                public object Current
                {
                    get { return m_Agregate.m_Cities[m_CurrentIdx].Name; }
                }
            }
        }

        public class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public string Prefix { get; set; }
            public float Area { get; set; }
        }
    }
}
