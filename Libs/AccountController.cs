using System;
using System.Collections.Generic;

namespace DIO.Bank.Libs
{
    public class AccountController
    {
        private static readonly List<Conta> listContas = new();

        public static void Transferir()
        {
            Utils.ClearScreen();
            Console.WriteLine("===================== Transferência =====================");
            Console.Write("Número da conta origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Número da conta destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Valor de transferência: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
            Console.WriteLine("--------------------------------------------------------");
            Utils.MenssageAlertCustom("Transferência Concluída".ToUpper(), ConsoleColor.Blue);
        }

        public static void Depositar()
        {
            Utils.ClearScreen();
            Console.WriteLine("======================= Deposito =======================");
            Console.Write("Número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Valor de deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
            Console.WriteLine("--------------------------------------------------------");
            Utils.MenssageAlertCustom("Depósito efetuado com sucesso!".ToUpper(), ConsoleColor.Blue);
        }

        public static void Sacar()
        {
            Utils.ClearScreen();
            Console.WriteLine("======================== Saque ========================");
            Console.Write("Número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Valor de saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
            Console.WriteLine("--------------------------------------------------------");
            Utils.MenssageAlertCustom("Saque realizado com sucesso!".ToUpper(), ConsoleColor.Blue);
        }

        public static void ListarContas()
        {
            Utils.ClearScreen();
            Console.WriteLine("=================================== Lista de Contas Cadastradas ===================================");

            if (listContas.Count == 0){
                Utils.MenssageAlertCustom("Nenhuma conta cadastrada.".ToUpper(), ConsoleColor.Red);
                Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
                return;
            }

            for(int i = 0; i < listContas.Count; i++){
                Conta conta = listContas[i];
                Console.WriteLine($"{"ID",8}|{"Conta",15}|{"Nome",30}|{"Saldo",20}|{"Crédito",20}|".ToUpper());
                Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
                Console.Write($"{"#"+i,8}|");
                Console.WriteLine(conta);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
        }

        public static void InserirConta()
        {
            Utils.ClearScreen();
            Console.WriteLine("======================== Nova Conta ========================");

            Console.Write("Digite 1 pra Conta Fisica ou 2 pra Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Crédito adicional: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------//--------------------//----------------");
            Conta novaConta = new(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);
            listContas.Add(novaConta);
            Utils.MenssageAlertCustom("Conta criada com sucesso!".ToUpper(), ConsoleColor.Green);
        }
    }
}