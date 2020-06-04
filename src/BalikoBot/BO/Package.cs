using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

namespace BalikoBot.BO
{
	/// <summary>
	/// balik
	/// </summary>
	public class BalikoBotPackage : BalikoBotResult
	{
		public string EshopId { get; set; }
		public string CarrierId { get; set; }
		public int PackageId { get; set; }
		public string LabelUrl { get; set; }
		public string TrackUrl { get; set; }

		// full response to retrieve information not extracted to the properties
		public JObject FullResponse { get; set; }

		/// <summary>
		/// Package's number (back-reference from <see cref="BalikoBotClient.Add(BalikoBotData[])"/> call)
		/// </summary>
		public int Number { get; set; }
	}
}
