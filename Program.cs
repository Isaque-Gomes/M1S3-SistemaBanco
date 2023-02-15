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
    CriarConta();
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
        Console.WriteLine(clientes[i].ResumoCliente());

    }
}

void CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Data de nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    if(! cliente.MaiorIdade()){
    Console.WriteLine("Não é possível abrir a conta, pois o cliente é menor de idade");
    return;
    }
    Console.WriteLine("A idade do cliente é " + cliente.Idade);
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do cliente:");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereço do cliente:");
    cliente.Endereco = Console.ReadLine();
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("E-mail do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Número da conta:");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    clientes.Add(cliente);

}
