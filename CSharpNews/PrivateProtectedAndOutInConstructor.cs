using System;

namespace CSharpNews
{
    public class PrivateProtectedAndOutInConstructor
    {
        public PrivateProtectedAndOutInConstructor(string title, DateTime birthdDate, out int age)
        {
            age = Convert.ToInt32(DateTime.Now.Subtract(birthdDate).TotalDays / 365);
        }

        public int Id { get; set; }
        private protected string Title { get; set; }
        public int Age { get; set; }
    }
}