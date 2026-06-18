using System.Configuration;

namespace App.Core
{
    public static class DbConfig
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["BloodBankDB"].ConnectionString
            ?? throw new System.InvalidOperationException("Connection string 'DefaultConnection' not found.");
    }
}




    