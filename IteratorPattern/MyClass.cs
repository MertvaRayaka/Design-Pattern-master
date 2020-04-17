using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class MyClass
    {
        Person p = new Person();
        public MyClass()
        {
            p.Cars.Add(new Car { CarAge = 5, CarBrand = "Benz" });
            p.Cars.Add(new Car { CarAge = 3, CarBrand = "BMW" });
        }
        public IEnumerator GetEnumerator()
        {
            yield return "E";
            yield return "F";
            yield return "G";
        }

        public IEnumerable<Car> IteratorMethod()
        {
            for (int i = 0; i < p.Cars.Count; i++)
            {
                yield return p.Cars[i];
                if (p.Cars[i].CarBrand == "Benz") yield break;
            }
        }
    }

    public class Person
    {
        public int Age { get; set; } = 27;
        public string Name { get; set; } = "Neil";
        public List<Car> Cars { get; set; } = new List<Car>();
    }

    public class Car
    {
        public int CarAge { get; set; }
        public string CarBrand { get; set; }
    }
}
