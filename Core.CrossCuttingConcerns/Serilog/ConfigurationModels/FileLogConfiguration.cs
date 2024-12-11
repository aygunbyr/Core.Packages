namespace Core.CrossCuttingConcerns.Serilog.ConfigurationModels;

public class FileLogConfiguration
{
    public string FolderPath { get; set; }

    public FileLogConfiguration()
    {
        FolderPath = string.Empty;
    }

    public FileLogConfiguration(string folderPath)
    {
        FolderPath = folderPath;
    }
}

public class MsSqlConfiguration
{
    public string ConnectionString { get; set; }
    public string TableName { get; set; }
    public bool AutoCreateSqlTable { get; set; }

    public MsSqlConfiguration()
    {
        ConnectionString = string.Empty;
        TableName = string.Empty;
    }

    public MsSqlConfiguration(string connectionString, string tableName, bool autoCreateTable)
    {
        ConnectionString = connectionString;
        TableName = tableName;
        AutoCreateSqlTable = autoCreateTable;

    }
}