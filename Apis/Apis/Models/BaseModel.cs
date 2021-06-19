namespace Apis.Models
{
    public class BaseModel<T> where T : class
    {
        public bool IsError => Error == null;
        public T Error { get; set; }
    }
}