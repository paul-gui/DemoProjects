using System;
using System.Configuration;
using System.IO;

namespace MyDLL
{
	public static class Logger
	{
		static readonly string logFileError = ConfigurationManager.AppSettings["LoggerError"];
		static readonly string logFileInfo = ConfigurationManager.AppSettings["LoggerInfo"];

		public static void LogError(string error)
		{
			var fi = new FileInfo(logFileError);
			if (!fi.Directory.Exists)
			{
				Directory.CreateDirectory(fi.DirectoryName);
			}

			using (var file = new StreamWriter(logFileError, append: true))
			{
				file.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss.ffffff}\n{error}");
				file.WriteLine();
			}
		}

		public static void LogError(Exception ex)
		{
			var fi = new FileInfo(logFileError);
			if (!fi.Directory.Exists)
			{
				Directory.CreateDirectory(fi.DirectoryName);
			}

			using (var file = new StreamWriter(logFileError, append: true))
			{
				file.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss.ffffff}\n{ex}");
				file.WriteLine();
			}
		}

		public static void LogInfo(string info)
		{
			//var fi = new FileInfo(logFileError);
			//if (!fi.Directory.Exists)
			//{
			//	Directory.CreateDirectory(fi.DirectoryName);
			//}

			//using (var file = new StreamWriter(logFileError, append: true))
			//{
			//	file.WriteLine(info);
			//}
		}
	}
}
