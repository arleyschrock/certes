﻿using Certes.Cli.Options;
using NLog;
using System.Threading.Tasks;

namespace Certes.Cli.Processors
{
    internal abstract class CommandBase<T>
        where T : OptionsBase
    {
        public T Options { get; }
        public ILogger ConsoleLogger { get; }

        public CommandBase(T options, ILogger consoleLogger)
        {
            this.Options = options;
            this.ConsoleLogger = consoleLogger;
        }

        public abstract Task<AcmeContext> Process(AcmeContext context);
    }
}
