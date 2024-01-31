namespace Dating_APP.Extension
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateOnly value)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);
            var age = today.Year-value.Year;
            if (value > today.AddYears(-age)) age--;
            return age;
        }
    }
}
