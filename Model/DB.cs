using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    static internal class DB
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public static void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public static void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public static MySqlConnection getConnection()
        {
            return connection;
        }

        #region Car
        static public List<Int16> GetAllCarIds()
        {
            List<Int16> carIds = new List<Int16>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();

                    string query = "SELECT id FROM Cars";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Int16 carId = reader.GetInt16(0);
                                carIds.Add(carId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return carIds;
        }
        static public List<Int16> GetStandartConfigurationIdsByCarId(Int16 carId)
        {
            List<Int16> configurationIds = new List<Int16>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();

                    string query = "SELECT configuration_id FROM Standart_configuration WHERE car_id = @carId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@carId", carId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Int16 configurationId = reader.GetInt16(0);
                                configurationIds.Add(configurationId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return configurationIds;
        }
        static public (Int16 ConfigurationId, Int16 CarId, Int16 ColorId, Int16 WheelsId, Int16 SpoilerId) GetConfigurationById(Int16 configurationId)
        {
            try
            {
                (Int16 ConfigurationId, Int16 CarId, Int16 ColorId, Int16 WheelsId, Int16 SpoilerId) cfg = (-1, -1, -1, -1, -1);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();
                    string query = "SELECT * FROM Configuration WHERE id = @configurationId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@configurationId", configurationId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cfg.ConfigurationId = reader.GetInt16(0);
                                cfg.CarId = reader.GetInt16(1);
                                cfg.ColorId = reader.GetInt16(2);
                                cfg.WheelsId = reader.GetInt16(3);
                                cfg.SpoilerId = reader.GetInt16(4);
                            }
                        }
                    }
                }
                return cfg;
            }
            catch { throw new ArgumentException(); }
        }
        static public (string Name, float Price) GetCarInfoById(int carId)
        {
            (string Name, float Price) car = (null, -1);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();

                    string query = "SELECT * FROM Cars WHERE id = @carId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@carId", carId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                car.Name = reader.GetString(1);
                                car.Price = reader.GetFloat(2);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return car;
        }
        static public (string Front, string Side, string Back) GetCarImagesByConfigurationId(int configurationId)
        {
            (string Front, string Side, string Back) carImage = (null,null,null);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();
                    string query = "SELECT * FROM Car_image WHERE configuration_id = @configurationId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@configurationId", configurationId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                carImage.Front = reader.GetString(1);
                                carImage.Side = reader.GetString(2);
                                carImage.Back = reader.GetString(3);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return carImage;
        }
        static public (string Front, string Side, string Back) GetCarImagesByCarAttributes(int carId, int colorId, int wheelsId, int spoilerId)
        {
            (string Front, string Side, string Back) carImages = (null,null,null);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();
                    string query = @"SELECT configuration_id
                                 FROM Configuration
                                 WHERE car_id = @carId AND Color_id = @colorId
                                       AND Wheels_id = @wheelsId AND Spoiler_id = @spoilerId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@carId", carId);
                        command.Parameters.AddWithValue("@colorId", colorId);
                        command.Parameters.AddWithValue("@wheelsId", wheelsId);
                        command.Parameters.AddWithValue("@spoilerId", spoilerId);

                        Int16 configurationId = Convert.ToInt16(command.ExecuteScalar());

                        if (configurationId > 0)
                        {
                            query = @"SELECT Front, Side, Back
                                  FROM Car_image
                                  WHERE configuration_id = @configurationId";

                            using (MySqlCommand imageCommand = new MySqlCommand(query, connection))
                            {
                                imageCommand.Parameters.AddWithValue("@configurationId", configurationId);

                                using (MySqlDataReader reader = imageCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        carImages.Front = reader.GetString(0);
                                        carImages.Side = reader.GetString(1);
                                        carImages.Back = reader.GetString(2);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return carImages;
        }

        #endregion
        #region Color
        static public (string Name, string RGB, float Price) GetColorsById(int colorId)
        {
            (string Name, string RGB, float Price) colors = (null,null,-1);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();

                    string query = "SELECT * FROM Colors WHERE id = @colorId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@colorId", colorId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                colors.Name = reader.GetString(1);
                                colors.RGB = reader.GetString(2);
                                colors.Price = reader.GetFloat(3);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return colors;
        }
        #endregion
        #region Wheels
        static public (string Name, float Price, string Image) GetWheelsWithImageById(int wheelsId)
        {
            (string Name, float Price, string Image) wheelsWithImage = (null, -1, null);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();

                    string query = @"SELECT w.id, w.Name, w.Price, wi.image
                                 FROM Wheels w
                                 JOIN Wheels_image wi ON w.id = wi.wheels_id
                                 WHERE w.id = @wheelsId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@wheelsId", wheelsId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                wheelsWithImage.Name = reader.GetString(1);
                                wheelsWithImage.Price = reader.GetFloat(2);
                                wheelsWithImage.Image = reader.GetString(3);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return wheelsWithImage;
        }
        #endregion
        #region Spoiler
        static public (string Name, float Price, string Image) GetSpoilerWithImageById(int spoilerId)
        {
            (string Name, float Price, string Image) spoilerWithImage = (null, -1, null);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    openConnection();

                    string query = @"SELECT s.id, s.Name, s.Price, si.image
                                 FROM Spoiler s
                                 JOIN Spoiler_image si ON s.id = si.spoiler_id
                                 WHERE s.id = @spoilerId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@spoilerId", spoilerId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                spoilerWithImage.Name = reader.GetString(1);
                                spoilerWithImage.Price = reader.GetFloat(2);
                                spoilerWithImage.Image = reader.GetString(3);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return spoilerWithImage;
        }
        #endregion
    }
}
