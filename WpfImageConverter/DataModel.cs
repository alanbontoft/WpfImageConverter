using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfImageConverter
{
    public class DataModel : ObservableObject
    {

        private string _fillColor;
        private string _image;

        public string FillColor
        {
            get { return _fillColor; }

            set
            {
                if (value != _fillColor)
                {
                    _fillColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Image
        {
            get { return _image; }

            set
            {
                if (value != _image)
                {
                    _image = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
