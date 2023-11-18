namespace UrWave.Dtos
{
    public class BaseApiResponse<T>
    {
        public ResponseStatus? Status { get; set; } = null;
        public T? Result { get; set; }
        public PaginationInfoDto? PaginationInfo { get; set; } = null;
    }
    public class ResponseStatus
    {
        public string ResponseCode { get; set; }
        public string DetailedResponseCode { get; set; } = "000";//Success
        public ResponseStatus()
        {
        }
        public ResponseStatus(string responseCode)
        {
            ResponseCode = responseCode;
        }
        public ResponseStatus(string responseCode, string detailedResponseCode) : this(responseCode)
        {
            DetailedResponseCode = detailedResponseCode;
        }
    }

    public class PaginationInfoDto
    {
        public int TotalCount { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }

}
