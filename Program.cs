using System.Text;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Exception = System.Exception;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace import_fsa;

class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine("Hi, there!");
        if (args.Length == 0)
        {
            Console.WriteLine($"use 'Import_fsa_scan.exe -export' or 'Import_fsa_scan.exe -import'");
            return 0;
        }
        Console.WriteLine("continue...");

        /*
        if (args[0] == "-export")
        {
            var context = new FsaEfContext();
            context.Database.EnsureCreated();

            //var serializer = new Newtonsoft.Json.JsonSerializer();
            try
            {
                using (StreamWriter sw = new StreamWriter(@"ral_short_info.json"))
                {
                    var jsonStr = JsonConvert.SerializeObject(context.Rals, Newtonsoft.Json.Formatting.Indented,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
                    sw.WriteLine(jsonStr);
                }

                var cnt = context.Rals.Count();
                Console.WriteLine($"{cnt} items exported");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }
        */

        if (args[0] == "-import")
        {
            Console.WriteLine("fucking!");
            try
            {
                var x = 42;
                // var jsonStr = File.ReadAllText("ral_short_info.json");
                // List<RalShort> rals = JsonConvert.DeserializeObject<List<RalShort>>(jsonStr);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            
        }
        
        return 0;
    }
}

public class FsaEfContext : DbContext
{
    public DbSet<RalShort> Rals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!File.Exists("DbConnect.auth"))
        {
            Console.WriteLine("File DbConnect.auth not found, exited");
            Environment.Exit(1);
        }
        var cnStr = File.ReadAllText("DbConnect.auth");
        options.UseSqlServer(cnStr);
    }
}
