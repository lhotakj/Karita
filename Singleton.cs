
using System;
using System.Windows.Forms;

namespace GpxHeatmap
{
    public class Singleton
    {
        private static Singleton instance;

        private string _log = "";
        private Boolean _log_form_exists = false;

        public void AppendToLog(string i)
        {
            this._log += Environment.NewLine + i;
        }

        public void DestroyLogForm()
        {
            this._log_form_exists = false;
        }

        public void CreateLogForm()
        {
            this._log_form_exists = true;
        }

        public Boolean ExistsLogForm()
        {
            return this._log_form_exists;
        }


        private Singleton() {

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}