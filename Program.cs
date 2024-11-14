using System.Data;
using System.Text.Json;
using System.Xml.Serialization;
namespace Json2Xml;

// Напишите приложение, конвертирующее произвольный JSON в XML

// Для решения используем готовый код (часть 2) с Семинара 9. Остаётся только добавить XML serializer с первой части Семинара 9

public class Program
{
	static void Main(string[] args)
	{
		string fileJson = "{\"Current\":{\"Time\":\"2024-06-18T20:35:06.722127+04:00\",\"Temperature\":29,\"WeatherCode\":1,\"WindSpeed\":2.1,\"WindDirection\":1}," +
			"\"Past\":{\"Time\":\"2023-06-15T20:35:06.777082+04:00\",\"Temperature\":21,\"WeatherCode\":4,\"WindSpeed\":2.2,\"WindDirection\":1}}";

		List<string> res = new List<string>();
		res = FindValueInJson(fileJson);
		WeatherInfo wInfo = JsonSerializer.Deserialize<WeatherInfo>(fileJson);
		var serialXml = new XmlSerializer(typeof(WeatherInfo));
		
		// >>>>>>> INSERTION <<<<<<<

		serialXml.Serialize(Console.Out, wInfo);
		Console.ReadLine();

		// >>>>>>> END OF INSERTION <<<<<<<
	}

	public static List<string> FindValueInJson(string file)
	{
		List<string> result = new List<string>();

		return result;
	}

	public class Weather
	{
		public DateTime Time { get; set; }
		public double Temperature { get; set; }
		public int WeatherCode { get; set; }
		public double WindSpeed { get; set; }
		public int WindDirection { get; set; }
	}
	public class WeatherInfo
	{
		public Weather Current { get; set; }
		public List<Weather> History { get; set; }
	}
}
