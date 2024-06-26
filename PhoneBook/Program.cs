using PhoneBook.Models;
using PhoneBook.ContactService;
using System.Collections.Generic;
using System;
using PhoneBook.Services;

namespace PhoneBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactService contactService = new ContactService();
            contactService.PopulateContact();
            contactService.AddContact();
            //contactService.CheckValideIndex();
            contactService.ShowAllDates();

        }
    }
}