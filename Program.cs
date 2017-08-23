using System;

namespace SwitchCaseMenu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int menu;
			Console.Write("Digite a opção desejada: ");
			menu = Convert.ToInt32(Console.ReadLine());
			switch (menu)
			{
				case 1:
					Console.Write("Você selecionou a opção 1 – Cadastros");
					break;
				case 2:
					Console.Write("Você selecionou a opção 2 – Vendas");
					break;
				case 3:
					Console.Write("Você selecionou a opção 3 – Compras");
					break;
				case 4:
					Console.Write("Você selecionou a opção 4 – Relatórios");
					break;
				case 5:
					Console.Write("Você selecionou a opção 5 – Sair");
					break;
				default:
					Console.Write("Opção inválida");
					break;
			}
			Console.ReadLine();
        }
    }
}
