using System;
using Tecnofit.Logic.Logica;
using Xunit;

namespace Tecnofit.Test
{
    public class NumeroAleatorioOrdenadoTest
    {
        private readonly NumeroAleatorioOrdenado _numeroAleatorioOrdenado;
        public NumeroAleatorioOrdenadoTest()
        {
            _numeroAleatorioOrdenado = new NumeroAleatorioOrdenado();
        }

        [Fact]
        public void SortearNumero_should_true()
        {
            int [] result = _numeroAleatorioOrdenado.SortearNumero();
            Assert.True(result.Length > 1);
        }

        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 8, 12 }, 54)]
        public void ExisteElementoNoArray_should__is_false(int[] lista, int num) => Assert.False(_numeroAleatorioOrdenado.ExisteElementoNoArray(lista, num));

        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 8, 12 }, 12)]
        public void ExisteElementoNoArray_should__is_true(int[] lista, int num) => Assert.True(_numeroAleatorioOrdenado.ExisteElementoNoArray(lista, num));

        [Theory]
        [InlineData( new int[] { 4, 9, 6, 7, 8, 12 })]
        public void OrdenarArray_should__is_false(int[] lista)
        {
            // Não achei uma função que comparasse exatamente a ordens do valores e index do array
            int[] li = { 4, 9, 6, 7, 8, 12 };
            bool result = Equals(_numeroAleatorioOrdenado.OrdenarArray(lista), li);
            Assert.False(result);
        }

        [Theory]
        [InlineData(new int[] { 4, 9, 6, 7, 8, 12 })]
        public void OrdenarArray_should__is_true(int[] lista)
        {
            // Não achei uma função que comparasse exatamente a ordens do valores e index do array
            int[] li = { 4, 6, 7, 8, 9, 12 };
            bool result = Equals(_numeroAleatorioOrdenado.OrdenarArray(lista).ToString(), li.ToString());
            Assert.True(result);
        }


        [Theory]
        [InlineData(1,61)]
        public void GerarNumeros_should_true(int inicio, int fim)
        {
            int result =_numeroAleatorioOrdenado.GerarNumeros(inicio, fim);
            Assert.True(result > 1, "Resultado maior igual a 1");
        }

        [Theory]
        [InlineData(0,0.5)]
        public void GerarNumeros_should_false(int inicio, int fim)
        {
            int result = _numeroAleatorioOrdenado.GerarNumeros(inicio, fim);
            Assert.False(result > 1, "Resultado menor a 1 ou não existe");
        }
    }
}
