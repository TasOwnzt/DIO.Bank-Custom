using System;
using DIO.Bank.Libs;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.ClearScreen();
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        AccountController.ListarContas();
                        break;
                    case "2":
                        AccountController.InserirConta();
                        break;
                    case "3":
                        AccountController.Transferir();
                        break;
                    case "4":
                        AccountController.Sacar();
                        break;
                    case "5":
                        AccountController.Depositar();
                        break;
                    case "C":
                        Utils.ClearScreen();
                        break;
                    default:
                        Utils.MenssageAlertCustom("Opção selecionada inválida!!!", ConsoleColor.Red);
                        return;
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Utils.MenssageAlertCustom("Obrigado por utilizar nossos serviços.", ConsoleColor.Yellow);
        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("====================================================");
            Utils.MenssageAlertCustom("             DIO Bank a seu dispor!!!           ", ConsoleColor.Cyan, false);
            Console.WriteLine("====================================================");
            Console.WriteLine("Informe a opção desejada: \n");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir Nova Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            Console.Write("Opção: ");
            string opcaoUsuario = Console.ReadLine().ToUpper().Trim();
            if (opcaoUsuario.Length > 1){
                opcaoUsuario = Convert.ToString(opcaoUsuario[0]);
            }
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
