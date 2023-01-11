namespace LogSharp
{
	/// <summary>
	/// The kind of logger that is defined.
	/// </summary>
	public enum LoggerKind
	{
		JustStore,  // Just store output to the specified file.
		JustPrint,  // Just print output to the console.
		Both,		// Just do both.
	}
}