﻿namespace LogSharp
{
	/// <summary>
	/// Logger class, used for logging errors.
	/// </summary>
	public class Logger
	{
		/// <summary>
		/// Creates a new instance of the <see cref="Logger"/> class.
		/// </summary>
		/// <param name="Category">Category to print as (e.g. Kernel, Graphics... etc)</param>
		public Logger(string Category)
		{
			this.Category = Category;
		}

		#region Methods

		/// <summary>
		/// Log an error to the console.
		/// </summary>
		/// <param name="Message">Message to display.</param>
		/// <param name="S">Sevetiry of the message.</param>
		public void Log(string Message, Severity S = Severity.Info)
		{
			switch (S)
			{
				case Severity.Warning:
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				case Severity.Critical:
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case Severity.Ok:
					Console.ForegroundColor = ConsoleColor.Green;
					break;
			}
			Console.Write($"[ {S} ] ");
			Console.ResetColor();
			Console.WriteLine($"{Category} > {Message}");
		}

		/// <summary>
		/// Logs a success message to the console.
		/// </summary>
		/// <param name="Message">Message details.</param>
		public void Success(string Message)
		{
			Log(Message, Severity.Ok);
		}

		/// <summary>
		/// Logs an info message to the console.
		/// </summary>
		/// <param name="Message">Message details.</param>
		public void Info(string Message)
		{
			Log(Message, Severity.Info);
		}

		/// <summary>
		/// Logs a warning to the console.
		/// </summary>
		/// <param name="Message">Message details.</param>
		public void Warn(string Message)
		{
			Log(Message, Severity.Warning);
		}

		/// <summary>
		/// Logs an error to the console.
		/// </summary>
		/// <param name="Message">Message details.</param>
		public void Error(string Message)
		{
			Log(Message, Severity.Critical);
		}

		#endregion

		#region Fields

		/// <summary>
		/// Category marker for the debugger instance.
		/// </summary>
		public string Category;

		#endregion
	}
}