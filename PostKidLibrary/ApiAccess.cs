﻿
namespace PostKidLibrary;

public class ApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> callApiAsync(string url)
    {
        var response = await client.GetAsync(url); 
        
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();

            return json;
        } else
        {
            return $"Error: {response.StatusCode}";
        }

    }
}
