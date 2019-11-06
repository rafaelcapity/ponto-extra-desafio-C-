using System;
using System.Collections.Generic;

namespace cadastro_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<aluno> alunoAdd = new List<aluno>();
            int comand, id = 0, i = 0;
            bool continuar = true;
            string name;
            bool encontrou ;
            int ra;

            while (continuar == true)
            {
                comand = 0;
                Console.WriteLine(" 1- Incluir Aluno \n"  +  " 2- Excluir Aluno " +  "\n 3- Consultar Lista " + "\n 0- Sair ");
                comand = Convert.ToInt32(Console.ReadLine());
                if (comand == 1)
                {
                    var cad = new aluno();
                    cad.ra = id;

                    Console.Write("Nome do aluno:");
                    cad.Nome = Console.ReadLine();

                    Console.Write("RA do aluno:");
                    cad.ra = Convert.ToInt32(Console.ReadLine());


                    Console.Write("Data de Nascimento:");
                    cad.DataNasc = Console.ReadLine();


                    Console.Write("Cursos:");
                    cad.Cursos = Console.ReadLine();

                    alunoAdd.Add(cad);
                }
                else if (comand == 2)
                {
                    Console.WriteLine("Nome deve ser excluído:");
                    name = Console.ReadLine();
                    encontrou = false;

                    foreach (var item in alunoAdd)
                    {

                        if (name == item.Nome)
                        {
                            id = i;
                            encontrou = true;
                        }
                        i++;
                    }
                    if (encontrou)
                    {
                        alunoAdd.RemoveAt(id);
                    }

                    else
                    {
                        Console.WriteLine("Aluno não encontrado ");
                    }
;
                }
                else if (comand == 3)
                {
                    Console.WriteLine("1 - Nome " );
                    Console.WriteLine("2 - RA ");
                    Console.WriteLine("Por qual você deseja consultar ");
                    int escolha = Convert.ToInt32(Console.ReadLine());
                    if (escolha == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do aluno que deseja consultar :");
                        name = Console.ReadLine();

                        foreach (var item in alunoAdd)
                        {
                            if (name == item.Nome)
                            {
                                Console.WriteLine("RA :" + item.ra);
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Data de Nascimento:" + item.DataNasc);
                                Console.WriteLine("Cursos: " + item.Cursos + "\n");

                            }
                        }
                    }

                    else
                    {

                        Console.Clear();
                        Console.WriteLine("RA do Aluno que deseja consultar :");
                        ra = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in alunoAdd)
                        {
                            if (ra == item.ra)
                            {
                                Console.WriteLine("RA :" + item.ra);
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Data de Nascimento:" + item.DataNasc);
                                Console.WriteLine("Cursos: " + item.Cursos + "\n");

                            }

                        }
                        
                      

                        


                        
                    }
                }
                else if (true)
                {
                    continuar = false;
                    Console.Write("Hora de fechar a matrícula...");
                }
                id++;
            }
        }
    }
}