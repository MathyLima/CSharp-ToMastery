namespace DesafioPraticoFundamentosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Exercício que deseja executar (1-6):");
            Console.WriteLine("[1]Programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida. ");
            Console.WriteLine("[2]Programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.");
            Console.WriteLine("[3]Programa com 2 valores do tipo double já declarados que retorne operações matemáticas. ");
            Console.WriteLine("[4]Programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.");
            Console.WriteLine("[5]Programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018.");
            Console.WriteLine("[6]Programa que solicita ao usuário a exibição da data atual em diferentes formatos.");

            string? programaEscolhido = Console.ReadLine();

            switch (programaEscolhido)
            {
                case "1":
                    Exercicio1();
                    break;
                case "2":
                    Exercicio2();
                    break;
                case "3":
                    OperacoesMatematicas.Exercicio3();
                    break;
                case "4":
                    Exercicio4();
                    break;
                case "5":
                    Exercicio5();
                   
                    break;
                case "6":
                    Exercicio6();
                    break;
            }
        Console.WriteLine("Pressione Enter para sair");
        Console.ReadLine();
        }


        private static void Exercicio1()
        {
            Console.WriteLine("Por favor, Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
           

        }

        private static void Exercicio2()
        {
            Console.WriteLine("Por favor, Digite seu Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Por favor, Digite seu Sobrenome: ");
            string sobreNome = Console.ReadLine();
            Console.WriteLine($"Olá {nome?.Trim() +" "+ sobreNome?.Trim()}!");
           
        }

        private static void Exercicio4()
        {
            Console.WriteLine("Digite sua palavra");
            string palavra = Console.ReadLine();
            Console.WriteLine($"Sua palavra tem {palavra.Trim().Replace(" ","").Count()} caracteres, sem contar os espaços.");

        }

        private static void Exercicio5()
        {
            Console.WriteLine("Digite sua Placa, separando letras e números por '-', exemplo ABC-1234");
            string placa = Console.ReadLine();
            string[] partesPlaca = placa.Split("-");
            if(partesPlaca.Length != 2)
            {
                Console.WriteLine("Placa Inválida");
               
                return;
            }
            if (partesPlaca[0].Count() != 3 || partesPlaca[1].Count()!=4)
            {
                Console.WriteLine("Placa Inválida");
              
                return;
            }

            // Verifica se a primeira parte contém apenas letras
            if (!partesPlaca[0].All(char.IsLetter))
            {
                Console.WriteLine("Placa Inválida");
            
                return;
            }

            // Verifica se a segunda parte contém apenas números
            if (!partesPlaca[1].All(char.IsDigit))
            {
                Console.WriteLine("Placa Inválida");
                return;
            }

            Console.WriteLine("Placa Válida");
            
        }

        private static void Exercicio6()
        {
            // Exibe as opções de formato para o usuário
            Console.WriteLine("Escolha o formato de data que deseja ver:");
            Console.WriteLine("[1] Data completa (Dia/Mês/Ano)");
            Console.WriteLine("[2] Data com Mês/Ano");
            Console.WriteLine("[3] Data no formato Americano (Ano-Mês-Dia)");
            Console.WriteLine("[4] Hora atual (Horas:Minutos:Segundos)");

            string? formatoEscolhido = Console.ReadLine();

            // Obtém a data atual
            DateTime dataAtual = DateTime.Now;

            // Exibe a data conforme a escolha do usuário
            switch (formatoEscolhido)
            {
                case "1":
                    // Exibe data completa (Dia/Mês/Ano)
                    Console.WriteLine($"Data completa: {dataAtual.ToString("dd/MM/yyyy")}");
                    break;
                case "2":
                    // Exibe mês e ano
                    Console.WriteLine($"Mês e ano: {dataAtual.ToString("MM/yyyy")}");
                    break;
                case "3":
                    // Exibe data no formato americano (Ano-Mês-Dia)
                    Console.WriteLine($"Data no formato Americano: {dataAtual.ToString("yyyy-MM-dd")}");
                    break;
                case "4":
                    // Exibe hora atual (Horas:Minutos:Segundos)
                    Console.WriteLine($"Hora atual: {dataAtual.ToString("HH:mm:ss")}");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
