
namespace CourseWebApi.Common.Entities
{
    public class MessageResponse<T>
    {
        public T Response { get; set; }

        public string ErrorMessage { get; set; }

        public bool IsError { get; set; }

        public int ErrorCode { get; set; }

        public MessageResponse(T response)
        {
            Response = response;
            ErrorMessage = string.Empty;
        }

        public MessageResponse(string message)
        {
            IsError = true;
            ErrorMessage = message;
        }
    }
}
