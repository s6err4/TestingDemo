﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    [TestFixture]
    public class operationsNunitTest
    {
        [Test]
        public void Add_ImputNumbers_ReturnNumber() {
            //Arrange
            //Operations operations = new Operations();
            //Operations operations = new();
            var operations = new operations();
            int number1 = 2;
            int number2 = 5;
            
            //2. ACT
            int result = operations.Add(number1, number2);
            
            //3.  ASSERT
            Assert.That(result, Is.EqualTo(7));
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));
        }

        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        public void IsEven_ImputNumber_ReturnTrue(int number) { 
            //Arrange
            operations operations = new operations();
            //int number = 10;

            var result = operations.IsEven(number);

            Assert.That(result, Is.True);   
        }

        [Test]
        [TestCase(2.2,1.2)]
        [TestCase(2.23,1.24)]
        public void AddDecimal_ImputDoubleNumber_ReturnDoubleNumber(double number1, double number2) {
            operations operations = new();

            double result = operations.AddDecima(number1, number2);

            Assert.That(result, Is.EqualTo(3.4).Within(0.1));
        }
    }
}
