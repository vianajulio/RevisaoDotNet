namespace PraticaCodigo.Infraestructure;

public class DatabaseConfig
{
    public string DbPath { get; }

    public DatabaseConfig()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "orders.db");
    }
}
