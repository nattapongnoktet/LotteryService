using System.Text.Json.Serialization;

namespace LotteryService.Dto;

   public class mResultLottery
    {
        public string? statusMessage { get; set; }
        public int statusCode { get; set; }
        public string? message { get; set; }
        public bool status { get; set; }
        public Response? response { get; set; }
    }

       public class Response
    {
        public ResponseStatus? responseStatus { get; set; }
        public Result? result { get; set; }
    }
       public class Result
    {
        public string? youtube_url { get; set; }
        public string? pdf_url { get; set; }
        public string? date { get; set; }
        public List<int>? period { get; set; }
        public string? remark { get; set; }
        public int status { get; set; }
        public string? sheetId { get; set; }
        public Data? data { get; set; }
        public N3? n3 { get; set; }
    }

        public class ResponseStatus
    {
        public string? operation { get; set; }
        public string? status { get; set; }
        public string? code { get; set; }
        public string? messageType { get; set; }
        public string? message { get; set; }
    }

     public class Number
    {
        public int? round { get; set; }
        public string? value { get; set; }
    }

        public class NumberData
    {
        public decimal? price { get; set; }
        public List<Number>? number { get; set; }
    }

      public class Data
    {
        public NumberData? first { get; set; }
        public NumberData? second { get; set; }
        public NumberData? third { get; set; }
        public NumberData? fourth { get; set; }
        public NumberData? fifth { get; set; }
        public NumberData? last2 { get; set; }
        public NumberData? last3f { get; set; }
        public NumberData? last3b { get; set; }
        public NumberData? near1 { get; set; }
    }

     public class N3
    {
        public Straight3? straight3 { get; set; }
        public Shuffle3? shuffle3 { get; set; }
        public Straight2? straight2 { get; set; }
        public Special? special { get; set; }
    }

     public class Shuffle3
    {
        public decimal? price { get; set; }
        public List<Number>? number { get; set; }
    }

    public class Special
    {
       public decimal? price { get; set; }
        public List<Number>? number { get; set; }
    }

    public class Straight2
    {
        public decimal? price { get; set; }
        public List<Number>? number { get; set; }
    }

    public class Straight3
    {
       public decimal? price { get; set; }
        public List<Number>? number { get; set; }
    }
