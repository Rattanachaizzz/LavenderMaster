using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Npgsql;


namespace LavenderMaster.Models
{
    public class MyBackgroundService : BackgroundService
    {
        private Timer _timer;
        public string Password_LAVENDERDB = "8545";
        public string Username_LAVENDERDB = "postgres";

        /*protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try 
                {
                    DateTime now = DateTime.Now;
                    DateTime nextRun = now.Date.AddHours(12);

                    if (now >= nextRun)
                    {
                        nextRun = nextRun.AddDays(1);
                    }

                    TimeSpan delay = nextRun - now;
                    await Task.Delay(delay, stoppingToken);
                    DoWork(stoppingToken);
                    Console.WriteLine("Hello! It's 12:00:00 PM!");
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.ToString());
                }
            }
        }*/

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("Hello! This runs every 5 seconds!");
                try
                {
                    await Task.Delay(5000, stoppingToken);
                    DoWork(stoppingToken);
                }
                catch (TaskCanceledException)
                {
                    return;
                }
            }
        }

        private void DoWork(object state)
        {
            using (PostgresContext _db = new PostgresContext()) 
            {
                var stations = _db.Stations.OrderBy(s => s.Id).ToList();
                if (stations.Count != 0)
                {
                    foreach (var station in stations)
                    {
                        try
                        {
                            string master = GetMaster(station.IpSim);
                            Stations s = _db.Stations.FirstOrDefault(s => s.Id == station.Id);
                            s.Content = master;
                            s.CreateDate = DateTime.Now;
                            _db.SaveChanges();
                            Console.WriteLine(master);
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                }
                else
                { 
                    Console.WriteLine("Station count equel zero, Press recheck infomation in database.");
                }
            }
        }

        public string GetMaster(string IpSim)
        {
            try
            {
                NpgsqlCommand cmd;
                NpgsqlDataReader reader;
                var hoses = new List<Dictionary<string, object>>();
                var pumps = new List<Dictionary<string, object>>();

                using (NpgsqlConnection connection = new NpgsqlConnection($"Host={IpSim};Port=5432;Database=LAVENDERDB;Username={Username_LAVENDERDB};Password={Password_LAVENDERDB};"))
                {
                    connection.Open();

                    //Hoses
                    using (cmd = new NpgsqlCommand("SELECT * FROM lavender.hoses", connection))
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader[i];
                            }
                            hoses.Add(row);
                        }
                    }

                    //Pumps
                    using (cmd = new NpgsqlCommand("SELECT * FROM lavender.pumps", connection))
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader[i];
                            }
                            pumps.Add(row);
                        }
                    }
                }

                var master = new
                {
                    hoses,
                    pumps,
                    /*advances_setting,
                    grades,
                    hoses,
                    lavender_socket,
                    loops,
                    loops_type,
                    price_profiles,
                    protocols,
                    pumps,
                    pumps_display,
                    pumps_real_time,
                    site_config,
                    tank_gauge_features,
                    tanks,*/
                };
                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(master, Newtonsoft.Json.Formatting.None);
                return jsonString;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}