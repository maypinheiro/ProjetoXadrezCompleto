
using Keanu;
using System;
using Xunit;

namespace ProjetoXadrez.Tests
{

 [Fact]
        public void CalculaTamanhoTabuleiro()
        {
            //Arrange
            var xadrez = new Xadrez();

            //Act
            var tamanho = xadrez.CalculaTamanhoTabuleiro(3);

            //Assert
            Assert.Equal(9,tamanho.Tamanho);
        }
        [Fact]
        public void CalculaBrancas()
        {
            //Arrange
            var xadrez = new Xadrez();

            //Act
            var tamanho = xadrez.CalculaTamanhoTabuleiro(3);

            //Assert
            Assert.Equal(5, tamanho.Branca);
        }

        [Fact]
        public void CalculaPretas()
        {
            //Arrange
            var xadrez = new Xadrez();

            //Act
            var tamanho = xadrez.CalculaTamanhoTabuleiro(3);

            //Assert
            Assert.Equal(4, tamanho.Preta);
        }

        [Theory]
        [InlineData(4,16)]
        [InlineData(8, 64)]
        [InlineData(5, 25)]
        [InlineData(2, 4)]
        [InlineData(7, 49)]

        public void CalculaTamanhoTabuleiroValoresCorretos(int v1, int total)
        {
            //Arrange
            var xadrez = new Xadrez();
            //Act
            var tamanho = xadrez.CalculaTamanhoTabuleiro(v1);
            //Assert
            Assert.Equal(total, tamanho.Tamanho);

        }

        [Theory]
        [InlineData(4,8)]
        [InlineData(8,32)]
        [InlineData(5,13)]
        [InlineData(2,2)]
        [InlineData(7,25)]
        public void CalculaBrancasValoresCorretos(int v1, int totalBrancas)
        {
            //Arrange
            var xadrez = new Xadrez();
            //Act
            var tamanho = xadrez.CalculaTamanhoTabuleiro(v1);
            //Assert
            Assert.Equal(totalBrancas, tamanho.Branca);

        }

        [Theory]
        [InlineData(4, 8)]
        [InlineData(8, 32)]
        [InlineData(5, 12)]
        [InlineData(2, 2)]
        [InlineData(7, 24)]
        public void CalculaPretasValoresCorretos(int v1, int totalPretas)
        {
            //Arrange
            var xadrez = new Xadrez();
            //Act
            var tamanho = xadrez.CalculaTamanhoTabuleiro(v1);
            //Assert
            Assert.Equal(totalPretas, tamanho.Preta);

        }
 }
