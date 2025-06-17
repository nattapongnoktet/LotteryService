

using System.Text;
using LotteryService.Dto;
using LotteryService.Services.Interface;
using Newtonsoft.Json; // ✅ Make sure this is included



namespace LotteryService.Services;
public class LotteryServices : ILotteryService
{
    public LotteryServices()
    {

    }

    public async Task<mResult> GetResultLottery()
    {
        try
        {
            string url = "https://www.glo.or.th/api/checking/getLotteryResult";

            using (HttpClient client = new HttpClient())
            {

                // Create request object
                var requestData = new { date = "16", month = "06", year = "2025" };

                // Serialize object to JSON
                string jsonPayload = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // Send POST request
                HttpResponseMessage response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();

                var lotteryResult = JsonConvert.DeserializeObject<mResultLottery>(result);

                return new mResult { Success = true, Result = lotteryResult };

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Request Failed: " + ex.Message);
            return new mResult { Success = true, ErrorMessage = ex.Message };
        }
    }
}