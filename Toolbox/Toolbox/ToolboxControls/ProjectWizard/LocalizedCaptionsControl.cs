﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetOffice.DeveloperToolbox.ToolboxControls.ProjectWizard
{
    /// <summary>
    /// Message Table Helper
    /// </summary>
    [RessourceTable("ToolboxControls.ProjectWizard.CaptionStrings.txt")]
    public partial class LocalizedCaptionsControl : UserControl, ILocalizationDesign
    {
        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public LocalizedCaptionsControl()
        {
            InitializeComponent();
        }

        #endregion 

        #region ILocalizedDesign

        public void EnableDesignView(int lcid, string parentComponentName)
        {

        }

        public void Localize(Translation.ItemCollection strings)
        {
            Translation.Translator.TranslateControls(this, strings);
        }

        public void Localize(string name, string text)
        {
            Translation.Translator.TranslateControl(this, name, text);
        }

        public string GetCurrentText(string name)
        {
            return Translation.Translator.TryGetControlText(this, name);
        }

        public IContainer Components
        {
            get { return components; }
        }

        public string NameLocalization
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<ILocalizationChildInfo> Childs
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
