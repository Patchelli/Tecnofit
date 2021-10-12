using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnofit.Logic.Logica;
using Xunit;

namespace Tecnofit.Test.LogicaTest
{
    public class PalindromoTest
    {
        Mock mock = new Mock<Palindromo>();
        private readonly Palindromo _palindromo;
        public PalindromoTest()
        {
            _palindromo = new Palindromo();

        }

        [Theory]
        [InlineData("ovo")]
        public void IsPalindromo_should_true(string str)
        {
            // Estudar sobre as exceções para trabalhar os testes do tipo void
        }

        [Theory]
        [InlineData("novo")]
        public void IsPalindromoReverse_should_false(string str)
        {
            bool result = _palindromo.IsPalindromoReverse(str);
            Assert.False(result);
        }

        [Theory]
        [InlineData("ovo")]
        public void IsPalindromoReverse_should_true(string str)
        {
            bool result = _palindromo.IsPalindromoReverse(str);
            Assert.True(result);
        }
    }
}
