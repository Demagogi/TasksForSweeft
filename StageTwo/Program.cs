/*მოცემულია Countries REST API ის მისამართი: https://restcountries.com/v3.1/all,
რომელიც აბრუნებს ინფორმაციას ქვეყნების შესახებ. დაწერეთ ფუნქცია,
რომელიც ყოველი ქვეყნისთვის შექმნის ტექსტურ დოკუმენტს (.txt) სახელად
{ქვეყნის_სახელი.txt}. თითოეულ დოკუმენტში უნდა იყოს შევსებული ქვეყნის
“region”, “subregion”, “latlng”, “area” და “population” ველები.*/

using Newtonsoft.Json.Linq;

using (HttpClient httpClient = new HttpClient())
{
    try
    {
        string apiUrl = "https://restcountries.com/v3.1/all";

        HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string apiResponse = await response.Content.ReadAsStringAsync();

            JArray countriesArray = JArray.Parse(apiResponse);

            foreach (var country in countriesArray)
            {
                string countryName = country["name"]["official"].ToString();
                string countryData = $"region: {country["region"]},\nsubregion: {country["subregion"]},\nlatlng: {country["latlng"]}," +
                    $"\narea: {country["area"]},\npopulation: {country["population"]}".ToString();

                string filePath = $"\\Desktop\\{countryName}.txt"; // write your own path(პაპკაში ქენით თორე დესკტოპი გამეტენა ;დ)

                File.WriteAllText(filePath, countryData);

                Console.WriteLine($"Data for {countryName} has been written to {filePath}");
            }
        }
        else
        {
            Console.WriteLine("Error: API request failed with status code " + response.StatusCode);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}
