//
using M1S3_SistemaBanco;

List<Cliente> clientes = new List<Cliente>();
string opcao;
do{
Console.WriteLine("Bem vindos ao Full Stack Bank, escolha uma opção:");
Console.WriteLine("1 - Criar conta");
Console.WriteLine("2 - Adicionar transação");
Console.WriteLine("3 - Consultar extrato");
Console.WriteLine("4 - Exibir clientes");
Console.WriteLine("5 - Sair");
opcao = Console.ReadLine();

if(opcao == "1"){
    Cliente novoCliente = CriarConta();
    clientes.Add(novoCliente);
}

if(opcao == "4"){
    ExibirClientes();
}
Console.WriteLine("Tecle enter para continuar");
Console.ReadLine();
} while(opcao != "5");

void ExibirClientes(){
    Console.WriteLine($"Número da conta        | Nome      |  CPF ");
    for(int i = 0; i < clientes.Count; i++){
        Console.WriteLine($"{clientes[i].ResumoCliente}");

    }
}

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
