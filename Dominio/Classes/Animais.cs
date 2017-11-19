using System;
using System.IO;

namespace Dominio
{
    public class Animais
    {

        public Animais(string nomeAnimal, int idade, double peso, string porte, string nomeDono, int idAnimal)
        {
            this.nomeAnimal = nomeAnimal;
            this.idade = idade;
            this.peso = peso;
            this.porte = porte;
            this.nomeDono = nomeDono;
            this.idAnimal = idAnimal;

        }
        public string nomeAnimal { get; set; }
        public int idade { get; set; }
        public double peso { get; set; }
        public string porte { get; set; }
        public string nomeDono { get; set; }
        public int idAnimal { get; set; }


        public Animais()
        {

        }

        public Animais(int idAnimal, string nomeAnimal, int idade, double peso, string porte, string nomeDono)
        {
            this.idAnimal = idAnimal;
            this.nomeAnimal = nomeAnimal;
            this.idade = idade;
            this.peso = peso;
            this.porte = porte;
            this.nomeDono = nomeDono;
        }


    }
}