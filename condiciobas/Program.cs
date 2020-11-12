using System;

namespace condiciobas
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //declarar as variaveis 
        float nota1, nota2, nota3, media;
        string nomeCompleto;


        //entrada de dados
        Console.WriteLine("Digite o nome do aluno");
        nomeCompleto = Console.ReadLine();
        
        Console.Write("Digite a primeira nota: ");
        nota1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a primeira nota: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a primeira nota: ");
        nota3 = float.Parse(Console.ReadLine());

        //processamento 

        media = (nota1+nota2+3/3/3);

        //exibir resultado
        if(media>5){
            //valor verdadeiro
            Console.WriteLine("O aluno "+nomeCompleto+" está aprovado com a média de: "+media);
        }else{
            //valor valor
            Console.WriteLine("O aluno "+nomeCompleto+" está reprovado com a media de: "+media);
        }



        }
    }
}
