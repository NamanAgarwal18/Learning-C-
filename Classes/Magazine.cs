using System;

namespace Classes {
    public class Magazine: Book {
        private string _publisher;
        private int _pagecount;
        private decimal _price;

        public Magazine(string name, string publisher, int pagecount, decimal price) : base(name,"No Author", pagecount){
            _publisher = publisher;
        }

        public string Publisher {
            get => _publisher;
            set => _publisher = value;
        }
    }
}