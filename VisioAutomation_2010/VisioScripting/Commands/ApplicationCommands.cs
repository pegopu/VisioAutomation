using VisioAutomation.Extensions;
using IVisio = Microsoft.Office.Interop.Visio;
using VA = VisioAutomation;

namespace VisioScripting.Commands
{
    public class ApplicationCommands : CommandSet
    {
        public IVisio.Application VisioApplication { get; set; }

        public ApplicationWindowCommands Window { get; private set; }

        internal ApplicationCommands(Client client) :
            this(client, null)
        {
        }

        internal ApplicationCommands(Client client, IVisio.Application application) :
            base(client)
        {
            this.Window = new ApplicationWindowCommands(this._client);
            this.VisioApplication = application;
        }

        public bool HasApplication
        {
            get
            {
                bool b = this.VisioApplication != null;
                this._client.WriteVerbose("HasApplication: {0}", b);
                return b;
            }
        }

        public IVisio.Application Get()
        {
            return this.VisioApplication;
        }

        public void AssertApplicationAvailable()
        {
            var has_app = this._client.Application.HasApplication;
            if (!has_app)
            {
                throw new System.ArgumentException("No Visio Application available");
            }
        }

        public void Close(bool force)
        {
            var app = this._client.Application.Get();

            if (app == null)
            {
                this._client.WriteWarning("There is no Visio Application to stop");
                return;
            }

            if (force)
            {
                // If you want to force the thing to close
                // it will require closing all documents and then quiting
                var documents = app.Documents;

                while (documents.Count > 0)
                {
                    var active_document = app.ActiveDocument;
                    active_document.Close(true);
                }

                app.Quit(true);
            }
            else
            {
                app.Quit();
            }
            this.VisioApplication = null;
        }

        public IVisio.Application New()
        {
            this._client.WriteVerbose("Creating a new Instance of Visio");
            var app = new IVisio.Application();
            this._client.WriteVerbose("Attaching that instance to current scripting client");
            this.VisioApplication = app;
            return app;
        }

        public void Undo()
        {
            this._client.Application.AssertApplicationAvailable();
            this.VisioApplication.Undo();
        }

        public void Redo()
        {
            this._client.Application.AssertApplicationAvailable();
            this.VisioApplication.Redo();
        }

        public bool Validate()
        {
            if (this.VisioApplication == null)
            {
                this._client.WriteVerbose("Client's Application object is null");
                return false;
            }

            try
            {
                // try to do something simple, read-only, and fast with the application object
                //  if No COMException was thrown when reading ProductName property. This application instance is treated as valid

                var app_version = this.VisioApplication.ProductName;
                this._client.WriteVerbose("Application validated");
                return true;
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                this._client.WriteVerbose("COMException thrown during validation. Treating as invalid application");
                // If a COMException is thrown, this indicates that the
                // application object is invalid
                return false;
            }
        }

        private static System.Version visio_app_version;

        public System.Version Version
        {
            get
            {
                if (ApplicationCommands.visio_app_version == null)
                {
                    this._client.Application.AssertApplicationAvailable();
                    var application = this._client.Application.Get();
                    ApplicationCommands.visio_app_version = VisioAutomation.Application.ApplicationHelper.GetVersion(application);
                }
                return ApplicationCommands.visio_app_version;
            }            
        }

        public VA.Application.UndoScope NewUndoScope(string name)
        {
            if (this.VisioApplication == null)
            {
                throw new System.ArgumentException("Cant create UndoScope. There is no visio application attached.");
            }

            return new VA.Application.UndoScope(this.VisioApplication, name);
        }
    }
}