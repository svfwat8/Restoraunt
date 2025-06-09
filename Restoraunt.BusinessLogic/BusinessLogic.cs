﻿using Restoraunt.BusinessLogic.Interfaces;
using Restoraunt.BusinessLogic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBl()
        {
            return new SessionBL();
        }
        public IContact GetContactBL()
        {
            return new ContactBL();
        }
        public IUser GetUserBL()
        {
            return new UserBL();
        }
        public IOrder GetOrderBL()
        {
            return new OrderBL();
        }
        public IProduct GetProductBL()
        {
            return new ProductBL();
        }
        public ICart GetCartBL()
        {
            return new CartBL();
        }
    }
}
