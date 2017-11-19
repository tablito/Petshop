using System;
using System.IO;
using Dominio;

namespace Repositorio

{
        public class AnimaisRep
        {


            public void cadastrar(Animais animal){
            string mensg;

            try
             {
                StreamWriter cadastroAnimal;

                cadastroAnimal = new StreamWriter("cadastroAnimal.csv", true);

                cadastroAnimal.WriteLine(
                    animal.idAnimal + ";" +
                    animal.nomeAnimal + ";" +
                    animal.idade + ";" +
                    animal.peso + ";" +
                    animal.porte + ";" +
                    animal.nomeDono
                   );

                mensg = "Cadastro salvo!";

            } // fim try

             catch (Exception e)
             {
                mensg = "erro: " + e;

             } // fim do catch
   
             }   


             public string pesquisar(int idAnimal){
                 string msg = "";


                 return msg;
             }        
     }

}    
