using System;
using System.Collections.Generic;

namespace HomeTask4_10
{
    class Program
    {
        enum ArticleType
        {
            smallProduct,
            averageProduct,
            bigProduct,
            veryBigProduct
        }
        struct Article
        {
            public int productId;
            public string productName;
            public float productCost;
            public ArticleType productType;
            
            public Article(int productId, string productName, float productCost, ArticleType productType)
            {
                this.productId = productId;
                this.productName = productName;
                this.productCost = productCost;
                this.productType = productType;
            }
        }

        enum ClientType
        {
            standartPerson,
            importantPerson,
            VIP
        }
        struct Client
        {
            public string fullName;
            public string Address;
            public int allOrdersNumber;
            public int allOrdersCost;
            public ClientType clientType;

            public Client(string fullName, string Address, int allOrdersNumber, int allOrdersCost, ClientType clientType)
            {
                this.fullName = fullName;
                this.Address = Address;
                this.allOrdersNumber = allOrdersNumber;
                this.allOrdersCost = allOrdersCost;
                this.clientType = clientType;
            }
        }

        struct RequestItem
        {
            public Article product;
            public int number;

            public RequestItem (Article product, int number)
            {
                this.product = product;
                this.number = number;
            }
        }

        enum PayType
        {
            cash,
            card,
            phoneNumber
        }
        struct Request
        {
            public uint requestCode;
            public Client client;
            public DateTime requestDate;
            public List<RequestItem> requestedItems;
            public int totalCost;
            public PayType payType;

            Request (uint requestCode, Client client, DateTime requestDate, List<RequestItem> requestedItems, PayType payType)
            {
                this.requestCode = requestCode;
                this.client = client;
                this.requestDate = requestDate;
                this.requestedItems = requestedItems;

                totalCost = 0;
                foreach (RequestItem item in requestedItems)
                {
                    totalCost += (int)(item.number * item.product.productCost);
                }

                this.payType = payType;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
