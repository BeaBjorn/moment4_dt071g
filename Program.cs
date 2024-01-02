//This file was auto-generated by ML.NET Model Builder. 

/*
    File has been modified by Beatrice Björn
    Moment 4 - DT071G webbutveckling med C# och .NET
    Datum: 2023-01-01
*/

using System;

// A namespace for SentimentModel.ConsoleApp holding the class Program and a Main function
namespace SentimentModel.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop used to keep application running until the user types the word "stop"
            // Console.WriteLine is used to print instructions to user
            // A string variable named "userReview" stores the user input
            // If user input = "stop" the loop breaks
            while (true)
            {
                Console.WriteLine("Write a review or type 'stop' to quit:");
                Console.WriteLine($"------------------------------------------------------ \n");
                string userReview = Console.ReadLine();

                if (userReview.ToLower() == "stop")
                {
                    break;
                }

                // Creates an instance of the ModelInput class within the SentimentModel namespace and stores the user input in a variable named "Col0" 
                SentimentModel.ModelInput userInput = new SentimentModel.ModelInput()
                {
                    Col0 = userReview,
                };

                // Uses the Predict method to get a prediction of wether the review was positive or negative
                var prediction = SentimentModel.Predict(userInput);

                // Console.WriteLine is used to display the review, wether it was positive or negative along woth the score of the review
                Console.WriteLine($"======================================================\n");
                Console.WriteLine($"This review is {(prediction.PredictedLabel == 1 ? "positive" : "negative")} with a score of: {prediction.Score[1]:P2}\n");
                Console.WriteLine($"======================================================\n\n");
            }
        }
    }
}
