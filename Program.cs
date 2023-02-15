//
using M1S3_SistemaBanco;

Cliente CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();

    Console.WriteLine("CPF do cliente:");
    cliente.CPF = Console.ReadLine();

    Console.WriteLine("Endereço do cliente:");
    cliente.Endereco = Console.ReadLine();

    Console.WriteLine("Data de nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("E-mail do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Número da conta:");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    return cliente;

}

string opcao;
do{
Console.WriteLine("Bem vindos ao Full Stack Bank, escolha uma opção:");
Console.WriteLine("1 - Criar conta");
Console.WriteLine("2 - Adicionar transação");
Console.WriteLine("3 - Consultar extrato");
Console.WriteLine("4 - Sair");
opcao = Console.ReadLine();

if(opcao == "1"){
    Cliente novoCliente = CriarConta();
}
} while(opcao != "3");