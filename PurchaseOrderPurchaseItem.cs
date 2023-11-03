using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHD_ChallengeDesktop
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPurchaseItem
    {
        private string partNumberField;

        private float quantityField;

        private float costPerField;

        private string purchaserField;

        private string projectField;

        /// <remarks/>
        public string partNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }

        /// <remarks/>
        public float quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public float costPer
        {
            get
            {
                return this.costPerField;
            }
            set
            {
                this.costPerField = value;
            }
        }

        /// <remarks/>
        public string purchaser
        {
            get
            {
                return this.purchaserField;
            }
            set
            {
                this.purchaserField = value;
            }
        }

        /// <remarks/>
        public string project
        {
            get
            {
                return this.projectField;
            }
            set
            {
                this.projectField = value;
            }
        }

    }
}
