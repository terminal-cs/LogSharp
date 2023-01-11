namespace LogSharp
{
	/// <summary>
	/// The kind of logger that is defined.
	/// Note: Logging to a file could cause major slowdowns if the host system's disks aren't fast.
	/// </summary>
	public enum LoggerKind
	{
		/// <summary>
		/// Just store output to the specified file.
		/// </summary>
		JustStore,
		/// <summary>
		/// Just print output to the console.
		/// </summary>
		JustPrint,
		/// <summary>
		/// Just do both.
		/// </summary>
		Both,
	}
}