﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        bool Commit();
    }
}
