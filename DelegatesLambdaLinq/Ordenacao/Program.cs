class Program
{
    static void Main()
    {
        List<Folder> folders = new()
        {
            new Folder { Name = "A", Order = 1 },
            new Folder { Name = "B", Order = 2 },
            new Folder { Name = "C", Order = 3 },
            new Folder { Name = "D", Order = 4 }
        };

        ExibirFolders(folders);

        folders[2].UpdateOrder(1, folders); // Atualize o campo Order do C

        ExibirFolders(folders);
    }

    static void ExibirFolders(List<Folder> folders)
    {
        Console.WriteLine();
        foreach (var folder in folders)
        {
            Console.WriteLine($"{folder.Name} - {folder.Order} ");
        }
    }
}

class Folder
{
    public string Name { get; set; }
    public int Order { get; set; }

    public void UpdateOrder(int newOrder, List<Folder> lista)
    {
        if (newOrder != Order)
        {
            int oldOrder = Order;
            Order = newOrder;

            // Atualize os valores de Order dos outros objetos na lista
            foreach (var folder in lista)
            {
                if (folder != this && folder.Order >= newOrder && folder.Order < oldOrder)
                {
                    folder.Order++;
                }
                else if (folder != this && folder.Order <= newOrder && folder.Order > oldOrder)
                {
                    folder.Order--;
                }
            }
        }
    }
}
