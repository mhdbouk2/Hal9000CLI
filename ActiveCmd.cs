using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hal9000Cli
{
    [Command(Name = "active", Description = "Set slack status to Active")]
    public class ActiveCmd
    {
        protected Task<int> OnExecute(CommandLineApplication app)
        {
            return Task.FromResult(0);
        }
    }
}
