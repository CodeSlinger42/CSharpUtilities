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
        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
