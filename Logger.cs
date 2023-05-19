using System;

class Logger
{
    // This method records a message to the log.
    public void Log(string message)
    {
        // Get the current date and time.
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Print the log message with a timestamp.
        Console.WriteLine($"[{timestamp}] {message}");
    }
}
