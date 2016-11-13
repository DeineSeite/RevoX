using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RevoProjectX
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {

        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            try
            {
                var imageSource = ImageSource.FromResource("R2B0app.Images." + Source);
                if (imageSource == null)
                    System.Diagnostics.Debug.WriteLine("******** ProvideValue null " + Source);
                return imageSource;
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine("******** ProvideValue " + err.Message);
                return null;
            }
        }

    }
}
