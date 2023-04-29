using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinkedList.Logic
{
    public class DoubleList<T>
    {
        private DoubleNode<T>? _first;
        private DoubleNode<T>? _last;

        public DoubleList()
        {
            _first = null;
            _last =  null;
            Count = 0;
        }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null) 
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }

        public void Add(T item) 
        {
            var node = new DoubleNode<T>(item);
            if(IsEmpty) 
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }


        public DoubleList<Car> GetYear(int lower, int upper)
        {
            var result = new DoubleList<Car>();

            var pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data is Car car && car.Year >= lower && car.Year <= upper)
                {
                    result.Add(car);
                }

                pointer = pointer.Right;
            }

            return result;
        }

        public DoubleList<Car> GetBrand(string brand)
        {
            var result = new DoubleList<Car>();

            var pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data is Car car && car.Brand?.Equals(brand, StringComparison.OrdinalIgnoreCase) == true)
                {
                    result.Add(car);
                }

                pointer = pointer.Right;
            }

            return result;
        }



        public DoubleList<Car> GetPrice(decimal lower, decimal upper)
        {
            var result = new DoubleList<Car>();

            var pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data is Car car && car.Price >= lower && car.Price <= upper)
                {
                    result.Add(car);
                }

                pointer = pointer.Right;
            }

            return result;
        }



        public DoubleList<Car> GetSeveralFilters(string brand, string model, string color, int minimumYear, decimal maximumPrice)
        {
            var result = new DoubleList<Car>();

            var pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data is Car car)
                {
                    if (brand == "*" || car.Brand.ToLower() == brand.ToLower())
                    {
                        if (model == "*" || car.Model.ToLower() == model.ToLower())
                        {
                            if (color == "*" || car.Color.ToLower() == color.ToLower())
                            {
                                if (minimumYear <= 0 || car.Year >= minimumYear)
                                {
                                    if (maximumPrice <= 0 || car.Price <= maximumPrice)
                                    {
                                        result.Add(car);
                                    }
                                }
                            }
                        }
                    }
                }

                pointer = pointer.Right;
            }

            return result;
        }


        public Car[] GetMinMax(DoubleList<Car> list)
        {
            Car[] result = new Car[2];
            var pointer = list._first;
            result[0] = pointer.Data;
            result[1] = pointer.Data;

            while (pointer != null)
            {
                if (pointer.Data.Price < result[0].Price)
                {
                   
                    result[0] = pointer.Data;
                }

                if (pointer.Data.Price > result[1].Price)
                {
                   
                    result[1] = pointer.Data;
                }

                pointer = pointer.Right;
            }

            return result;
        }




    }
}
