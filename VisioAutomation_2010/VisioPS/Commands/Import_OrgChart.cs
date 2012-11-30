using VisioPS.Extensions;
using VA = VisioAutomation;
using SMA = System.Management.Automation;

namespace VisioPS.Commands
{
    [SMA.Cmdlet(SMA.VerbsData.Import, "OrgChart")]
    public class Import_OrgChart : VisioPS.VisioPSCmdlet
    {
        [SMA.Parameter(Mandatory = true)]
        public string Filename { get; set; }

        protected override void ProcessRecord()
        {
            var scriptingsession = this.ScriptingSession;
            var oc = VA.Scripting.OrgChart.OrgChartBuilder.LoadFromXML(scriptingsession, this.Filename);
            this.WriteObject(oc);
        }
    }
}