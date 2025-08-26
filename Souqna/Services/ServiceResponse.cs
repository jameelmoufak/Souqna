namespace Souqna.Services
{
    public class ServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

        public static ServiceResponse<T> Success(T data, string message = "تمت العملية بنجاح")
        {
            return new ServiceResponse<T> { IsSuccess = true, Data = data, Message = message };
        }

        public static ServiceResponse<T> Fail(string message)
        {
            return new ServiceResponse<T> { IsSuccess = false, Message = message };
        }
    }
}
