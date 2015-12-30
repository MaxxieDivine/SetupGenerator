using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupGenerator
{
    class Card
    {
        public string cardName;
        public string cardCost;
        public string cardType;
        public string cardText;
        public string cardSet;

        public string Name
        {
            get { return this.cardName; }
            set { this.cardName = value; }
        }

        public string Cost
        {
            get { return this.cardCost; }
            set { this.cardCost = value; }
        }

        public string Type
        {
            get { return this.cardType; }
            set { this.cardType = value; }
        }

        public string Text
        {
            get { return this.cardText; }
            set { this.cardText = value; }
        }

        public string Set
        {
            get { return this.cardSet; }
            set { this.cardSet = value; }
        }
    }
}
