using System;
using System.Collections.Generic;
using MediaPonderadaV4;
using System.Linq;


namespace MediaPonderadaV4
{
    public class Program
    {
        static void Main (string[] args)
        {

            Console.Title = "Bem vindo ao programa para cálculo de Média Ponderada!";

            // 1. Vc vai fazer uma lista de Notas, que é uma classe que vc vai criar
            string inputNota;
            string inputNumeroEntrevistados;

            var nota = new Nota();
            //List<decimal> Nota = new List<decimal>();

            var entrevistado = new Entrevistado();

            do
            {
                Console.WriteLine("\nDigite a nota do entrevistado ou digite 'F' para finalizar.");
                inputNota = Console.ReadLine();

                if ((int.TryParse(inputNota, out int digitedNumber) == true))
                {
                    decimal valorNota = decimal.Parse(inputNota);
                    nota.valorNota = valorNota;

                    // Nota.Add(nota.valorNota); // argument cannot convert from decimal to Nota -> só mudei o tipo da Lista
                    // qual das duas eu mantenho aqui? R: Nenhuma
                    // nota.Notas.Add(valorNota);
                    // nota.Notas.Add(nota.valorNota);

                    do
                    {
                        Console.WriteLine("\nDigite quantos entrevistados tiraram essa nota.");
                        inputNumeroEntrevistados = Console.ReadLine();

                        if ((int.TryParse(inputNumeroEntrevistados, out int digitedQuantidade) == true))
                        {
                            int numeroEntrevistados = int.Parse(inputNumeroEntrevistados);
                            nota.numeroEntrevistados = numeroEntrevistados;
                            // Nota.Add(nota.numeroEntrevistados); //argument cannot convert int to Nota

                            // 2.Com os dois valores, vc vai instanciar sua classe e colocar em uma lista
                            
                            // qual das duas eu mantenho aqui?
                            // nota.Notas.Add(numeroEntrevistados);
                            // nota.Notas.Add(nota.numeroEntrevistados);

                            // aqui eu coloco na lista já o total dessa nota (nota * peso)
                            var multi = numeroEntrevistados * valorNota;
                            nota.Notas.Add(multi);

                            // preciso armazenar o total de entrevistados pra calcular a ponderada? Sim
                            entrevistado.Entrevistados.Add(numeroEntrevistados);


                        }

                        else
                        {
                            Console.WriteLine("Ops, você digitiu uma quantidade de entrevistados inválida!");
                        }
                    }
                    while (((int.TryParse(inputNumeroEntrevistados, out int digitedQuantidade2) == false)));
                }

                else if (inputNota == "F")
                {
                    Console.WriteLine("\nTodas as notas imputadas com sucesso!\nAperte qualquer tecla para seguir.");
                }
                else
                {
                    Console.WriteLine("Ops, você digitiu uma nota inválida!\n");
                }

            }
            while (inputNota != "F");

            Console.WriteLine($"a nota foi " + nota.valorNota + " e a quantitade de entrevistados com essa nota foi " + nota.numeroEntrevistados);



            Console.WriteLine(nota);
            Console.WriteLine(entrevistado);

            // --> agora que tenho a info das notas*peso e da quantidade de entrevistados (peso total), dá pra calcular
            // mas como fazer a soma das listas...


            decimal totalNotas = nota.Notas.Sum();
            int totalEntrevitados = entrevistado.Entrevistados.Sum();
            Console.WriteLine("O total das notas é: " + totalNotas);
            Console.WriteLine("O total de entrevistados (peso) é: " + totalEntrevitados);

            // não precisou de int e resto
            // decimal mediaPonderadaInt = totalNotas / totalEntrevitados;
            // decimal mediaPonderadaResto = totalNotas % totalEntrevitados;


            decimal mediaPonderada = totalNotas / totalEntrevitados;
            // Console.WriteLine("A média ponderada de todas as notas é " + mediaPonderada + ".");

            Console.WriteLine("A média ponderada de todas as notas é " + Math.Round(mediaPonderada, 2).ToString() + ".");

            Console.WriteLine("\nAperte qualquer tecla pra encerrar =)");
            Console.ReadKey();



            




            //var customer = new Customer();

            //customer.Id = 1;
            //customer.Name = "Pedro";

            //var order = new Order();
            //customer.Orders.Add(order);

            //Console.WriteLine(customer.Name, customer.Id);

            //List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };
            //int totalMyList = myList.Sum();


        }
    }
}