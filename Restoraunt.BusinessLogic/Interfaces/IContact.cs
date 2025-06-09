﻿using Restoraunt.Domain.Entities.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restoraunt.BusinessLogic.Interfaces
{
    public interface IContact
    {
        List<ContactDTO> GetAllContacts();
        ContactDTO GetContactById(int id);
        bool CreateContact(ContactDTO newContact);
        bool DeleteContact(int id);
    }
}
