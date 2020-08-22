// <copyright file="INPC.cs" company="CodeSlinger42">
// Copyright (c) CodeSlinger42. All rights reserved.
// </copyright>

namespace CSharpUtilities
{
    using System.ComponentModel;

    /// <summary>
    /// Helper class to so we can easily implement the INotifyPropertyChanged interace.
    /// This give FodyPropertyChanged something to add code to.
    /// </summary>
    public class INPC : INotifyPropertyChanged
    {
        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="name">Name of the property that changed.</param>
        public void OnPropertyChanged(string name)
        {
            var e = new PropertyChangedEventArgs(name);
            PropertyChanged?.Invoke(this, e);
        }

        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
