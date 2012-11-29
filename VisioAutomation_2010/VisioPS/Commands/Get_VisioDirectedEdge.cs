using SMA = System.Management.Automation;
using VA = VisioAutomation;

namespace VisioPS.Commands
{
    [SMA.Cmdlet("Get", "VisioDirectedEdge")]
    public class Get_VisioDirectedEdge : VisioPSCmdlet
    {
        [SMA.Parameter(Position = 1, Mandatory = false)]
        public VisioAutomation.Connections.ConnectorArrowEdgeHandling TreatAsConnected { get; set; }

        protected override void ProcessRecord()
        {
            var scriptingsession = this.ScriptingSession;
            var edges = scriptingsession.Connection.GetDirectedEdges(TreatAsConnected);
            this.WriteObject(edges);
        }
    }
}