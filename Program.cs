using System;

namespace Aula_1___Exercicio {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Programa de IMC");

            //inicio do programa
            string[] nome = new string[4];
            string[] genero = new string[4];
            float[] id = new float[4];
            float[] kg = new float[4];
            float[] h = new float[4];
            int fem = 0;
            int masc = 0;
            float idTotalF = 0;
            float idTotalM = 0;

            //não precisa de I = CONTADOR pq poe no for 

            // FOR
            for (int i = 0; i < 4; i++) {

                System.Console.WriteLine ("Qual teu genero? F/M");
                genero[i] = Console.ReadLine ();

                if (genero[i].Contains ("f")) {
                    fem++;
                } else {
                    masc++;
                }

                //FEMININO
                if (genero[i].Contains ("f")) {

                    System.Console.WriteLine ("Qual teu nome?");
                    nome[i] = Console.ReadLine ();

                    System.Console.WriteLine ("Qual a sua idade?");
                    id[i] = int.Parse (Console.ReadLine ());

                    idTotalF = +id[i];

                    System.Console.WriteLine ("Qual a sua altura");
                    h[i] = float.Parse (Console.ReadLine ());

                    System.Console.WriteLine ("Qual teu peso?");
                    kg[i] = float.Parse (Console.ReadLine ());

                    System.Console.WriteLine ($"{nome[i]}, seu IMC é de{kg[i]/(h[i]*h[i])}");

                } else {

                    //MASCULINO
                    System.Console.WriteLine ("Qual teu nome?");
                    nome[i] = Console.ReadLine ();

                    System.Console.WriteLine ("Qual a sua idade?");
                    id[i] = int.Parse (Console.ReadLine ());

                    idTotalM = +id[i];

                    System.Console.WriteLine ("Qual a sua altura");
                    h[i] = float.Parse (Console.ReadLine ());

                    System.Console.WriteLine ("Qual teu peso?");
                    kg[i] = float.Parse (Console.ReadLine ());

                    System.Console.WriteLine ($"{nome[i]}, seu IMC é de: {kg[i]/(h[i]*h[i])}");
                }

            }
            // System.Console.WriteLine ($"A média da idade das mulheres é de {idTotalF/fem}");
            // System.Console.WriteLine ($"A média da idade das homens é de {idTotalM/masc}");
            // System.Console.WriteLine ($"Total de mulheres: {fem} ");
            // System.Console.WriteLine ($"Total de homens: {masc} ");

            Console.WriteLine($@"
            A média da idade das mulheres é de {idTotalF/fem}
                Total de mulheres: {fem}

            A média da idade das homens é de {idTotalM/masc}
                Total de homens: {masc}

            ");

        }
    }
}