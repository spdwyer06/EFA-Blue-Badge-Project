﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data
{
    public class Pizza
    {
        public enum CrustType { pan, handtossed, thin }
        public enum ToppingType { pepperoni = 2, sausage = 2, ham = 2, bacon = 2, chicken = 2, mushrooms = 1, onions = 1, tomatoes = 1, blackOlives = 1, bellPeppers = 1, jalapenos = 1, extraCheese = 1, none = 0 }
        public enum SauceType { red, white, pesto }
        public enum SizeType { S = 8, M = 10, L = 12, XL = 14 }

        /* public static Dictionary<SizeType, double> Cost = new Dictionary<SizeType, double>
             {
             {SizeType.XL, 20},
             {SizeType.L, 16},
             {SizeType.M, 12},
             {SizeType.S, 8},
              };

             Price = Cost[size];
         */

        [Key]
        public int PizzaId { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        [Required]//EAC: is this required since it will be autoset?
        public int UserId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public bool Cheese { get; set; }
        [Required]
        public CrustType TypeOfCrust { get; set; }
        [Required]
        public SauceType TypeOfSauce { get; set; }
        [Required]
        public SizeType TypeOfSize { get; set; }
        private ToppingType _typeOfToppingOne;
        public ToppingType? TypeOfToppingOne
        {
            get
            {
                return _typeOfToppingOne;
            }
            set
            {
                if (value != null)
                {
                    _typeOfToppingOne = (Pizza.ToppingType)value;
                }
                else
                {
                    _typeOfToppingOne = Pizza.ToppingType.none;
                }
            }
        }
        private ToppingType _typeOfToppingTwo;
        public ToppingType? TypeOfToppingTwo
        {
            get
            {
                return _typeOfToppingTwo;
            }
            set
            {
                if (value == null)
                {
                    _typeOfToppingTwo = Pizza.ToppingType.none;
                }
            }
        }
        private ToppingType _typeOfToppingThree;
        public ToppingType? TypeOfToppingThree
        {
            get
            {
                return _typeOfToppingThree;
            }
            set
            {
                if (value == null)
                {
                    _typeOfToppingThree = Pizza.ToppingType.none;
                }
            }
        }
        private ToppingType _typeOfToppingFour;
        public ToppingType? TypeOfToppingFour
        {
            get
            {
                return _typeOfToppingFour;
            }
            set
            {
                if (value == null)
                {
                    _typeOfToppingFour = Pizza.ToppingType.none;
                }
            }
        }
        private ToppingType _typeOfToppingFive;
        public ToppingType? TypeOfToppingFive
        {
            get
            {
                return _typeOfToppingFive;
            }
            set
            {
                if (value == null)
                {
                    _typeOfToppingFive = Pizza.ToppingType.none;
                }
            }
        }

        //default value of price
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value == 0)
                {
                    _price = (double)TypeOfSize + (double)TypeOfToppingOne + (double)TypeOfToppingTwo + (double)TypeOfToppingThree + (double)TypeOfToppingFour + (double)TypeOfToppingFive;

                }
            }
        }
        

        
       /* public double Price
        {
            get
            {
                _price = (double)TypeOfSize + (double)TypeOfToppingOne + (double)TypeOfToppingTwo + (double)TypeOfToppingThree + (double)TypeOfToppingFour + (double)TypeOfToppingFive;
                return _price;
            }
            set
            {
                _price = value;
            }
        }*/

        //We need to set default value to ""
        private string _comment;
        public string Comment
        {
            get
            {
                return _comment;
            }

            set
            {
                if (value == null)
                {
                    _comment = "";
                }
            }
        }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }


}