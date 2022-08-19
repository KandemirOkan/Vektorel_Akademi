using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net
{
        public class Categories
        {

            private int categoryIDField;

            private string categoryNameField;

            private string descriptionField;

            private string pictureField;

            /// <remarks/>
            public int CategoryID
            {
                get
                {
                    return this.categoryIDField;
                }
                set
                {
                    this.categoryIDField = value;
                }
            }

            /// <remarks/>
            public string CategoryName
            {
                get
                {
                    return this.categoryNameField;
                }
                set
                {
                    this.categoryNameField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string Picture
            {
                get
                {
                    return this.pictureField;
                }
                set
                {
                    this.pictureField = value;
                }
            }
        }
    }
