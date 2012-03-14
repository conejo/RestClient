using System.Net.Http;

namespace Rest
{
	public class Rest
	{
		private HttpClient client;
		readonly HttpMethod patchMethod;

		public Rest()
		{
			client = new HttpClient();
			patchMethod = new HttpMethod("PATCH");
		}

		public string SendHttpGet(string url)
		{
			HttpResponseMessage hrm = client.GetAsync(url).Result;

			string response = hrm.Content.ReadAsStringAsync().Result;

			 return response;
		}
	}
}