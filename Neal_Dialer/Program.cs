using System;

// Jordan Neal
// IT112
// NOTES:
// BEHAVIORS NOT IMPLIMENTED AND WHY: N/A

namespace Neal_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] phone = new Phone[10];
            phone[0] = new HomePhone("CompuTest", "(303) 985 - 5060", "1");
            phone[1] = new CellPhone("Curtis Manufacturing", "(603) 532 - 4123", "2");
            phone[2] = new HomePhone("Data Functions", "(800) 876 - 2524", "1");
            phone[3] = new HomePhone("Donnay Repair", "(708) 397 - 3330", "1");
            phone[4] = new HomePhone("ErgoNomic Inc", "(360) 434 - 3894", "1");
            phone[5] = new HomePhone("ErgoSource", "(800) 969 - 4374", "1");
            phone[6] = new CellPhone("Fox Bay Industries", "(800) 874 - 8527", "2");
            phone[7] = new CellPhone("Glare - Guard", "(800) 545 - 6254", "2");
            phone[8] = new CellPhone("Hazard Comm Specialists", "(407) 783 - 6641", "2");
            phone[9] = new CellPhone("Komfort Support", "(714) 472 - 4409", "2");

            for (int i = 0; i < phone.Length; i++)
            {
                Console.WriteLine(phone[i].Dial());
            }
        }
    }
}
