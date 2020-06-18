using System;
using Amazon.Lambda.Core;
using SiloApplication.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda.Test
{


    public class Function
    {

        public Lambda GetValue()
        {
            Lambda lambda = new Lambda();
            Random random = new Random();

            int a = random.Next(1, 4);
            int anal = random.Next(0, 100);

            lambda.Temperature = random.Next(20, 35);
            lambda.CreationDate = DateTime.Now.AddHours(2);

            int num = random.Next(1, 4);

            switch (num)
            {
                case 1:

                    lambda = Down(lambda, anal);
                    break;

                case 2:

                    lambda = Up(lambda, anal);
                    break;

                case 3:
                    lambda = Stay(lambda, anal);
                    break;

                default:

                    lambda = Stay(lambda, anal);
                    break;
            }

            return lambda;
        }

        //Function Handler is an entry point to start execution of Lambda Function.  
        //It takes Input Data as First Parameter and ObjectContext as Second  


            public Lambda Down(Lambda lambda, int anal)
            {
                Random random1 = new Random();
                int numRand = random1.Next(0, 50);

                var temp = anal - numRand;

                lambda.LiquidLevel = Convert.ToDecimal(temp * 156.51);
                lambda.Pressure = Convert.ToDecimal(temp * 0.0008);


                Console.WriteLine("ci sono {0} litri di acqua", lambda.LiquidLevel);
                Console.WriteLine("c'è una pressione di {0} bar", lambda.Pressure);
                Console.WriteLine("");

                return lambda;
            }

            public Lambda Up(Lambda lambda, int anal)
            {
                Random random1 = new Random();
                int numRand = random1.Next(0, 50);

                var temp = anal + numRand;

                lambda.LiquidLevel = Convert.ToDecimal(temp * 156.51);
                lambda.Pressure = Convert.ToDecimal(temp * 0.0008);


                Console.WriteLine("ci sono {0} litri di acqua", lambda.LiquidLevel);
                Console.WriteLine("c'è una pressione di {0} bar", lambda.Pressure);
                Console.WriteLine("");

                return lambda;

            }

            public Lambda Stay(Lambda lambda, int anal)
            {

                lambda.LiquidLevel = Convert.ToDecimal(anal * 156.51);
                lambda.Pressure = Convert.ToDecimal(anal * 0.0008);

                Console.WriteLine("ci sono {0} litri di acqua", lambda.LiquidLevel);
                Console.WriteLine("c'è una pressione di {0} bar", lambda.Pressure);
                Console.WriteLine("");

                return lambda;
            }


        public void FunctionHandler(ILambdaContext context)
        {

            var logger = context.Logger;

            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

            Lambda lambda = GetValue();
            

            var query = "INSERT INTO Lambda (LiquidLevel,Pressure,Temperature,CreationDate) VALUES (@LiquidLevel,@Pressure,@Temperature,@CreationDate)";

            SqlConnection con = new SqlConnection(connectionString);
            //Replaced Parameters with Value
            SqlCommand cmd = new SqlCommand(query, con);

            //Pass values to Parameters
            cmd.Parameters.AddWithValue("@LiquidLevel", lambda.LiquidLevel);
            cmd.Parameters.AddWithValue("@Pressure", lambda.Pressure);
            cmd.Parameters.AddWithValue("@Temperature", lambda.Temperature);
            cmd.Parameters.AddWithValue("@CreationDate", lambda.CreationDate);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                LambdaLogger.Log("Insert record in the table");
                //Console.WriteLine("Records Inserted Successfully");
                logger.Log("Records Inserted Successfully");
            }
            catch (SqlException e)
            {
                LambdaLogger.Log("Error Generated. Details: " + e.ToString());
                //Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                //Console.ReadKey();
            }
            logger.Log(string.Format("Finished execution for function -- {0} at {1}",
                                context.FunctionName, DateTime.Now));
        }
    }      
}