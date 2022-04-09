namespace VMK_BindingData_DGV2022_04_05;

public class BindingException : Exception
{
    public BindingException(string field, string? message) : base(message)
    {
        ErrorField = field;
    }

    public string ErrorField { get; set; }
}