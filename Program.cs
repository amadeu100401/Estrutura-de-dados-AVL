using AVL;

AVLTree tree = new AVLTree();
Random randNum = new Random();

//Teste 1
//tree.root = tree.InsertionTree(tree.root, 10);
//tree.root = tree.InsertionTree(tree.root, 20);
//tree.root = tree.InsertionTree(tree.root, 30);
//tree.root = tree.InsertionTree(tree.root, 40);
//tree.root = tree.InsertionTree(tree.root, 50);
//tree.root = tree.InsertionTree(tree.root, 25);
//tree.root = tree.InsertionTree(tree.root, 26);
//tree.root = tree.InsertionTree(tree.root, 27);
//tree.root = tree.InsertionTree(tree.root, 28);

//Teste 2
//tree.root = tree.InsertionNode(tree.root, 130);
//tree.root = tree.InsertionNode(tree.root, 120);
//tree.root = tree.InsertionNode(tree.root, 110);
//tree.root = tree.InsertionNode(tree.root, 100);
//tree.root = tree.InsertionNode(tree.root, 90);
//tree.root = tree.InsertionNode(tree.root, 80);
//tree.root = tree.InsertionNode(tree.root, 70);

//Teste 3
//tree.root = tree.InsertionNode(tree.root, 20);
//tree.root = tree.InsertionNode(tree.root, 10);
//tree.root = tree.InsertionNode(tree.root, 4);

//tree.root = tree.InsertionNode(tree.root, 20);
//tree.root = tree.InsertionNode(tree.root, 10);
//tree.root = tree.InsertionNode(tree.root, 30);
//tree.root = tree.InsertionNode(tree.root, 50);
//tree.root = tree.InsertionNode(tree.root, 100);
//tree.root = tree.InsertionNode(tree.root, 9);
//tree.root = tree.InsertionNode(tree.root, 12);
//tree.root = tree.InsertionNode(tree.root, 29);
//tree.root = tree.InsertionNode(tree.root, 28);

Console.WriteLine("Informe o número de nodos da árvore: ");
string aux = Console.ReadLine();
List<int> numbers = new List<int>();
int n = Int32.Parse(aux);
int x;


for (int i = 0; i < n; i++)
{
    x = randNum.Next(100);
    numbers.Add(x);
    tree.root = tree.InsertionNode(tree.root, x);
}

Console.Write("Ordem de números inseridos: ");
foreach (int i in numbers)
{
    Console.Write($" {i}");
}

tree.ShowUpTree(tree.root);