using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(resposta);
}