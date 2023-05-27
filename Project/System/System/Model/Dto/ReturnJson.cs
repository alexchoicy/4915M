namespace Server.Model.Dto
{
    public class ReturnJson
    {
        public int HttpStatus { get; set; }
        public string Error { get; set; }
        public dynamic Data { get; set; }

    }
}
