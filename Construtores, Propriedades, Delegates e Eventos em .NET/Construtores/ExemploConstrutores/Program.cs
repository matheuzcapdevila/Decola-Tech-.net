using System;
using ExemploConstrutores.Models; //Realização do import de pessoa

namespace ExemploConstrutores{
    class Program{
        public delegate void Operacao(int x, int y);
        static void Main(string[] args){
            
            Matematica m = new Matematica(10,20);
            m.Somar();
            //Operação op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            //  op.Invoke(15,10);

            //Data data = new Data();
            //data.SetMes(20);

            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            
        

            //pi = 0; // Não é possível

            // data.Mes = 23;
            // System.Console.WriteLine(data.Mes);
            //data.ApresentarMes();
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log log2=Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            
            // Aluno p1 = new Aluno("Matheus", "Lopes", "Matematica");
            // p1.Apresentar();
        }
    }
} 