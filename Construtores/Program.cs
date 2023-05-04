using Classe_Produto;

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco, quantidade);

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.Write("Digite o número dos produtos a serem adicionados: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite o número dos produtos a serem removidos: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);