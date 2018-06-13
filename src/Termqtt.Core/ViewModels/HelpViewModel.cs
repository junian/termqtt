using System;
using Juniansoft.Termqtt.Core.Resources;

namespace Juniansoft.Termqtt.Core.ViewModels
{
    public class HelpViewModel: BaseViewModel
    {
        public HelpViewModel()
        {
        }

        public string Content
        {
            get => LoadHelpContent(AppResources.DocumentationMd);
        }

        private string LoadHelpContent(string md)
        {
            var result = CommonMark.CommonMarkConverter.Convert(md);
            return result;
        }
    }
}
