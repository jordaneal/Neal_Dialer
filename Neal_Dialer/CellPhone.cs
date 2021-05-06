
namespace Neal_Dialer
{
    class CellPhone : Phone
    {
        public CellPhone(string companyName, string phoneNumber, string phoneType) : base(companyName, phoneNumber, phoneType)
        {

        }
        public override string Dial()
        {
            return $"{CompanyName} is being dialed using " +
                $"1+{FormatNumber(PhoneNumber)}...";
        }
    }
}