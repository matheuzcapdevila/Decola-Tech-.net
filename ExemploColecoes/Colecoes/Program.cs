using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes {
    class Program
    {
        static void Main(string[] args)
        {
            // Parte 1
            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;
            // System.Console.WriteLine("Percorrendo o array pelo for: ");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }
            // System.Console.WriteLine("Percorrendo o array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

            //Parte 2

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30"); //Converte string para int
            // arrayInteiros[4] = 5;

            //Parte 3
            // matriz[0, 0] = 5;
            // int[,] matrix = new int[4,2]
            // {
            //     //colunas
            //     {8,8}, //linhas
            //     {80,80},
            //     {800,800},
            //     {8000,900}
            // };
            
            // for (int i = 0; i < matrix.GetLength(0);i++){
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matrix[i,j]);
            //     }

            // Parte 3
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 1};

            // System.Console.WriteLine("Array original:");
            // op.ImprimirArray(array);

            // op.OrdenarBubbleSort(ref array);
            // System.Console.WriteLine("Array ordenado:");
            // op.ImprimirArray(array);

            // Parte 4 
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 1};

            // System.Console.WriteLine("Array original:");
            // op.ImprimirArray(array);

            // op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado:");
            // op.ImprimirArray(array);

            //Parte 5

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 1};
            // int[] arrayCopia = new int[10];

            // System.Console.WriteLine("Array (cópia) antes da cópia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);

            // System.Console.WriteLine("Array depois da copia:");
            // op.ImprimirArray(arrayCopia);

            //Parte 6

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 3};
            // int[] arrayCopia = new int[10];

            // int valorProcurado = 1;
            // bool existe = op.Existe(array, 1);

            // if(existe){
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            // Parte 7

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 3};
            // int[] arrayCopia = new int[10];

            // int valorProcurado = 5;

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existem valores que não são maiores do que o valor {0}", valorProcurado);
            // }
            //Parte 8
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 3};
            // int[] arrayCopia = new int[10];

            // int valorProcurado = 15;

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado>0) 
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }
            // Parte 9
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 3};
            // int[] arrayCopia = new int[10];

            // int valorProcurado = 3;
            
            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice>-1){ //-1 porque não tem essa posição no array
            //     System.Console.WriteLine("O indice de elemento{0} é:{1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }

            //Parte 10

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {4, 6, 5, 9, 3};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // int valorProcurado = 3;

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

            // }
            
            // Parte 11 colecoes genéricas
            // List<string> estados = new List<string>();
            //  estados.Add("SP");
            //  estados.Add("MG");
            //  estados.Add ("Ba");

            //  System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            //  foreach (var item in estados)
            //  {
            //      System.Console.WriteLine(item);
            //  }
            // for (int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"Índice{i}, Valor: estados{estados[i]}");
            // }

            //Parte 12 - Removendo elemento da lista
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>();
            //  estados.Add("SP");
            //  estados.Add("MG");
            //  estados.Add ("Ba");

            //  System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);
            // System.Console.WriteLine("Removendo elementos");
            // estados.Remove("MG");

            // opLista.ImprimirListaString(estados);

            // Parte 13 - Adicionando coleões na lista
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>(){"SP", "MG", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};
            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Adicionando os novos");

            // System.Console.WriteLine("");

            // estados.AddRange(estadosArray); //Mantem os originais e adiciona os novos no final da lista

            // opLista.ImprimirListaString(estados);

            //Parte 14 - Adicionando elementos por índice

            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>(){"SP", "MG", "BA"};
            string[] estadosArray = new string[2] {"SC", "MT"};
            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            System.Console.WriteLine("Adicionando os novos");

            System.Console.WriteLine("");

            estados.Insert(1, "RJ"); //Adiciona um elemento em uma posição

            opLista.ImprimirListaString(estados);




            
         

        }
        }
    }
