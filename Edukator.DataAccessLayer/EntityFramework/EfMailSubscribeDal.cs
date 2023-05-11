﻿using Edukator.DataAccessLayer.Repositories;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfMailSubscribeDal: GenericRepository<MailSubscribe>, IMailSubscribeDal 
    {
    }
}
