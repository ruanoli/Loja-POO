using TayLuStore.Dominio;
using System;

namespace TayLuStore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numberRandom = aleatorio.Next(1, 1000); //Gerar ID aleatório.
            int idUsuario = numberRandom;

            Console.WriteLine($"#ID {idUsuario}");

            Console.WriteLine("Digite o nome do usuário: ");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite o email do usuário: ");
            string emailUsuario = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
     
            //Exemplo Usuário
            Usuario usuario = new Usuario(nomeUsuario, 4, emailUsuario, "123458",idUsuario);

            Console.WriteLine("Dados do usuário:");
            Console.WriteLine($"#ID {idUsuario}");
            Console.WriteLine($"Nome: {usuario.Nome}");
            Console.WriteLine($"Email: {usuario.Email}");
            Console.WriteLine($"Ativo: {usuario.AtivarUsuario()}");

            //Exemplo Perfil
            Perfil perfil = new Perfil("Administrador", "Acesso liberado à todo sistema", idUsuario, DateTime.Now);
            usuario.Perfil = perfil;
            var perfilUsuario = usuario.Perfil;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Detalhes do Perfil do usuário:");
            Console.WriteLine($"#ID {perfilUsuario.Id}");
            Console.WriteLine($"Descrição: {perfilUsuario.Descricao}.");
            Console.WriteLine($"Regra: {perfilUsuario.Regras}.");
            Console.WriteLine($"Data de cadastro: {perfilUsuario.DataCadastro}");

            //Exemplo Produto. IMPLEMENTAR DEPOIS!
            /*
            Produto produto = new Produto("Video Game", "Playstation 5", 4.600M, 10, 2);

            Console.WriteLine();
            Console.WriteLine();
            produto.ReporEstoque(10);
            Console.WriteLine($"Quantidade: {produto.QuantEstoque}");
            produto.DebitarEstoque(30);
            Console.WriteLine($"Quantidade atual: {produto.QuantEstoque}");

            Console.WriteLine($"Possui estoque? {produto.PossuiEstoque()}");
            */
        }
    }
}
