﻿using SampleApp.Business.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Business.CommandHandlers
{
    public class CommandHandler<TCommand>  where TCommand : ICommand
    {
    }
}