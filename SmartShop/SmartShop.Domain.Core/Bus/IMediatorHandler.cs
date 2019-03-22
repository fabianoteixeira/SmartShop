using SmartShop.Domain.Core.Commands;
using SmartShop.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        Task RaiseEvent<T>(T command) where T : Event;
    }
}
    