using SMA = System.Management.Automation;

namespace VisioPS.Commands
{
    [SMA.Cmdlet("Open", "VisioDocument")]
    public class Open_VisioDocument : VisioPS.VisioPSCmdlet
    {
        [SMA.Parameter(Position = 0, Mandatory = true)]
        public string Filename { get; set; }

        protected override void ProcessRecord()
        {
            var scriptingsession = this.ScriptingSession;
            var doc = scriptingsession.Document.Open(this.Filename);
            this.WriteObject(doc);
        }
    }
}