using System;

namespace Rockpaperscissors
{


	class Program
	{
		static void Main(string[] args)
		{

			int victory = 0;
			int defeat = 0;
			int tie = 0;

			
			

			//get input form the user
			Console.WriteLine("Hello. Welcome to Rock-Paper-Scissors Game!");
			//Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
			//string userInput = Console.ReadLine();
			//Console.WriteLine(userInput);

			////validate the use input as a 1, 2, or 3
			////instantiate a int type variable.
			//int convertedNumber = -1;
			//bool conversionBool = false;

			//while (conversionBool == false)
			//{
			//	conversionBool = Int32.TryParse(userInput, out convertedNumber);
			//	if (conversionBool)
			//	{
			//		if (convertedNumber > 0 && convertedNumber < 4)
			//		{
			//			break;
			//		}
			//		else
			//		{
			//			Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!\nPlease enter a 1 for ROCK, 2 for PAPER, or 3 for SCISSORS");
			//			userInput = Console.ReadLine();
			//		}
			//	}
			//}

			for (int numberofgames = 0; numberofgames < 3; numberofgames++)
			{

				

					int convertedNumber = -1;
					bool conversionBool = false;
					do
					{
						Console.WriteLine("Please enter enter 1 for ROCK, 2 for PAPER, 3 for SCISSORS");
						string userInput = Console.ReadLine();
						//Console.WriteLine(userInput);

						//validate the use input as a 1, 2, or 3
						//this version of TryParse() takes a string and the second argument is an out variable that is instantiated in that moment.
						conversionBool = Int32.TryParse(userInput, out convertedNumber);
						if (!conversionBool || convertedNumber < 1 || convertedNumber > 3)
						{
							Console.WriteLine("Hey, buddy... that wasn't a 1 or 2 or 3!");
						}

					} while (!(convertedNumber > 0 && convertedNumber < 4));
					//Console.WriteLine($"The int converted value inputted is {convertedNumber}");

					Random randNum = new Random();
					int rand = randNum.Next(1, 4);
					//Console.WriteLine(randNum.Next(1, 4));// inclusive of the first (lower) value and exclusive of hte second(upper) value. 
					Console.WriteLine(rand);

					if (convertedNumber == 1 && rand == 2) // if player has rock and ai has scissors player wins

					{

						Console.WriteLine("Player Wins");
						victory++;
					}
					else if (convertedNumber == 2 && rand == 1) // if player has scissors and AI has rock

					{
						Console.WriteLine("AI wins");

						defeat++;

					}

					else if (convertedNumber == 3 && rand == 1) // if player has paper and AI has rock
					{
						Console.WriteLine("Player Wins");

						victory++;
					}

					else if (convertedNumber == 1 && rand == 3)// if player has rock and ai has paper
					{
						Console.WriteLine("AI Wins");
						defeat++;

					}

					else if (convertedNumber == 2 && rand == 3) // if player has scissors and ai has paper
					{

						Console.WriteLine("player wins");
						victory++;

					}

					else if (rand == 2 && convertedNumber == 3) //if AI has scissors and player has paper
					{
						Console.WriteLine("AI Wins");
						defeat++;

					}
					else
					{
						tie++;
						Console.WriteLine("tie!");
					}

				if (victory == 2 || defeat == 2)

				{
					break;
				
				}
				
			
				}
		
			Console.WriteLine("player total wins");
			Console.WriteLine(victory);
			Console.WriteLine("AI total wins");
			Console.WriteLine(defeat);
			Console.WriteLine(" total Ties");
			Console.WriteLine(tie);
			/**homework - 
			 * 1. get a random number for the computer
			 * 2. compare who won the round
			 * 3. refactor the code to have a best of three game
			 * 4. print out the winner, and how many games were won by each (and ties)
			 * 5. and exit the program.
			 * 
			 * 
			 * 
			 * 
			**/




		}


			
		}
	}

	

