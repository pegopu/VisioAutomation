using SMA = System.Management.Automation;
using IVisio = Microsoft.Office.Interop.Visio;

namespace VisioPowerShell.Commands
{
    [SMA.Cmdlet(SMA.VerbsCommon.Open, VisioPowerShell.Commands.Nouns.VisioMaster)]
    public class OpenVisioMaster : VisioCmdlet
    {
        [SMA.Parameter(Position = 0, Mandatory = true)]
        [SMA.ValidateNotNull]
        public IVisio.Master Master;

        protected override void ProcessRecord()
        {
            this.Client.Master.OpenForEdit(this.Master);
        }
    }
}