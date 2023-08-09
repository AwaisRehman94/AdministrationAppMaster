namespace GlobalCommon.Models
{
    public class Result<T> where T : class
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public T Data { get; set; }
    }
}