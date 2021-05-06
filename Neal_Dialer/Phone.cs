using System;
using System.Linq;

namespace Neal_Dialer
{
    class Phone
    {
        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }
        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
        }
        private string _phoneType;

        public string PhoneType
        {
            get { return _phoneType; }
        }
        public Phone(string companyName, string phoneNumber, string phoneType)
        {
            _phoneNumber = phoneNumber;
            _companyName = companyName;
            _phoneType = phoneType;
        }
        public virtual string Dial()
        {
            return $"{_companyName} is being dialed using " +
                FormatNumber(_phoneNumber) + "...";
        }
        public string FormatNumber(string input)
        {
            long rawPhoneNumber = long.Parse(
                new string(input.Where(char.IsDigit).ToArray()));
            return String.Format("{0:(###) ###-####}", rawPhoneNumber);
        }
    }
}
