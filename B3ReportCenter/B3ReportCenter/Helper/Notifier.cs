using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter.Helper
{
    public abstract class Notifier : INotifyPropertyChanged
    {
        #region Events
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Member Methods
        /// <summary>
        /// Notifies any listeners that a property has changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that has
        /// changed.</param>
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion  v
    }
}
