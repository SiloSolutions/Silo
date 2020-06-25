using System;
using Amazon.Lambda.Core;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using SiloApplication.Models;
using SiloApplication.Data;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SiloApplication.AWSLambda
{

    public class Function
    {
        private List<Lambda> lambdas = new List<Lambda>();
        private static Random randomAnal = new Random();      
        private int anal = randomAnal.Next(0, 1023);
        private int option = 0;

        public Lambda GetData()
        {
            Lambda lambda = new Lambda();
            Random random = new Random();
            
            option = random.Next(1, 4);

            if(lambdas.Count == 0)
                option = random.Next(1, 3);
            else
                lambda = lambdas.Last();

            lambda.Temperature = random.Next(22, 30);
            lambda.CreationDate = DateTime.Now.AddHours(2);

            if (lambda.LiquidLevel >= 150000)
                option = 1;
            if(lambda.LiquidLevel <= 10000)
                option = 2;
        
            switch (option)
            {
                case 1:
                    
                    lambda = Down(lambda, anal);
                    lambdas.Add(lambda);                   
                    break;

                case 2:

                    lambda = Up(lambda, anal);
                    lambdas.Add(lambda);
                    break;

                case 3:

                    //sostituisce il metodo stay
                    lambdas.Add(lambda);
                    break;

                default:
                    break;
            }

            return lambdas.Last();
        }  

        public Lambda Down(Lambda lambda, int anal)
        {
            Random random = new Random();
            int numRand = random.Next(0, 50);

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
            Random random = new Random();
            int numRand = random.Next(0, 50);

            var temp = anal + numRand;

            lambda.LiquidLevel = Convert.ToDecimal(temp * 156.51);
            lambda.Pressure = Convert.ToDecimal(temp * 0.0008);


            Console.WriteLine("ci sono {0} litri di acqua", lambda.LiquidLevel);
            Console.WriteLine("c'è una pressione di {0} bar", lambda.Pressure);
            Console.WriteLine("");

            return lambda;
        }

        //Function Handler is an entry point to start execution of Lambda Function.  
        //It takes Input Data as First Parameter and ObjectContext as Second


        public void FunctionHandler(ILambdaContext context)
        {

            var logger = context.Logger;

            IDataAccess data = new SQLDataAccess();

            Lambda lambda = GetData();

            try
            {
                data.Insert(lambda);

                LambdaLogger.Log("Insert record in the table" + Environment.NewLine);
                logger.Log("Records Inserted Successfully" + Environment.NewLine);
            }
            catch (SqlException e)
            {
                LambdaLogger.Log("Error Generated. Details: " + e.ToString());
                logger.Log("Error Generated. Details: " + e.ToString());
            }
            logger.Log(string.Format("Finished execution for function -- {0} at {1}",
                                context.FunctionName, DateTime.Now.AddHours(2)));       
        }
    }      
}