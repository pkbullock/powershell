﻿
using PnP.PowerShell.Commands.Base.PipeBinds;
using System;
using System.Linq;
using System.Management.Automation;

namespace PnP.PowerShell.Commands.Pages
{
    [Cmdlet(VerbsCommon.Get, "PnPPageComponent")]
    [Alias("Get-PnPClientSideComponent")]
    public class GetPageComponent : PnPWebCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true, Position = 0)]
        public PagePipeBind Page;

        [Parameter(Mandatory = false, ValueFromPipeline = true)]
        public Guid InstanceId;

        [Parameter(Mandatory = false, ValueFromPipeline = false)]
        public SwitchParameter ListAvailable;

        protected override void ExecuteCmdlet()
        {
            var clientSidePage = Page.GetPage();

            if (clientSidePage == null)
                throw new Exception($"Page '{Page?.Name}' does not exist");

            if(!ParameterSpecified(nameof(InstanceId)))
            {
                if(ParameterSpecified(nameof(ListAvailable)))
                {
                    var allComponents = clientSidePage.AvailablePageComponents().Where(c => c.ComponentType == 1);
                    WriteObject(allComponents, true);
                } else {
                WriteObject(clientSidePage.Controls, true);
                }
            } else
            {
                WriteObject(clientSidePage.Controls.FirstOrDefault(c => c.InstanceId == InstanceId));
            }

        }
    }
}