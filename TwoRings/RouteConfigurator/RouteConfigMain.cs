using MySQLHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RouteConfigurator
{

    class RouteConfigMain
    {
        public List<Plane> Planes = new List<Plane>();
        public List<Route> Routes = new List<Route>();
        public List<Hub> Hubs = new List<Hub>();

        public static string DBName = "tracmy5_AirlineManager";
        public static string DBUser = "tracmy5_AdMin5";
        public static string DBPass = "joeman220";

        public RouteConfigMain()
        {

        }


        public void PopulatePlanesList()
        {
            string sqlQuery = "SELECT * FROM Planes";
            MySqlConnection conn = MySQLHelper.Connections.Connect(DBName, DBUser, DBPass);
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Plane newPlane = new Plane(reader.GetString("Plane"));
                newPlane.Manufacturer = reader.GetString("Manufacturer");
                newPlane.Range = reader.GetInt32("Range");
                newPlane.CategoryNeeded = reader.GetInt32("CatgeoryNeeded");
                newPlane.Price = reader.GetDouble("Price");
                newPlane.ConsumptionRate = reader.GetDouble("ConsumptionRate");
                newPlane.Speed = reader.GetInt32("Speed");
                newPlane.WearCoeficientPercent = reader.GetDouble("WearCoefficent");
                newPlane.MaxEconomy = reader.GetInt32("MaxEconomy");
                newPlane.MaxBusiness = reader.GetInt32("MaxBusiness");
                newPlane.MaxFirst = reader.GetInt32("MaxFirst");
                newPlane.MaxCargo = reader.GetInt32("MaxCargo");
                newPlane.CargoWithMaxEcon = reader.GetInt32("CargoWithMaxEcon");
                newPlane.CargoWithMaxBusiness = reader.GetInt32("CargoWithMaxBusiness");
                newPlane.CargoWithMaxFirst = reader.GetInt32("CargoWithMaxFirst");

                Planes.Add(newPlane);
            }

            conn.Close();
        }

        public void PopulateHubList()
        {
            string sqlQuery = "SELECT * FROM Hubs";
            MySqlConnection conn = MySQLHelper.Connections.Connect("tracmy5_AirlineManager", "tracmy5_AdMin5", "joeman220");
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Hub newHub = new Hub(reader.GetString("CallSign"), reader.GetInt32("MaxCategory"), reader.GetDouble("FlightTax"));
                Hubs.Add(newHub);
            }

            conn.Close();
        }

        public void PopulateRouteList()
        {
            string sqlQuery = "SELECT * FROM Routes";
            MySqlConnection conn = MySQLHelper.Connections.Connect("tracmy5_AirlineManager", "tracmy5_AdMin5", "joeman220");
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Route newPlane = new Route(reader.GetInt32("RouteID"));
            }
            conn.Close();
        }
    }
}
